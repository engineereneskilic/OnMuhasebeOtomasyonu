using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _DataLayer;
using System.Data;

namespace _BusinessLayer
{
    public class CurrentCardsBusiness : db_operation
    {
        //Dolu Tablolar(Singletion Pattern)
        CurrentCards newCurrentcard = CurrentCards.Instance;
        CurrentCardDetails newCurrentcarddetails = CurrentCardDetails.Instance;


        public override void Insert_Update()
        {
            bool yenimi = false;


            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                var query = (from c in db.CurrentCards join cc in db.CurrentCardDetails on c.CurrentCode equals cc.CurrentCode where c.CurrentCode == newCurrentcard.CurrentCode select cc);

                if (query.Count() == 0)
                {
                    yenimi = true;
                    db.CurrentCards.Add(newCurrentcard);
                    db.SaveChanges();
                   
                       
                }
                else
                { // eğer kayıt varsa tablolarda yani yeni bir veri değilse o halde var olan veriler güncellensin
                    yenimi = false;
                    CurrentCards OldCurrentCards = db.CurrentCards.FirstOrDefault(eski => eski.CurrentCode == newCurrentcard.CurrentCode);
                    CurrentCardDetails OldCurrentCardsDetails = db.CurrentCardDetails.FirstOrDefault(eski => eski.CurrentCode == newCurrentcarddetails.CurrentCode);
                    OldCurrentCards.CurrentCode = newCurrentcard.CurrentCode;
                    OldCurrentCards.CurrentName = newCurrentcard.CurrentName;
                    OldCurrentCards.CurrentType = newCurrentcard.CurrentType;

                    OldCurrentCardsDetails.CurrentCode = newCurrentcarddetails.CurrentCode;
                    OldCurrentCardsDetails.FirstInformation = newCurrentcarddetails.FirstInformation;
                    OldCurrentCardsDetails.SecondPhone = newCurrentcarddetails.SecondPhone;
                    OldCurrentCardsDetails.FaxNo = newCurrentcarddetails.FaxNo;
                    OldCurrentCardsDetails.GsmNo = newCurrentcarddetails.GsmNo;
                    OldCurrentCardsDetails.Address = newCurrentcarddetails.Address;
                    OldCurrentCardsDetails.Email = newCurrentcarddetails.Email;
                    OldCurrentCardsDetails.Province = newCurrentcarddetails.Province;
                    OldCurrentCardsDetails.District = newCurrentcarddetails.District;
                    OldCurrentCardsDetails.Notes = newCurrentcarddetails.Notes;

                    db.SaveChanges();

                }
            }
                    // farklı tablolarda aynı anda veri eklenmiyor tek bir db oturumunda yeni bir db oturumu açmam gerekti
                using (PreliminaryAccountingEntities dbs = new PreliminaryAccountingEntities())
                {
                        if (yenimi)
                        {
                            dbs.CurrentCardDetails.Add(newCurrentcarddetails);
                            dbs.SaveChanges();
                        }
                }
            }

