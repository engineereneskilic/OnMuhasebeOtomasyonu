using _DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BusinessLayer
{
    public class BillBusiness : db_operation
    {
        //Dolu Tablolar(Singletion Pattern)
        Bills newBill = Bills.Instance;
        BillDetail newBillDetails = BillDetail.Instance;

        public override void List(DataGridView coming_datagridview)
        {
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                foreach (var item in db.Bills)
                {
                    coming_datagridview.Rows.Add(item.ProcessDate.ToString().Substring(0,10), item.ProcessType, item.BillCode, item.CurrentName, item.NetDebt, item.NetCredit, item.Currency, item.Discount,item.Expense,item.Term);
                }
            }
        }

        int birKereKaydet = 0;
        private void StokHareketi()
        {
            StockMovements stokMovements = StockMovements.Instance;

            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {

                // Stok hareketi
                var UnitValue =
                (
                from s in db.Stock
                where s.StockCode == newBillDetails.StockCode
                select new
                {
                    Number = s,
                    Text =
                    (
                        newBillDetails.UnitType == s.StockMainUnitType ? "1" :
                        newBillDetails.UnitType == s.StockSecondUnitType ? s.StockSecondUnit.ToString() :
                        newBillDetails.UnitType == s.StockThirdUnitType ? s.StockThirdUnit.ToString() : "bilinmiyor"
                    )
                }
                );
                stokMovements.ProcessDate = newBill.ProcessDate;
                stokMovements.ProcessType = newBill.ProcessType;
                stokMovements.CurrentCode = newBill.CurrrentCode;
                stokMovements.CurrentName = newBill.CurrentName;
                stokMovements.StockCode = newBillDetails.StockCode;
                foreach (var k in UnitValue)
                {
                    if (newBill.ProcessType == "Alış Faturası")
                    {

                        stokMovements.IncomingAmount = (Convert.ToInt32(newBillDetails.IncomingAmount) * Convert.ToInt32(k.Text)); // anabirime dönüştür
                        stokMovements.TotalAmount = newBill.NetCredit;


                    }
                    else
                    {
                        stokMovements.Yield = (Convert.ToInt32(newBillDetails.Yield) * Convert.ToInt32(k.Text));
                        stokMovements.TotalAmount = newBill.NetDebt;


                    }
                }
                stokMovements.UnitPrice = newBillDetails.UnitPrice;
                stokMovements.Discount = Convert.ToInt32(newBill.Discount);
                stokMovements.BillCode = newBill.BillCode;

                // Buraya kadar verilerimi yükledik fakat bu fatura ya daha önceden stoğu hareketlenmişse o zaman yeni hareket eklemeye gerek yok yüklü bilgilerimiz ile güncelleyelim

                var stockmovent = from sm in db.StockMovements where sm.StockCode == newBillDetails.StockCode && sm.BillCode==newBillDetails.BillCode select sm; // stok kodu varsa
                if (stockmovent.Count() != 0)
                {
                    StockMovements stokcmovement = db.StockMovements.First(x => x.BillCode == newBillDetails.BillCode && x.StockCode==newBillDetails.StockCode);


                }else
                {
                    db.StockMovements.Add(stokMovements);
                }
                db.SaveChanges();
            }
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                var UpdateStock = db.Stock.Where(c => c.StockCode == newBillDetails.StockCode).FirstOrDefault();
                if (newBill.ProcessType == "Alış Faturası")
                {
                    // Stok gereken değreini alsın
                    UpdateStock.StockMainUnit =  Convert.ToInt32(cammonClass.ZeroIfEmpty(UpdateStock.StockMainUnit.ToString())) + Convert.ToInt32(cammonClass.ZeroIfEmpty(stokMovements.IncomingAmount.ToString()));
                    db.SaveChanges();
                }
                else
                {

                    UpdateStock.StockMainUnit =  Convert.ToInt32( cammonClass.ZeroIfEmpty(UpdateStock.StockMainUnit.ToString()))- Convert.ToInt32(cammonClass.ZeroIfEmpty(stokMovements.Yield.ToString()));
                    db.SaveChanges();
                }
            }
        }
        private void CariHareketi()
        {
            AccountMovements accountMovement = AccountMovements.Instance;

            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                // Carinin giriş çıkışını güncelle gelen faturaya göre
                var UpdateCurrentCard = db.CurrentCards.Where(uc => uc.CurrentCode==newBill.CurrrentCode).FirstOrDefault();
                if (newBill.ProcessType == "Alış Faturası")
                {
                    UpdateCurrentCard.BalanceCredit = newBill.NetCredit;
                }
                else
                {
                    UpdateCurrentCard.BalanceDebt = newBill.NetDebt;
                }
                // cari hareketi ekle
                accountMovement.MovementDate = newBill.ProcessDate;
                accountMovement.SequenceNo = newBill.BillCode;
                accountMovement.ProcessType = newBill.ProcessType;
                accountMovement.Descript = newBill.Description;
                accountMovement.Debt =  newBill.NetDebt;
                accountMovement.Credit = newBill.NetCredit;
                accountMovement.Currency = newBill.Currency;
                accountMovement.CurrentCode = newBill.CurrrentCode;

                // aynı cari hareketi varsa eklenmesin bunu kontrolüde hesap hareketindeki seri no değeri işlemler listesinin genel değeridir. Tüm işlemler hesap hareketlerinde olur. İşlem
                //numaraları eklenirken o anki işlemin idsi kaydedilirki sonradan ilgili işlemle ilgili güncelleme yapabilelim tabi idler çakışır ama işlem tipleriyle beraber değil
                var is_accountMovement = from ac in db.AccountMovements where ac.SequenceNo == newBill.BillCode && ac.ProcessType==newBill.ProcessType select ac; 
                if (is_accountMovement.Count() != 0)
                {
                    AccountMovements  have_accountMovement = db.AccountMovements.First(x => x.SequenceNo == newBill.BillCode && x.ProcessType==newBill.ProcessType);


                }
                else
                {
                    db.AccountMovements.Add(accountMovement);
                }
                db.SaveChanges();
            }
        }

        public override void Insert_Update()
        {

            birKereKaydet++;
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                // burda iki tablonunda bağlamamın diğer bir nedeni güvenlik
                 var Billvarmi = (from b in db.Bills join bd in db.BillDetail on b.BillCode equals bd.BillCode where b.BillCode == newBill.BillCode select b);


                var BillDetailvarmi = (from b in db.Bills join bd in db.BillDetail on b.BillCode equals bd.BillCode where bd.BillCode == newBill.BillCode && bd.StockBarcode==newBillDetails.StockBarcode select b);


                if (Billvarmi.Count() == 0)
                {
                    if (birKereKaydet == 1) { db.Bills.Add(newBill); }
                    db.BillDetail.Add(newBillDetails);
                    if (db.SaveChanges() > 0) { StokHareketi(); CariHareketi(); }
                }
                if (BillDetailvarmi.Count() == 0)
                {

                    db.BillDetail.Add(newBillDetails);
                    if (db.SaveChanges() > 0) { StokHareketi(); } 
                }
                else
                {
                    Bills OldBills = db.Bills.FirstOrDefault(eski => eski.BillCode == newBill.BillCode);
                    OldBills.BillCode = newBill.BillCode;
                    OldBills.ProcessType = newBill.ProcessType;
                    OldBills.ProcessTime = newBill.ProcessTime;
                    OldBills.CurrrentCode = newBill.CurrrentCode;
                    OldBills.CurrentName = newBill.CurrentName;
                    OldBills.NetDebt = newBill.NetDebt;
                    OldBills.NetCredit = newBill.NetCredit;
                    OldBills.Currency = newBill.Currency;
                    OldBills.Discount = newBill.Discount;
                    OldBills.Expense = newBill.Expense;
                    OldBills.Kdv = newBill.Kdv;
                    OldBills.KdvType = newBill.KdvType;
                    OldBills.Term = newBill.Term;
                    OldBills.Description = newBill.Description;


                    db.SaveChanges();

                    BillDetail OldBillDetails = db.BillDetail.FirstOrDefault(eski => eski.BillCode == newBillDetails.BillCode && eski.StockBarcode == newBillDetails.StockBarcode);
                    OldBills.BillCode = newBill.BillCode;
                    OldBillDetails.LineType = newBillDetails.LineType;
                    OldBillDetails.StockBarcode = newBillDetails.StockBarcode;
                    OldBillDetails.StockCode = newBillDetails.StockCode;
                    OldBillDetails.Discript = newBillDetails.Discript;
                    OldBillDetails.UnitType = newBillDetails.UnitType;
                    OldBillDetails.IncomingAmount = newBillDetails.IncomingAmount;
                    OldBillDetails.Yield = newBillDetails.Yield;
                    //if (newBill.ProcessType == "Alış Faturası") OldBillDetails.IncomingAmount = newBillDetails.IncomingAmount; else OldBillDetails.Yield = newBillDetails.Yield;
                    OldBillDetails.UnitPrice = newBillDetails.UnitPrice;
                    OldBillDetails.LineTotalAmount = newBillDetails.LineTotalAmount;
                    OldBillDetails.KdvPercent = newBillDetails.KdvPercent;
                    OldBillDetails.DiscountPercent = newBillDetails.DiscountPercent;

                   db.SaveChanges();

                }
            }
        }

        public override void Delete(int _Id)
        {
                using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
                {
                    // Dışarıdan aldığımız id yi veritabanındaki aynı id deki kayıt ile eşleştiriyoruz.

                    db.Bills.Remove(db.Bills.Find(_Id));

                // fatura detayını sil
                    var is_billdetail = from bd in db.BillDetail  where bd.BillCode == _Id select bd;
                    if (is_billdetail !=null)
                    {
                        db.BillDetail.RemoveRange(is_billdetail);
                        db.SaveChanges();
                    }
                // stok hareketi sil
                   var is_stockmovement = from sm in db.StockMovements where sm.BillCode == _Id select sm;
                   if (is_stockmovement.Count()!=0)
                    {
                        db.StockMovements.RemoveRange(is_stockmovement);
                        db.SaveChanges();
                    }
                    var is_accountmovement = from a in db.AccountMovements where a.SequenceNo == _Id select a;
                //cari hareket sil
               
                    if (is_accountmovement.Count()!=0)
                    {

                        db.AccountMovements.RemoveRange(is_accountmovement);
                        db.SaveChanges();
                    }   
                }
        }

        public override DataTable Query(int incoming_id)
        {
        
            DataTable dataTable = new DataTable();
           
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                // Önemli Not: Ms sql Server double veritipi bulundurmuyor onun yerine float kullanıyor. DataTable a gönderirken c#'da float olmadığı için string türünde Datatable
                // atıyacağız. Daha sonradan kullancağımız yerlerde tekrar double döndürerek kullanmamız gerek
                var query = from b in db.Bills join bd in db.BillDetail on b.BillCode equals bd.BillCode where b.BillCode == incoming_id select new { b, bd };
                
                dataTable.Columns.Add("BillCode", typeof(System.Int32));

                dataTable.Columns.Add("ProcessType", typeof(System.String));
                
                dataTable.Columns.Add("ProcessDate", typeof(System.DateTime));
                dataTable.Columns.Add("ProcessTime", typeof(System.TimeSpan));
               
                dataTable.Columns.Add("CurrrentCode", typeof(System.Int32));
                
                dataTable.Columns.Add("CurrentName", typeof(System.String));
              
                dataTable.Columns.Add("NetDebt", typeof(System.String));
                
                dataTable.Columns.Add("NetCredit", typeof(System.String));
             

                dataTable.Columns.Add("Currency", typeof(System.String));
               
                dataTable.Columns.Add("Discount", typeof(System.String));
               
                dataTable.Columns.Add("Expense", typeof(System.String));
                dataTable.Columns.Add("Kdv", typeof(System.String));
                dataTable.Columns.Add("KdvType", typeof(System.String));
                dataTable.Columns.Add("Term", typeof(System.String));
                dataTable.Columns.Add("Description", typeof(System.String));
            
              
                
                dataTable.Columns.Add("LineType", typeof(System.String));
              
                dataTable.Columns.Add("StockBarcode", typeof(System.Int64));
                
                dataTable.Columns.Add("StockCode", typeof(System.Int32));
                
                dataTable.Columns.Add("Discript", typeof(System.String));
                
                dataTable.Columns.Add("UnitType", typeof(System.String));
                
                dataTable.Columns.Add("IncomingAmount", typeof(System.String));
                
                dataTable.Columns.Add("Yield", typeof(System.String));
               
                dataTable.Columns.Add("UnitPrice", typeof(System.String));
                
                dataTable.Columns.Add("LineTotalAmount", typeof(System.String));
                dataTable.Columns.Add("KdvPercent", typeof(System.String));
                dataTable.Columns.Add("DiscountPercent", typeof(System.String));
             
             

                DataRow datarow;

                foreach (var item in query)
                {
                    
                    
                    datarow = dataTable.NewRow();
                    datarow["BillCode"] = item.b.BillCode;
                    datarow["ProcessType"] = item.b.ProcessType;
                    datarow["ProcessDate"] = item.b.ProcessDate;
                    datarow["ProcessTime"] = item.b.ProcessTime;
                    datarow["CurrrentCode"] = item.b.CurrrentCode;
                    datarow["CurrentName"] = item.b.CurrentName;
                    datarow["NetDebt"] = item.b.NetDebt.ToString();
                    datarow["NetCredit"] = item.b.NetCredit.ToString();                
                    datarow["Currency"] = item.b.Currency;
                 
                    datarow["Discount"] = Convert.ToString(item.b.Discount); 
                    
                    datarow["Expense"] = item.b.Expense.ToString();
                    datarow["Kdv"] = item.b.Kdv.ToString();
                    datarow["KdvType"] = item.b.KdvType.ToString();
                    datarow["Term"] = item.b.Term;
                    datarow["Description"] = item.b.Description;
                    
                    datarow["LineType"] = item.bd.LineType;
                    
                    datarow["StockBarcode"] = item.bd.StockBarcode;
                   
                    datarow["StockCode"] = item.bd.StockCode;
                   
                    datarow["Discript"] = item.bd.Discript;
                   
                    datarow["UnitType"] = item.bd.UnitType;

                    datarow["IncomingAmount"] = item.bd.IncomingAmount.ToString();
                    
                    datarow["Yield"] = item.bd.Yield.ToString();
                    datarow["UnitPrice"] = item.bd.UnitPrice.ToString();
                    datarow["LineTotalAmount"] = item.bd.LineTotalAmount.ToString();
                    datarow["KdvPercent"] = item.bd.KdvPercent.ToString();
                    datarow["DiscountPercent"] = item.bd.DiscountPercent.ToString();

                    //MessageBox.Show(datarow["ProcessTime"].ToString());
                    dataTable.Rows.Add(datarow);
                }
                       
               
                    return dataTable;
            }
          
        }

        public override int TableRowCount()
        {
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                return db.Bills.Count();
            }
        }
    }
    
}
