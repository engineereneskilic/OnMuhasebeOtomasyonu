using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _DataLayer;

namespace _BusinessLayer
{
    public class StockBusiness : db_operation
    {
        //Dolu Tablolar(Singletion Pattern)
        Stock newStock= Stock.Instance;


        public override void Insert_Update()
        {
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                var query = (from s in db.Stock where s.StockCode == newStock.StockCode select s);

                if (query.Count()==0)// boşsa sorgu
                {
                    db.Stock.Add(newStock);
                    db.SaveChanges();
                }
                else
                { // eğer kayıt varsa tablolarda yani yeni bir veri değilse o halde var olan veriler güncellensin

                    Stock OldStock = db.Stock.FirstOrDefault(eski => eski.StockCode == newStock.StockCode);
                    OldStock.StockCode = newStock.StockCode;
                    OldStock.StockBarcode = newStock.StockBarcode;
                    OldStock.StockName = newStock.StockName;
                    OldStock.StockComment = newStock.StockComment;
                    OldStock.StockType = newStock.StockType;
                    OldStock.StockKDV = newStock.StockKDV;
                    OldStock.StockMainUnitType = newStock.StockMainUnitType;
                    OldStock.StockSecondUnitType = newStock.StockSecondUnitType;
                    OldStock.StockThirdUnitType = newStock.StockThirdUnitType;
                    OldStock.StockSecondUnit = newStock.StockSecondUnit;
                    OldStock.StockThirdUnit = newStock.StockThirdUnit;
                    OldStock.StockKDVSalesStatus = newStock.StockKDVSalesStatus;
                    OldStock.StockKDVBuyingStatus = newStock.StockKDVSalesStatus;
                    OldStock.StockMainUnitSalesPrice = newStock.StockMainUnitSalesPrice;
                    OldStock.StockSecondUnitSalesPrice = newStock.StockSecondUnitSalesPrice;
                    OldStock.StockThirdUnitSalesPrice = newStock.StockThirdUnitSalesPrice;
                    OldStock.StockMainUnitBuyingPrice = newStock.StockMainUnitBuyingPrice;
                    OldStock.StockSecondUnitBuyingPrice = newStock.StockSecondUnitBuyingPrice;
                    OldStock.StockThirdUnitBuyingPrice = newStock.StockThirdUnitBuyingPrice;


                    db.SaveChanges();
                }
            }
        }

