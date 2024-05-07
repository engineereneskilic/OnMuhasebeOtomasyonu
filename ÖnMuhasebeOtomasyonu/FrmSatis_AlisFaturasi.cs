using _BusinessLayer;
using _DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖnMuhasebeOtomasyonu
{
    public partial class FrmSatis_AlisFaturasi : Form
    {
        private string faturaTipi;
        private bool yenimi;
        private int faturaNo;

        public FrmSatis_AlisFaturasi(string FaturaTipi,bool Yenimi,int FaturaNo)
        {
            InitializeComponent();
            this.faturaTipi = FaturaTipi;
            this.yenimi = Yenimi;
            this.faturaNo = FaturaNo;
        }


        static Creater creater = new Creater();
        db_operation Bill_operation = creater.FactoryMethod(database_PreliminaryAccounting.Bills);
        db_operation Stock_operation = creater.FactoryMethod(database_PreliminaryAccounting.Stocks);
        DateTime tarih = DateTime.Today;
        DateTime Zaman = DateTime.Now;

       
        DataGridViewComboBoxColumn StokBirimi_Combobox;

        static int RowCount;

        public string ProcessType;
        double[] eskiStokFiyatlar = new double[RowCount];

        private void FrmSatis_AlisFaturasi_Load(object sender, EventArgs e)
        {

            this.Text = faturaTipi + " Faturası";
            
            // column heading disable click
           
            foreach (DataGridViewColumn column in faturaDetaylari_dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
           

            BillCode_textBox.Text = (Bill_operation.TableRowCount() + 1).ToString();
            
          

            StokBirimi_Combobox = new DataGridViewComboBoxColumn();
            StokBirimi_Combobox.Name = "StockType_name";
            StokBirimi_Combobox.HeaderText = "StokBirimi";
            faturaDetaylari_dataGridView.Columns.Add(StokBirimi_Combobox);
            int count = faturaDetaylari_dataGridView.Columns.Count - 1;
            faturaDetaylari_dataGridView.Columns[count].DisplayIndex = 5;

            //ProcessType_Combobox.Text = "Stok";

            //RowCount = faturaDetaylari_dataGridView.Rows.Count;

            FormDoldur();
            //TureGöreAktifSatir(ProcessType);



            /*
            int eskiStokRow = -1;
            foreach (DataGridViewRow row in faturaDetaylari_dataGridView.Rows)
            {
                
                eskiStokRow++;
                double eski_StokBirimFiyatı = Convert.ToDouble(row.Cells["StokBirimFiyatı_Column"].Value.ToString());

                eskiStokFiyatlar[eskiStokRow] = eski_StokBirimFiyatı;
                
            }
            */

        }

        private void FormDoldur()
        {
            if (!yenimi)
            {

               
                int BillCode = Convert.ToInt32(faturaNo);
                DataRow Billrow = Bill_operation.Query(BillCode).Rows[0];
                
               
                BillCode_textBox.Text = BillCode.ToString();
                CurrentCode_textBox.Text= Billrow["CurrrentCode"].ToString();
                CurrentName_textBox.Text = Billrow["CurrentName"].ToString();
                KdvType_comboBox.Text = Billrow["KdvType"].ToString();
                description_richTextBox.Text = Billrow["Description"].ToString();
               
               
                ProcessDate_textBox.Text =  Billrow["ProcessDate"].ToString().Substring(0,10);

                ProcessTime_textBox.Text = Billrow["ProcessTime"].ToString().Substring(0,5);

                int amount;


                foreach (DataRow row in Bill_operation.Query(BillCode).Rows)
                {
                    if (faturaTipi == "Alış") { amount = Convert.ToInt32(row["IncomingAmount"].ToString()); } else { amount = Convert.ToInt32(row["Yield"].ToString()); }// fatura alış faturası ise stoğa girecek olan değer eğer deilse satış faturasıdır stoktan çıkıcak değerler gelsin
                    //StokBirimi_Combobox.Items.Add(row["UnitType"].ToString());
                    // hocam ne yapsamda sokbirimi_combobox.text olmadığı için değer atayamıyorum.

                    //switch(row["UnitType"].ToString())
                   DataRow stokrow =Stock_operation.Query(Convert.ToInt32(row["StockCode"].ToString())).Rows[0];

                    string StockMainUnitType = Convert.ToString(stokrow["StockMainUnitType"].ToString());
                    string StockSecondUnitType = stokrow["StockSecondUnitType"].ToString();
                    string StockThirdUnitType = stokrow["StockThirdUnitType"].ToString();
                    
                    /*
                    DataGridViewCell newCell = newRow.Cells[cell.ColumnIndex]; stok_birimi.Value = "afsd";

                    if (row["UnitYpe"].ToString() == StockMainUnitType)
                    {
                        stok_birimi.Value = StockMainUnitType;
                    }else
                    if(row["UnitYpe"].ToString() == StockSecondUnitType)
                    {

                    }
                    */

                    // Comboboxun value değerine atama bir türlü yapamadım. item olarak ekliyor fakat value olarak gelmiyor.
                    StokBirimi_Combobox.Items.Clear();
                    StokBirimi_Combobox.Items.AddRange(stokrow["StockMainUnitType"].ToString(), stokrow["StockSecondUnitType"].ToString(), stokrow["StockThirdUnitType"].ToString());

                    faturaDetaylari_dataGridView.Rows.Add(row["LineType"].ToString(), row["StockBarcode"].ToString(), row["StockCode"].ToString(), row["Discript"].ToString(), amount,  cammonClass.ToStringTL(Convert.ToDouble(row["UnitPrice"].ToString())), row["DiscountPercent"].ToString(),  cammonClass.ToStringTL(Convert.ToDouble(row["LineTotalAmount"].ToString())), row["KdvPercent"].ToString());

                }
                SatirToplamTutarHesapla();
                KdvToplamTutarHesapla();
                GenelToplamTutarHesapla();
                NetGenelToplamHesapla();

            }
            else
            {
                ProcessDate_textBox.Text = tarih.Date.ToShortDateString();
                ProcessTime_textBox.Text = Zaman.ToShortTimeString();
            }
        
        }

        private void CurrentOpens_button_Click(object sender, EventArgs e)
        {
            FrmCariAcilir formAcilir = new FrmCariAcilir(CurrentCode_textBox, CurrentName_textBox);
            formAcilir.Show();
        }

       


        private void faturaDetaylari_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedColumIndex = faturaDetaylari_dataGridView.SelectedCells[0].ColumnIndex;
            int selectedRowIndex = faturaDetaylari_dataGridView.SelectedCells[0].RowIndex;

            if (selectedColumIndex >= 1  && selectedColumIndex <= 3)
            {

                FrmStokAcilir FrmStokAcilir = new FrmStokAcilir(faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[1], faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[2], faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[3],StokBirimi_Combobox, faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[8], faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[5]);
                FrmStokAcilir.Show();
                //static
                faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells["Stokmiktar_Column"].Value = 1;


                //StokBirimi_Combobox.Items.Clear();
                //faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells["StockType_name"] as DataGridViewComboBoxCell
            }
            
        }




        // ProcessType Combobox
        private void faturaDetaylari_dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox stockComboBox = e.Control as ComboBox;

            e.Control.KeyPress +=
       new KeyPressEventHandler(Control_KeyPress);

            if (stockComboBox != null)
            {

                    // Bu kısımda datagridiviewin varolan selectedIndexChanged eventini silip yerine normal combobox seçilme eventi ekliyoruz
                    stockComboBox.SelectedIndexChanged -= new EventHandler(stockComboBox_SelectedIndexChanged);
                    stockComboBox.SelectedIndexChanged += stockComboBox_SelectedIndexChanged;

                    
            }
      
            
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(faturaDetaylari_dataGridView.CurrentCell.ColumnIndex==5 || faturaDetaylari_dataGridView.CurrentCell.ColumnIndex == 7) // birim fiyat ve toplam fiyat
            {
                SatirToplamTutarHesapla();
                GenelToplamTutarHesapla();
                NetGenelToplamHesapla();
            }
          
        }

        double Price = 0;
        private void stockComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //static
            faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["SatırTuru_Column"].Value = "Stok";

             ComboBox Stock_Combobox = (sender as ComboBox);
            Stock_Combobox.Name = "Stock_Combobox_Name";

            db_operation stock_operation = creater.FactoryMethod(database_PreliminaryAccounting.Stocks);

            DataRow row = stock_operation.Query(Convert.ToInt32(faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells[2].Value)).Rows[0];


            if (faturaTipi == "Alış")
            {
                switch (Stock_Combobox.SelectedIndex)
                {
                    case 0:
                        Price = Convert.ToDouble(row["StockMainUnitBuyingPrice"].ToString());
                        break;
                    case 1:
                        Price = Convert.ToDouble(row["StockSecondUnitBuyingPrice"].ToString());
                        break;
                    case 2:
                        Price = Convert.ToDouble(row["StockThirdUnitBuyingPrice"].ToString());
                        break;
                }
            }
            else
            {
                switch (Stock_Combobox.SelectedIndex)
                {
                    case 0:
                        Price = Convert.ToDouble(row["StockMainUnitSalesPrice"].ToString());
                        break;
                    case 1:
                        Price = Convert.ToDouble(row["StockSecondUnitSalesPrice"].ToString());
                        break;
                    case 2:
                        Price = Convert.ToDouble(row["StockThirdUnitSalesPrice"].ToString());
                        break;
                }
            }
           // MessageBox.Show(Price.ToString());

                faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["StokBirimFiyatı_Column"].Value = 1 * Price;// adet fiyatı
                faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["StokBirimFiyatı_Column"].Value = cammonClass.ToStringTL(Convert.ToDouble(faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["StokBirimFiyatı_Column"].Value));

            /*
            faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["ToplamTutar_column"].Value = Convert.ToDouble(faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["Stokmiktar_Column"].Value) * buyingPrice;// miktar fiyatı
            faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["ToplamTutar_column"].Value = cammonClass.ToStringTL(Convert.ToDouble(faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["ToplamTutar_column"].Value));
            */
            SatirToplamTutarHesapla();
            KdvToplamTutarHesapla();
            GenelToplamTutarHesapla();
            NetGenelToplamHesapla();
            
        }

        // validating çalışmıyor
        private void faturaDetaylari_dataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.ColumnIndex == 6) // indirim
            {
                IndirimToplamHesapla();
                NetGenelToplamHesapla();
            }

                if (e.ColumnIndex == 5 || e.ColumnIndex==7 || e.ColumnIndex==6)
            {
               
                faturaDetaylari_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cammonClass.ToStringTL(Convert.ToDouble(faturaDetaylari_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));// ayrıcan celldeki para tutarlarını düzelt 
            }
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 7) // miktar cellleave
            {
               
                SatirToplamTutarHesapla();
                GenelToplamTutarHesapla();
                NetGenelToplamHesapla();
            }
        }

        private void faturaDetaylari_dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
            if (e.ColumnIndex == 6)
            {
                IndirimToplamHesapla();
                NetGenelToplamHesapla();
                
            }

            if (e.ColumnIndex == 5 || e.ColumnIndex == 7)
            {
                
                faturaDetaylari_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cammonClass.ToStringTL(Convert.ToDouble(faturaDetaylari_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));// ayrıcan celldeki para tutarlarını düzelt 
            }
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 7) // miktar cellleave
            {
             
                SatirToplamTutarHesapla();
                GenelToplamTutarHesapla();
                NetGenelToplamHesapla();
            }
        }

        private void faturaDetaylari_dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          

            if (e.ColumnIndex == 6)
            {
                IndirimToplamHesapla();
                NetGenelToplamHesapla();
            }

            if (e.ColumnIndex == 5 || e.ColumnIndex == 7)
            {
               
                faturaDetaylari_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cammonClass.ToStringTL(Convert.ToDouble(faturaDetaylari_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));// ayrıcan celldeki para tutarlarını düzelt 
            }
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 7) // miktar cellleave
            {
               
                SatirToplamTutarHesapla();
                GenelToplamTutarHesapla();
                NetGenelToplamHesapla();
            }

        }

        private void faturaDetaylari_dataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (faturaDetaylari_dataGridView.CurrentCell.ColumnIndex == 6)
            {
                IndirimToplamHesapla();
            }
            if (faturaDetaylari_dataGridView.CurrentCell.ColumnIndex == 5 || faturaDetaylari_dataGridView.CurrentCell.ColumnIndex == 7)
            {
                // birim fiyat ve toplam tutar hücreleri ayrıldıklarında para birimine dönüşsün hemen
                faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells[faturaDetaylari_dataGridView.CurrentCell.ColumnIndex].Value = cammonClass.ToStringTL(Convert.ToDouble(faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells[faturaDetaylari_dataGridView.CurrentCell.ColumnIndex].Value));// ayrıcan celldeki para tutarlarını düzelt 
            }
            {
                
            }
            if (faturaDetaylari_dataGridView.CurrentCell.ColumnIndex == 4 || faturaDetaylari_dataGridView.CurrentCell.ColumnIndex == 5 || faturaDetaylari_dataGridView.CurrentCell.ColumnIndex == 7) 
            {
                SatirToplamTutarHesapla();
                GenelToplamTutarHesapla();
            }
        }

        private void SatirToplamTutarHesapla()
        {
            
            faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["ToplamTutar_column"].Value = Convert.ToDouble(faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["Stokmiktar_Column"].Value) * Convert.ToDouble(faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["StokBirimFiyatı_Column"].Value);// miktar fiyatı  
            faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["ToplamTutar_column"].Value = cammonClass.ToStringTL(Convert.ToDouble(faturaDetaylari_dataGridView.Rows[faturaDetaylari_dataGridView.SelectedCells[0].RowIndex].Cells["ToplamTutar_column"].Value));

        }

        private void KdvType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {     
          
                KdvToplamTutarHesapla();
        }

        private void GenelToplamTutarHesapla()
        {
            double Top_ToplamTutar = 0;
            foreach (DataGridViewRow row in faturaDetaylari_dataGridView.Rows)
            {
                Top_ToplamTutar += Convert.ToDouble(row.Cells["ToplamTutar_column"].Value);
            }
            toplamTutar_label.Text = Top_ToplamTutar.ToString();
            toplamTutar_label.Text = cammonClass.ToStringTL(Convert.ToDouble(Top_ToplamTutar.ToString()));
            //Toplam fiyat hesaplandıysa artık Kdv genel toplamda hesaplanabilir
            KdvGenelToplamHesapla();
        }
      

        private void KdvGenelToplamHesapla()
        {
            double Top_Kdv = 0;
            foreach (DataGridViewRow row in faturaDetaylari_dataGridView.Rows)
            {

                //Top_ToplamTutar += Convert.ToDouble(row.Cells["ToplamTutar_column"].Value);
                Top_Kdv += Convert.ToDouble(row.Cells["StokBirimFiyatı_Column"].Value) - (Convert.ToDouble(row.Cells["StokBirimFiyatı_Column"].Value) / (1 + (Convert.ToDouble(row.Cells["KdvYuzdesi_Column"].Value) / 100)));
            }
            Kdv_label.Text = cammonClass.ToStringTL(Top_Kdv);
        }

        private void NetGenelToplamHesapla()
        {
            TotalAmount_label.Text = "0";
            double Net_Tutar = 0;
            Net_Tutar += Convert.ToDouble(toplamTutar_label.Text);
            Net_Tutar -= Convert.ToDouble(Discount_label.Text);
            Net_Tutar += Convert.ToDouble(TotalAmount_label.Text);
            Net_Tutar += Convert.ToDouble(Kdv_label.Text);
            Net_Tutar += Convert.ToDouble(Expense_label.Text);

            TotalAmount_label.Text =  cammonClass.ToStringTL(Net_Tutar);
        }
        private void KdvToplamTutarHesapla()
        {
            RowCount = faturaDetaylari_dataGridView.Rows.Count;

            

            KdvGenelToplamHesapla();
           

            if (KdvType_comboBox.Text == "Hariç")
            {
                foreach (DataGridViewRow row in faturaDetaylari_dataGridView.Rows)
                {
                    // Satırlı kdvli hale getirelim
                    double Ucret = Convert.ToDouble(row.Cells["StokBirimFiyatı_Column"].Value) / (1 + (Convert.ToDouble(row.Cells["KdvYuzdesi_Column"].Value) / 100));
                    row.Cells["StokBirimFiyatı_Column"].Value = Ucret.ToString("0.##");

                    SatirToplamTutarHesapla();
                }
            }
            else if (KdvType_comboBox.Text == "Dahil")
            {
                int rowIndex = -1;
                foreach (DataGridViewRow row in faturaDetaylari_dataGridView.Rows)
                {
                    rowIndex++;
                    //row.Cells["StokBirimFiyatı_Column"].Value = eskiStokFiyatlar[rowIndex].ToString();

                }
                
            }
         }

        private void IndirimToplamHesapla()
        {
            double indirim=0;
            foreach (DataGridViewRow row in faturaDetaylari_dataGridView.Rows)
            {

                indirim += (Convert.ToDouble(row.Cells["ToplamTutar_column"].Value) / 100) * Convert.ToDouble(row.Cells["Indirim_Column"].Value);
            }
             Discount_label.Text = cammonClass.ToStringTL(indirim); 

        }

        private void Iptal_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Bills bill = Bills.Instance;
        BillDetail billDetails = BillDetail.Instance;
        private void Kaydet_button_Click(object sender, EventArgs e)
        {
          
            // kaydederken garanti olması açısından son bir refresh yapalım gerek yok ama
            SatirToplamTutarHesapla();
            KdvToplamTutarHesapla();
            GenelToplamTutarHesapla();
            NetGenelToplamHesapla();
            //
            bill.BillCode = Convert.ToInt32(BillCode_textBox.Text);
            billDetails.BillCode = Convert.ToInt32(BillCode_textBox.Text);
            bill.CurrrentCode = Convert.ToInt32(CurrentCode_textBox.Text);
            bill.CurrentName = CurrentName_textBox.Text;
            if (faturaTipi == "Alış") bill.NetCredit = Convert.ToDouble(TotalAmount_label.Text); else bill.NetDebt= Convert.ToDouble(TotalAmount_label.Text);
            bill.Currency = Currency_comboBox.Text;
            bill.KdvType = KdvType_comboBox.Text;
            bill.ProcessDate = Convert.ToDateTime(ProcessDate_textBox.Text);
            TimeSpan ts = TimeSpan.Parse(ProcessTime_textBox.Text);
            bill.ProcessTime = ts;
            if (faturaTipi == "Alış") bill.ProcessType = "Alış Faturası"; else bill.ProcessType = "Satış Faturası";
            bill.Description = description_richTextBox.Text;
            bill.Discount = Convert.ToDouble(Discount_label.Text);
            bill.Expense = Convert.ToDouble(Expense_label.Text);
            bill.Kdv = Convert.ToDouble(Kdv_label.Text);
            bill.Term =  cammonClass.MonthDateToString(Convert.ToDateTime(ProcessDate_textBox.Text).Month);

            foreach (DataGridViewRow row in faturaDetaylari_dataGridView.Rows)
            {
                if (row.Index < faturaDetaylari_dataGridView.Rows.Count-1) // son row kaydedilmemiş açık row foreach de oda dahil ediliyor.Bunu engellememiz lazım boş row kaydedilmememeli !
                {


                    //billDetails.BillCode = Convert.ToInt32(row.Cells["SatırTuru_Column"].ToString());
                    billDetails.LineType = "Stok";
                    billDetails.StockBarcode = Convert.ToInt64(row.Cells["StokBarkod_Column"].Value.ToString());
                    billDetails.StockCode = Convert.ToInt32(row.Cells["StockCode_Column"].Value.ToString());
                    billDetails.Discript = row.Cells["StokAciklama_Column"].Value.ToString();
                    if (faturaTipi == "Alış") billDetails.IncomingAmount = Convert.ToInt32(row.Cells["Stokmiktar_Column"].Value.ToString()); else billDetails.Yield = Convert.ToInt32(row.Cells["Stokmiktar_Column"].Value.ToString());

                    string SelectedText = Convert.ToString((row.Cells["StockType_name"] as DataGridViewComboBoxCell).FormattedValue.ToString());

                    billDetails.UnitType = SelectedText;
                    billDetails.UnitPrice = Convert.ToDouble(row.Cells["StokBirimFiyatı_Column"].Value.ToString());
                    billDetails.DiscountPercent = Convert.ToDouble(cammonClass.ZeroIfEmpty(Convert.ToString(row.Cells["Indirim_Column"].Value)));
                    billDetails.LineTotalAmount = Convert.ToDouble(row.Cells["ToplamTutar_column"].Value.ToString());
                    billDetails.KdvPercent = Convert.ToDouble(row.Cells["KdvYuzdesi_Column"].Value.ToString());
                    Bill_operation.Insert_Update();
                }
            }
            this.Close();
            
        }

        private void FrmSatis_AlisFaturasi_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "FrmFaturalar")
                {
                    FrmFaturalar frm_Fatura = (FrmFaturalar)Application.OpenForms[i];
                    frm_Fatura.Faturalar_dataGridView.Rows.Clear();
                    Bill_operation.List(frm_Fatura.Faturalar_dataGridView);
                    frm_Fatura.FaturaDetayıYenile();
                }
            }

        }

        private void faturaDetaylari_dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Hocam sebebsiz yere bu hata çıkıyodu internetten araştırıcan galiba bu açık gibi birşeymiş. Bu şekilde hatayı kapatıyoruz
            if(e.Exception.Message=="DataGridViewComboBoxCel value is not valid.")
            {
                object value = faturaDetaylari_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)faturaDetaylari_dataGridView.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)faturaDetaylari_dataGridView.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faturaDetaylari_dataGridView.Rows.RemoveAt(faturaDetaylari_dataGridView.CurrentCell.RowIndex);
        }



        /*
private void TureGöreAktifSatir(string incoming_ProcessType)
{
int selectedRowIndex = faturaDetaylari_dataGridView.SelectedCells[0].RowIndex;

if (incoming_ProcessType == "İskonto")
{



faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[1].ReadOnly = true; faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[1].Style.BackColor = cammonClass.DisabledColor();
faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[2].ReadOnly = true; faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[2].Style.BackColor = cammonClass.DisabledColor();
faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[3].ReadOnly = true; faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[3].Style.BackColor = cammonClass.DisabledColor();
faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[4].ReadOnly = true; faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[4].Style.BackColor = cammonClass.DisabledColor();
faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[5].ReadOnly = true; faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[5].Style.BackColor = cammonClass.DisabledColor();
faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[6].ReadOnly = true; faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[6].Style.BackColor = cammonClass.DisabledColor();
faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[8].ReadOnly = true; faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells[8].Style.BackColor = cammonClass.DisabledColor();
} else if (incoming_ProcessType == "Stok")
{
//faturaDetaylari_dataGridView.Rows[selectedRowIndex].ReadOnly = true; faturaDetaylari_dataGridView.Rows[selectedRowIndex].Cells
}

}
*/
    }
}
