using _DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BusinessLayer
{
    public class BankBusiness : db_operation
    {
        //Dolu Tablolar(Singletion Pattern)
        Banks newBank = Banks.Instance;
        BankProcess newBankProcess = BankProcess.Instance;

        public override void Insert_Update()
        {
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {

                if (newBankProcess.ProcessType == "Gelen Havale" || newBankProcess.ProcessType == "Gönderilen Havale")
                {
                    var bankprocess_query = from bp in db.BankProcess where bp.BankAccountNo == newBankProcess.BankAccountNo && bp.ProcessType==newBankProcess.ProcessType select bp;
                    if (bankprocess_query.Count() != 0)
                    {
                     
                        BankProcess oldBankProcess = db.BankProcess.First(x => x.BankProcessNo == newBankProcess.BankProcessNo);
                        
                        oldBankProcess.BankAccountNo = newBankProcess.BankAccountNo;
                        oldBankProcess.ProcessType = newBankProcess.ProcessType;
                        oldBankProcess.ProcessDate = newBankProcess.ProcessDate;
                        oldBankProcess.CurrentCode = newBankProcess.CurrentCode;
                        oldBankProcess.CurrentName = newBankProcess.CurrentName;
                        oldBankProcess.Descript = newBankProcess.Descript;
                        oldBankProcess.NetCredit = newBankProcess.NetCredit;
                        oldBankProcess.NetDebt = newBankProcess.NetDebt;
                        oldBankProcess.Expense = newBankProcess.Expense;
                        oldBankProcess.Currency = newBankProcess.Currency;
                        
                    }
                    else
                    {
                        db.BankProcess.Add(newBankProcess);
  
                    }
                    if (db.SaveChanges() > 0) { MessageBox.Show("Kaydedildi/güncellendi"); CariHareketi(); } else { MessageBox.Show("Process olmadı"); }

                }
                else
                {
                    //Banka hesabı açma
                    var query = (from b in db.Banks where b.BankAccountNo == newBank.BankAccountNo select b);

                    if (query.Count() == 0)// boşsa sorgu sayısı
                    {
                        db.Banks.Add(newBank);
                        if (db.SaveChanges() > 0) { MessageBox.Show("Kaydedildi");} else { MessageBox.Show("Olmadı !"); }
                       

                    }
                    else
                    { // eğer kayıt varsa tablolarda yani yeni bir veri değilse o halde var olan veriler güncellensin

                        Banks OldBank = db.Banks.FirstOrDefault(eski => eski.BankAccountNo == newBank.BankAccountNo);
                        OldBank.BankAccountNo = newBank.BankAccountNo;
                        OldBank.IbanNo = newBank.IbanNo;
                        OldBank.BankName = newBank.BankName;
                        OldBank.BankAccountName = newBank.BankAccountName;
                        OldBank.BankBranch = newBank.BankBranch;
                        OldBank.BankAccountHolder = newBank.BankAccountHolder;
                        OldBank.BankAccountHolderAdress = newBank.BankAccountHolderAdress;
                        OldBank.BankAccountHolderPhone = newBank.BankAccountHolderPhone;
                        OldBank.BankBalance = newBank.BankBalance;
                        OldBank.Currency = newBank.Currency;


                        if (db.SaveChanges() > 0) MessageBox.Show("Güncellendi :)"); else MessageBox.Show("Güncellenemedi :(");

                    }
                }
            }
        }
        private void CariHareketi()
        {
            AccountMovements accountMovement = AccountMovements.Instance;
            // cari ile alakalı para işlemleri
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                // Carinin giriş fiyat çıkış fiyatı güncelleyelim gelen currencode göre
                var UpdateCurrentCard = db.CurrentCards.Where(uc => uc.CurrentCode == newBankProcess.CurrentCode).FirstOrDefault();
                if (newBankProcess.ProcessType == "Gelen Havale")
                {
                    //parayı cariden aldık - masrafta kestik çünkü cari pana havale yapıyo onun masrafını ben ödemiyeceğim cari ödeyecek
                    UpdateCurrentCard.BalanceDebt = UpdateCurrentCard.BalanceDebt - (newBankProcess.NetDebt + newBankProcess.Expense);



                    if (db.SaveChanges() > 0) MessageBox.Show("Gelen havale cari güncelllendi"); else MessageBox.Show("gelen havale cari güncellenmedi");

                    var UpdateBank = db.Banks.Where(b => b.BankAccountNo == newBankProcess.BankAccountNo).FirstOrDefault();
                    UpdateBank.BankBalance = UpdateBank.BankBalance + newBankProcess.NetDebt;
                    if (db.SaveChanges() > 0) MessageBox.Show("Para ilgili hesaba yatırıldı"); else MessageBox.Show("para hesaba yatırılmadı");

                }
                else if(newBankProcess.ProcessType == "Gönderilen Havale")
                {
                    // parayı cariye yatırdık - masraf kesmedik masraf benden yani gönderenden kesilcek
                    UpdateCurrentCard.BalanceCredit = UpdateCurrentCard.BalanceCredit + newBankProcess.NetCredit;

                    if (db.SaveChanges() > 0) MessageBox.Show("Gönderilen havale cari güncelllendi"); else MessageBox.Show("gönderilen havale cari güncellenmedi");


                    //parayı ilgili hesaptan çekiyoruz masraf kesicez çünkü parayı gönderen benim masrafı bana ayit
                    var UpdateBank = db.Banks.Where(b => b.BankAccountNo == newBankProcess.BankAccountNo).FirstOrDefault();
                    UpdateBank.BankBalance = UpdateBank.BankBalance - (newBankProcess.NetCredit + newBankProcess.Expense);
                    if (db.SaveChanges() > 0) MessageBox.Show("Para ilgili hesabtan çekildi"); else MessageBox.Show("para hesaptan çekilmedi");

                }
            }
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                if (newBankProcess.ProcessType == "Gelen Havale")
                {
                    //parayı ilgili hesaba yatıyoruz
                    /*
                    var UpdateBank = db.Banks.Where(b => b.BankAccountNo == newBankProcess.BankAccountNo).FirstOrDefault();
                    UpdateBank.BankBalance = UpdateBank.BankBalance + newBankProcess.NetDebt;
                    if (db.SaveChanges() > 0) MessageBox.Show("Para ilgili hesaba yatırıldı"); else MessageBox.Show("patates");
                    */
                }else
                if(newBankProcess.ProcessType == "Gönderilen Havale")
                {
                    /*
                    //parayı ilgili hesaptan çekiyoruz masraf kesicez çünkü parayı gönderen beren masrafı bana ağit
                    var UpdateBank = db.Banks.Where(b => b.BankAccountNo == newBankProcess.BankAccountNo).FirstOrDefault();
                    UpdateBank.BankBalance = UpdateBank.BankBalance - (newBankProcess.NetCredit + newBankProcess.Expense);
                    if (db.SaveChanges() > 0) MessageBox.Show("Para ilgili hesabtan çekildi"); else MessageBox.Show("patates");
                    */
                }

            }
                using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
                {
                // cari hareketi ekle
                accountMovement.MovementDate = newBankProcess.ProcessDate;
                accountMovement.SequenceNo = newBankProcess.BankProcessNo;
                accountMovement.ProcessType = newBankProcess.ProcessType;
                accountMovement.Descript = newBankProcess.Descript;
                accountMovement.Debt = newBankProcess.NetDebt;
                accountMovement.Credit = newBankProcess.NetCredit;
                accountMovement.Currency = newBankProcess.Currency;
                accountMovement.CurrentCode = newBankProcess.CurrentCode;

                // aynı cari hareketi varsa eklenmesin bunu kontrolüde hesap hareketindeki seri no değeri işlemler listesinin genel değeridir. Tüm işlemler hesap hareketlerinde olur. İşlem
                //numaraları eklenirken o anki işlemin idsi kaydedilirki sonradan ilgili işlemle ilgili güncelleme yapabilelim.
                var is_accountMovement = from am in db.AccountMovements where am.SequenceNo == newBankProcess.BankProcessNo && am.ProcessType == newBankProcess.ProcessType select am; // stok kodu varsa
                if (is_accountMovement.Count() != 0)
                {
                    AccountMovements have_accountMovement = db.AccountMovements.First(x => x.SequenceNo == newBankProcess.BankProcessNo && x.ProcessType == newBankProcess.ProcessType);
                    MessageBox.Show("var bu cari hareketten");


                }
                else
                {
                    db.AccountMovements.Add(accountMovement);
                }
                if (db.SaveChanges() > 0) MessageBox.Show("Cari hareketi eklendi/güncellendi"); else MessageBox.Show("patates");
                //burasıdın
            }
        }

        public override void List(DataGridView coming_datagridview)
        {
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                int sira_no = 0;
                foreach (var item in db.Banks)
                {
                    sira_no++;
                    coming_datagridview.Rows.Add(sira_no,item.BankAccountNo.ToString(),item.BankName,item.BankAccountName.ToString(),item.BankBalance.ToString(),item.Currency.ToString());
                }
            }
        }


        public override DataTable Query(int incoming_id)
        {
            DataTable datatable = new DataTable();

            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {

                var details = from b in db.Banks
                              join bp in db.BankProcess on b.BankAccountNo equals bp.BankAccountNo
                              where b.BankAccountNo == incoming_id
                              select new { b, bp };

                var query = from b in db.Banks where b.BankAccountNo == incoming_id select b;



                datatable.Columns.Add("BankAccountNo", typeof(System.String));
                datatable.Columns.Add("IbanNo", typeof(System.String));
                datatable.Columns.Add("BankName", typeof(System.String));
                datatable.Columns.Add("BankAccountName", typeof(System.String));
                datatable.Columns.Add("BankBranch", typeof(System.String));
                datatable.Columns.Add("BankAccountHolder", typeof(System.String));
                datatable.Columns.Add("BankAccountHolderAdress", typeof(System.String));
                datatable.Columns.Add("BankAccountHolderPhone", typeof(System.String));
                datatable.Columns.Add("BankBalance", typeof(System.String)); // double yapınca datatable column tipini datatable çalışmıyor.
                datatable.Columns.Add("Currency", typeof(System.String));

                DataRow datarow;
                if (details.Count() == 0) // detaya sahip deilse ilgili banka normal kendi verilerini alsın
                {
                    foreach (var item in query)
                    {


                        datarow = datatable.NewRow();

                        datarow["BankAccountNo"] = item.BankAccountNo.ToString();
                        datarow["IbanNo"] = item.IbanNo.ToString();
                        datarow["BankName"] = item.BankName.ToString();
                        datarow["BankAccountName"] = item.BankAccountName.ToString();
                        datarow["BankBranch"] = item.BankBranch.ToString();
                        datarow["BankAccountHolder"] = item.BankAccountHolder.ToString();
                        datarow["BankAccountHolderAdress"] = item.BankAccountHolderAdress.ToString();
                        datarow["BankAccountHolderPhone"] = item.BankAccountHolderPhone.ToString();
                        datarow["BankBalance"] = item.BankBalance.ToString();
                        datarow["Currency"] = item.Currency.ToString();

                        datatable.Rows.Add(datarow);
                    }
                }
                else
                {

                    datatable.Rows.Clear();
                    //datatable.Columns.Add("BankAccountNo", typeof(System.Int32));
                    datatable.Columns.Add("ProcessType", typeof(System.String));
                    datatable.Columns.Add("ProcessDate", typeof(System.String)); // date diyince dönmüyor c# date ile ms sql'deki
                    datatable.Columns.Add("CurrentName", typeof(System.String));
                    datatable.Columns.Add("Descript", typeof(System.String));
                    datatable.Columns.Add("NetCredit", typeof(System.String));
                    datatable.Columns.Add("NetDebt", typeof(System.String));
                    datatable.Columns.Add("Expense", typeof(System.String));
                    //datatable.Columns.Add("Currency", typeof(System.String));

                    foreach (var item in details)
                    {


                        datarow = datatable.NewRow();

                        datarow["BankAccountNo"] = item.b.BankAccountNo.ToString();
                        datarow["IbanNo"] = item.b.IbanNo.ToString();
                        datarow["BankName"] = item.b.BankName.ToString();
                        datarow["BankAccountName"] = item.b.BankAccountName;
                        datarow["BankBranch"] = item.b.BankBranch.ToString();
                        datarow["BankAccountHolder"] = item.b.BankAccountHolder;
                        datarow["BankAccountHolderAdress"] = item.b.BankAccountHolderAdress.ToString();
                        datarow["BankAccountHolderPhone"] = item.b.BankAccountHolderPhone.ToString();
                        datarow["BankBalance"] = item.b.BankBranch.ToString();
                        datarow["Currency"] = item.b.Currency.ToString();

                        datarow["ProcessType"] = item.bp.ProcessType.ToString();
                        datarow["ProcessDate"] = item.bp.ProcessDate.ToString();
                        datarow["CurrentName"] = item.bp.CurrentName.ToString();
                        datarow["Descript"] = item.bp.Descript.ToString();
                        datarow["NetCredit"] = item.bp.NetCredit.ToString();
                        datarow["NetDebt"] = item.bp.NetDebt.ToString();
                        datarow["Expense"] = item.bp.Expense.ToString();


                        datatable.Rows.Add(datarow);
                    }
                }

                return datatable;
            }
        }

        public override int TableRowCount()
        {
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                return db.Banks.Count();
            }
        }

        public override void Delete(int _Id)
        {

            if (newBankProcess.ProcessType != "Gelen Havale" && newBankProcess.ProcessType != "Gönderilen Havale") // havale silinemez
            {
                using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
                {
                    db.Banks.Remove(db.Banks.Find(_Id));
                    
                    var is_bank = from b in db.Banks where  b.BankAccountNo == _Id  select b;
                    //bank proccess  sil ilgili tüm cari ile ilgili

                    if (is_bank.Count() != 0)
                    {

                        db.Banks.RemoveRange(is_bank);
                        if (db.SaveChanges() > 0) MessageBox.Show("Bank Silindi :)"); else MessageBox.Show("Silinemedi :(");

                    }

                    var is_accountmovement = from am in db.AccountMovements where am.SequenceNo == _Id && am.ProcessType==newBankProcess.ProcessType  select am;
                    //cari hareket sil ilgili bankayla ilgili

                    if (is_accountmovement.Count() != 0)
                    {

                        db.AccountMovements.RemoveRange(is_accountmovement);
                        if (db.SaveChanges() > 0) MessageBox.Show("Accountmovement Silindi :)"); else MessageBox.Show("Silinemedi :(");

                    }
                }
            }
        }
    }
}