        public override void List(DataGridView coming_datagridview)
        {
            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
                foreach (var item in db.Stock)
                {
                    
                    coming_datagridview.Rows.Add(item.StockType,item.StockCode,item.StockName,item.StockMainUnit,item.StockMainUnitType, cammonClass.ToStringTL(Convert.ToDouble(item.StockMainUnitSalesPrice)), cammonClass.ToStringTL(Convert.ToDouble(item.StockSecondUnitSalesPrice)), cammonClass.ToStringTL(Convert.ToDouble((item.StockMainUnit * item.StockMainUnitSalesPrice))));
                }
            }
        }

        public override DataTable Query(int incoming_id)
        {
           
            DataTable datatable = new DataTable();

            using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
            {
               
                var details = from s in db.Stock
                              join sm in db.StockMovements on s.StockCode equals sm.StockCode
                              where s.StockCode == incoming_id
                              select new { s, sm };

                var query = from s in db.Stock where s.StockCode==incoming_id select s;

                

                datatable.Columns.Add("StockCode", typeof(System.String));
                datatable.Columns.Add("StockBarcode", typeof(System.String));
                datatable.Columns.Add("StockName", typeof(System.String));
                datatable.Columns.Add("StockComment", typeof(System.String));
                datatable.Columns.Add("StockType", typeof(System.String));
                datatable.Columns.Add("StockKDV", typeof(System.String));
                datatable.Columns.Add("StockMainUnitType", typeof(System.String));
                datatable.Columns.Add("StockSecondUnitType", typeof(System.String));
                datatable.Columns.Add("StockThirdUnitType", typeof(System.String));
                datatable.Columns.Add("StockSecondUnit", typeof(System.String));
                datatable.Columns.Add("StockThirdUnit", typeof(System.String));
                datatable.Columns.Add("StockKDVSalesStatus", typeof(System.String));
                datatable.Columns.Add("StockKDVBuyingStatus", typeof(System.String));
                datatable.Columns.Add("StockMainUnitSalesPrice", typeof(System.String));
                datatable.Columns.Add("StockSecondUnitSalesPrice", typeof(System.String));
                datatable.Columns.Add("StockThirdUnitSalesPrice", typeof(System.String));
                datatable.Columns.Add("StockMainUnitBuyingPrice", typeof(System.String));
                datatable.Columns.Add("StockSecondUnitBuyingPrice", typeof(System.String));
                datatable.Columns.Add("StockThirdUnitBuyingPrice", typeof(System.String));

                DataRow datarow;
                if (details.Count()==0) // detaya sahip deilse ilgili stock normal kendi verilerini alsın
                {
                    foreach (var item in query)
                    {

                        
                        datarow = datatable.NewRow();

                        datarow["StockCode"] = item.StockCode.ToString();
                        datarow["StockBarcode"] = item.StockBarcode.ToString();
                        datarow["StockName"] = item.StockName;
                        datarow["StockComment"] = item.StockComment;
                        datarow["StockType"] = item.StockType;
                        datarow["StockKDV"] = item.StockKDV.ToString();
                        datarow["StockMainUnitType"] = item.StockMainUnitType;
                        datarow["StockSecondUnitType"] = item.StockSecondUnitType;
                        datarow["StockThirdUnitType"] = item.StockThirdUnitType;
                        datarow["StockSecondUnit"] = item.StockSecondUnit.ToString();
                        datarow["StockThirdUnit"] = item.StockThirdUnit.ToString();
                        datarow["StockKDVSalesStatus"] = item.StockKDVSalesStatus;
                        datarow["StockKDVBuyingStatus"] = item.StockKDVBuyingStatus;
                        datarow["StockMainUnitSalesPrice"] = item.StockMainUnitSalesPrice.ToString();
                        datarow["StockSecondUnitSalesPrice"] = item.StockSecondUnitSalesPrice.ToString();
                        datarow["StockThirdUnitSalesPrice"] = item.StockThirdUnitSalesPrice.ToString();
                        datarow["StockMainUnitBuyingPrice"] = item.StockMainUnitBuyingPrice.ToString();
                        datarow["StockSecondUnitBuyingPrice"] = item.StockSecondUnitBuyingPrice.ToString();
                        datarow["StockThirdUnitBuyingPrice"] = item.StockThirdUnitBuyingPrice.ToString();

                        datatable.Rows.Add(datarow);
                    }
                }
                else
                {
                    
                
                        datatable.Columns.Add("ProcessDate", typeof(System.String));
                        datatable.Columns.Add("ProcessType", typeof(System.String));
                        datatable.Columns.Add("CurrentCode", typeof(System.String));
                        datatable.Columns.Add("CurrentName", typeof(System.String));
                        //datatable.Columns.Add("StockCode", typeof(System.Int32));
                        datatable.Columns.Add("IncomingAmount", typeof(System.String));
                        datatable.Columns.Add("Yield",typeof(System.String));
                        datatable.Columns.Add("UnitPrice", typeof(System.String));
                        datatable.Columns.Add("TotalAmount", typeof(System.String));
                        datatable.Columns.Add("Discount", typeof(System.String));
                        datatable.Columns.Add("BillCode", typeof(System.String));
                    foreach (var item in details)
                    {
                        

                        datarow = datatable.NewRow();

                        datarow["StockCode"] = item.s.StockCode;
                        datarow["StockBarcode"] = item.s.StockBarcode.ToString();
                        datarow["StockName"] = item.s.StockName;
                        datarow["StockComment"] = item.s.StockComment;
                        datarow["StockType"] = item.s.StockType;
                        datarow["StockKDV"] = item.s.StockKDV.ToString();
                        datarow["StockMainUnitType"] = item.s.StockMainUnitType;
                        datarow["StockSecondUnitType"] = item.s.StockSecondUnitType;
                        datarow["StockThirdUnitType"] = item.s.StockThirdUnitType;
                        datarow["StockSecondUnit"] = item.s.StockSecondUnit.ToString();
                        datarow["StockThirdUnit"] = item.s.StockThirdUnit.ToString();
                        datarow["StockKDVSalesStatus"] = item.s.StockKDVSalesStatus;
                        datarow["StockKDVBuyingStatus"] = item.s.StockKDVBuyingStatus;
                        datarow["StockMainUnitSalesPrice"] = item.s.StockMainUnitSalesPrice.ToString();
                        datarow["StockSecondUnitSalesPrice"] = item.s.StockSecondUnitSalesPrice.ToString();
                        datarow["StockThirdUnitSalesPrice"] = item.s.StockThirdUnitSalesPrice.ToString();
                        datarow["StockMainUnitBuyingPrice"] = item.s.StockMainUnitBuyingPrice.ToString();
                        datarow["StockSecondUnitBuyingPrice"] = item.s.StockSecondUnitBuyingPrice.ToString();
                        datarow["StockThirdUnitBuyingPrice"] = item.s.StockThirdUnitBuyingPrice.ToString();
                        //
                        datarow["ProcessDate"] = item.sm.ProcessDate.ToString();
                        datarow["ProcessType"] = item.sm.ProcessType.ToString();
                        datarow["CurrentCode"] = item.sm.CurrentCode.ToString();
                        datarow["CurrentName"] = item.sm.CurrentName;
                        //datarow["StockCode"] = item.sm.StockCode;
                        datarow["IncomingAmount"] = item.sm.IncomingAmount.ToString();
                        if (item.sm.Yield != null) datarow["Yield"] = item.sm.Yield.ToString();
                        datarow["UnitPrice"] = item.sm.IncomingAmount.ToString();
                        datarow["TotalAmount"] = item.sm.IncomingAmount.ToString();
                        datarow["Discount"] = item.sm.Discount.ToString();
                        datarow["BillCode"] = item.sm.BillCode.ToString();

                      
                        datatable.Rows.Add(datarow);

                    }
                }
                
                return datatable;



            }
        }

        public override void Delete(int _Id)
        {
            try
            {
                using (PreliminaryAccountingEntities db = new PreliminaryAccountingEntities())
                {
                    // Dışarıdan aldığımız id yi veritabanındaki aynı id deki kayıt ile eşleştiriyoruz.

                    db.Stock.Remove(db.Stock.Find(_Id));

                    var varmi= db.StockMovements.Find(_Id);
                    if (varmi != null)
                    {
                        db.StockMovements.Remove(varmi);
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
                return db.Stock.Count();
            }
        }
    }
}