        public override void List(DataGridView coming_datagridview)
        {

            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                // Burda il ve ilçe bilgilerini de cari listemde görmek istiyorum.

                var currentcardswithdetails = from c in db.CurrentCards join cd in db.CurrentCardDetails on c.CurrentCode equals cd.CurrentCode select new { c, cd };

                foreach (var item in currentcardswithdetails)
                {
                    
                    coming_datagridview.Rows.Add(item.c.CurrentType,item.c.CurrentCode,item.c.CurrentName,item.c.BalanceDebt,item.c.BalanceCredit,item.c.Currency,item.cd.Province,item.cd.District);
                    
                }

            }
            
        }



        public override DataTable Query(int incoming_id)
        {
            DataTable dataTable = new DataTable();

            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {

                var details = from c in db.CurrentCards
                              join am in db.AccountMovements on c.CurrentCode equals am.CurrentCode
                              where c.CurrentCode == incoming_id
                              select new { c, am };

                var query = from c in db.CurrentCards join cc in db.CurrentCardDetails on c.CurrentCode equals cc.CurrentCode where c.CurrentCode == incoming_id select new { c, cc };

                // datatable system değişken tipleri ms sql'e göre biraz daha kısıtlı bu yüzden bazen datatable çalışmıyor. O yüzden hep string yapmaya çalıştım diğer
                // Businesss'larda bu şekil. datatable'da verileri string ağırlıklı saklamak daha güvenli. Yinede usule uygun olsun diye dönüştürmeye çalıştım

                dataTable.Columns.Add("CurrentCode", typeof(System.Int32));
                dataTable.Columns.Add("CurrentType", typeof(System.String));
                dataTable.Columns.Add("CurrentName", typeof(System.String));
                dataTable.Columns.Add("FirstInformation", typeof(System.String));
                dataTable.Columns.Add("SecondInformation", typeof(System.String));
                dataTable.Columns.Add("FirstPhone", typeof(System.Int64));
                dataTable.Columns.Add("SecondPhone", typeof(System.Int64));
                dataTable.Columns.Add("FaxNo", typeof(System.Int64));
                dataTable.Columns.Add("GsmNo", typeof(System.Int64));
                dataTable.Columns.Add("Address", typeof(System.String));
                dataTable.Columns.Add("Email", typeof(System.String));
                dataTable.Columns.Add("Province", typeof(System.String));
                dataTable.Columns.Add("District", typeof(System.String));
                dataTable.Columns.Add("Notes", typeof(System.String));

                DataRow datarow;

                if (details.Count() == 0) // detaya sahip deilse ilgili stock normal kendi verilerini alsın
                {
                    foreach (var item in query)
                    {

                        // Set the column header names.
                        datarow = dataTable.NewRow();
                        datarow["CurrentCode"] = item.c.CurrentCode.ToString();
                        datarow["CurrentType"] = item.c.CurrentType.ToString();
                        datarow["CurrentCode"] = item.c.CurrentCode;
                        datarow["CurrentType"] = item.c.CurrentType;
                        datarow["CurrentName"] = item.c.CurrentName;
                        datarow["FirstInformation"] = item.cc.FirstInformation;
                        datarow["SecondInformation"] = item.cc.SecondInformation;
                        datarow["FirstPhone"] = item.cc.FirstPhone;
                        datarow["SecondPhone"] = item.cc.SecondPhone;
                        datarow["FaxNo"] = item.cc.FaxNo;
                        datarow["GsmNo"] = item.cc.GsmNo;
                        datarow["Address"] = item.cc.Address;
                        datarow["Email"] = item.cc.Email;
                        datarow["Province"] = item.cc.Province;
                        datarow["District"] = item.cc.District;
                        datarow["Notes"] = item.cc.Notes;

                        dataTable.Rows.Add(datarow);
                       
                    }

                }
                else
                {
                    dataTable.Rows.Clear();
                    dataTable.Columns.Add("MovementDate", typeof(System.String));
                    dataTable.Columns.Add("SequenceNo", typeof(System.Int32));
                    dataTable.Columns.Add("ProcessType", typeof(System.String));
                    dataTable.Columns.Add("Descript", typeof(System.String));
                    dataTable.Columns.Add("Debt",typeof(System.String));
                    dataTable.Columns.Add("Credit",typeof(System.String));
                    dataTable.Columns.Add("Currency", typeof(System.String));
                    //dataTable.Columns.Add("CurrentCode",typeof(System.Int32));

                    foreach (var item in details)
                    {
                        datarow = dataTable.NewRow();
                        datarow["MovementDate"] = item.am.MovementDate.ToString();
                        datarow["SequenceNo"] = item.am.SequenceNo;
                        datarow["ProcessType"] = item.am.ProcessType;
                        datarow["Descript"] = item.am.Descript;
                        datarow["Debt"] = item.am.Debt.ToString();
                        datarow["Credit"] = item.am.Credit.ToString();
                        datarow["Currency"] = item.am.Currency.ToString();
                        datarow["CurrentCode"] = item.am.CurrentCode;

                        
                        dataTable.Rows.Add(datarow);
                    }
                }
                return dataTable;
            }

           
        }
        public override void Delete(int _Id)
        {
            try
            {
                using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
                {
                    // Dışarıdan aldığımız id yi veritabanındaki aynı id deki kayıt ile eşleştiriyoruz.

                    db.CurrentCards.Remove(db.CurrentCards.Find(_Id));
                    db.CurrentCardDetails.Remove(db.CurrentCardDetails.Find(_Id));

                    var is_accountmovement = from am in db.AccountMovements where am.CurrentCode == _Id select am;
                    //cariye bağlı tüm hareketleri sil cari silinrse arkasından çöp bırakmasın

                    if (is_accountmovement.Count() != 0)
                    {

                        db.AccountMovements.RemoveRange(is_accountmovement);
                        db.SaveChanges();

                    }

                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override int TableRowCount()
        {
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                return db.CurrentCards.Count();
            } 
        }
    }
}
