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
    public partial class FrmStokKarti : Form
    {
        private DataGridView stoklar_dataGridView;
        private bool yenimi;

        public FrmStokKarti(DataGridView stoklar_dataGridView, bool yenimi)
        {
            InitializeComponent();
            this.stoklar_dataGridView = stoklar_dataGridView;
            this.yenimi = yenimi;
        }

       
     

        static Creater creater = new Creater();
        db_operation Stock_operation = creater.FactoryMethod(database_PreliminaryAccounting.Stocks);

        private void FrmStokKarti_Load(object sender, EventArgs e)
        {
            StockCode_textBox.Text= (Stock_operation.TableRowCount() + 1).ToString();

            KutularıDoldur();
        }
         private void KutularıDoldur()
        {
            if (!yenimi)
            {
                
                int StockCode = Convert.ToInt32(stoklar_dataGridView.SelectedRows[0].Cells["StokKodu_column"].Value);
                stoklar_dataGridView.Refresh();
               
                DataRow row = Stock_operation.Query(StockCode).Rows[0]; // Geçerli Current code göre tüm bilgileri alıyor.

                StockCode_textBox.Text = row["StockCode"].ToString();
                StockBarcode_textBox.Text = row["StockBarcode"].ToString();
                StockName_textBox.Text = row["StockName"].ToString();
                StockComment_textBox.Text = row["StockComment"].ToString();
                StockType_comboBox.Text = row["StockType"].ToString();
                StockKDV_textBox.Text = row["StockKDV"].ToString();
                StockMainUnitType_textBox.Text = row["StockMainUnitType"].ToString();
                StockSecondUnitType_textBox.Text = row["StockSecondUnitType"].ToString();
                StockThirdUnitType_textBox.Text = row["StockThirdUnitType"].ToString();
                StockSecondUnit_textBox.Text = row["StockSecondUnit"].ToString();
                StockThirdUnit_textBox.Text = row["StockThirdUnit"].ToString();
                StockKDVSalesStatus_comboBox.Text = row["StockKDVSalesStatus"].ToString();
                StockKDVBuyingStatus_comboBox.Text = row["StockKDVBuyingStatus"].ToString();
                StockMainUnitSalesPrice_textBox.Text =  cammonClass.ToStringTL(Convert.ToDouble(row["StockMainUnitSalesPrice"].ToString()));
                StockSecondUnitSalesPrice_textBox.Text =  cammonClass.ToStringTL(Convert.ToDouble(row["StockSecondUnitSalesPrice"].ToString()));
                StockThirdUnitSalesPrice_textBox.Text =  cammonClass.ToStringTL(Convert.ToDouble(row["StockThirdUnitSalesPrice"].ToString()));
                StockMainUnitBuyingPrice_textBox.Text =  cammonClass.ToStringTL(Convert.ToDouble(row["StockMainUnitBuyingPrice"].ToString()));
                StockSecondUnitBuyingPrice_textBox.Text = cammonClass.ToStringTL(Convert.ToDouble(row["StockSecondUnitBuyingPrice"].ToString()));
                StockThirdUnitBuyingPrice_textBox.Text =  cammonClass.ToStringTL(Convert.ToDouble(row["StockThirdUnitBuyingPrice"].ToString()));

            }
        }

        Stock stock = Stock.Instance;
        
        private void Kaydet_button_Click(object sender, EventArgs e)
        {
            stock.StockCode = Convert.ToInt32(StockCode_textBox.Text);
            stock.StockBarcode=Convert.ToUInt64(cammonClass.ZeroIfEmpty(StockBarcode_textBox.Text));
            stock.StockName=StockName_textBox.Text;
            stock.StockComment = StockComment_textBox.Text;
            stock.StockType = StockType_comboBox.Text;
            stock.StockKDV = Convert.ToInt32(cammonClass.ZeroIfEmpty(StockKDV_textBox.Text));
            stock.StockMainUnitType = StockMainUnitType_textBox.Text;
            stock.StockSecondUnitType = StockSecondUnitType_textBox.Text;
            stock.StockThirdUnitType = StockThirdUnitType_textBox.Text;
            stock.StockSecondUnit = Convert.ToInt32(cammonClass.ZeroIfEmpty(StockSecondUnit_textBox.Text));
            stock.StockThirdUnit = Convert.ToInt32(cammonClass.ZeroIfEmpty(StockThirdUnit_textBox.Text));
            stock.StockKDVSalesStatus = StockKDVSalesStatus_comboBox.Text;
            stock.StockKDVBuyingStatus = StockKDVBuyingStatus_comboBox.Text;
            stock.StockMainUnitSalesPrice = Convert.ToDouble(cammonClass.ZeroIfEmpty(StockMainUnitSalesPrice_textBox.Text));
            stock.StockSecondUnitSalesPrice = Convert.ToDouble(cammonClass.ZeroIfEmpty(StockSecondUnitSalesPrice_textBox.Text));
            stock.StockThirdUnitSalesPrice = Convert.ToDouble(cammonClass.ZeroIfEmpty(StockThirdUnitSalesPrice_textBox.Text));
            stock.StockMainUnitBuyingPrice = Convert.ToDouble(cammonClass.ZeroIfEmpty(StockMainUnitBuyingPrice_textBox.Text));
            stock.StockSecondUnitBuyingPrice = Convert.ToDouble(cammonClass.ZeroIfEmpty(StockSecondUnitBuyingPrice_textBox.Text));
            stock.StockThirdUnitBuyingPrice = Convert.ToDouble(cammonClass.ZeroIfEmpty(StockThirdUnitBuyingPrice_textBox.Text));
            Stock_operation.Insert_Update();
        }

        private void Iptal_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yeni_button_Click(object sender, EventArgs e)
        {
            FrmStokKarti frmstokkarti = new FrmStokKarti(stoklar_dataGridView,true);
            frmstokkarti.Show();
        }

        private void Onceki_button_Click(object sender, EventArgs e)
        {
            int rowIndex = stoklar_dataGridView.SelectedRows[0].Index;
            if (0 < rowIndex)
            {

                stoklar_dataGridView.Rows[rowIndex - 1].Selected = true;
                stoklar_dataGridView.Rows[rowIndex].Selected = false;
                KutularıDoldur();
            }
        }

        private void Sonraki_button_Click(object sender, EventArgs e)
        {
            int rowIndex = stoklar_dataGridView.SelectedRows[0].Index;

            if (stoklar_dataGridView.Rows.Count > rowIndex + 1)
            {

                stoklar_dataGridView.Rows[rowIndex + 1].Selected = true;
                stoklar_dataGridView.Rows[rowIndex].Selected = false;
                KutularıDoldur();
            }
        }

        private void Sil_button_Click(object sender, EventArgs e)
        {
            Stock_operation.Delete(Convert.ToInt32(StockCode_textBox.Text));
            stoklar_dataGridView.Rows.Clear();
            Stock_operation.List(stoklar_dataGridView);
            this.Close();
        }

        private void StockMainUnitType_textBox_TextChanged(object sender, EventArgs e)
        {
            
            SecondUnit_mainUnit_label.Text = cammonClass.ToTitleCase(StockMainUnitType_textBox.Text);
            ThirdUnit_mainUnit_label.Text= cammonClass.ToTitleCase(StockMainUnitType_textBox.Text);
            FiyatA_label.Text =  cammonClass.ToTitleCase(StockMainUnitType_textBox.Text)+" Fiyatı";
            FiyatG_label.Text= cammonClass.ToTitleCase(StockMainUnitType_textBox.Text)+" Fiyatı"; 
        }

        private void StockSecondUnitType_textBox_TextChanged(object sender, EventArgs e)
        {
            FiyatB_label.Text = cammonClass.ToTitleCase(StockSecondUnitType_textBox.Text)+" Fiyatı";
            FiyatH_label.Text = cammonClass.ToTitleCase(StockSecondUnitType_textBox.Text)+" Fiyatı";
        }

        private void StockThirdUnitType_textBox_TextChanged(object sender, EventArgs e)
        {
            FiyatC_label.Text = cammonClass.ToTitleCase(StockThirdUnitType_textBox.Text) + " Fiyatı";
            fiyatI_label.Text = cammonClass.ToTitleCase(StockThirdUnitType_textBox.Text) + " Fiyatı";
        }

        private void all_Of_Price_textBox_Leave(object sender, EventArgs e)
        {
            TextBox incoming_price = (TextBox)sender;
            if (!String.IsNullOrEmpty(incoming_price.Text))
            {
                incoming_price.Text = cammonClass.ToStringTL(Convert.ToDouble(incoming_price.Text));
            }
        }

        private void FrmStokKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "FrmStoklar")
                {
                    FrmStoklar frm_Stoklar = (FrmStoklar)Application.OpenForms[i];
                    frm_Stoklar.Stoklar_dataGridView.Rows.Clear();
                    Stock_operation.List(frm_Stoklar.Stoklar_dataGridView);
                    frm_Stoklar.StokDetayıYenile();
                }
            }
        }

    }
}
