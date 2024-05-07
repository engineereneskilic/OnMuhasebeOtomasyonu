using _BusinessLayer;
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
    public partial class FrmStokAcilir : Form
    {
        private DataGridViewCell stockBarCode_dataGridViewCell;
        private DataGridViewCell stockCode_dataGridViewCell;
        private DataGridViewCell stockName_dataGridViewCell;
        private DataGridViewComboBoxColumn stokBirimi_Combobox;
        private DataGridViewCell stockKDV_dataGridViewCell;
        private DataGridViewCell birimFiyat_dataGridViewCell;

        public FrmStokAcilir(DataGridViewCell StockBarCode_dataGridViewCell, DataGridViewCell StockCode_dataGridViewCell, DataGridViewCell StockName_dataGridViewCell, DataGridViewComboBoxColumn StokBirimi_Combobox, DataGridViewCell StockKDV_dataGridViewCell, DataGridViewCell BirimFiyat_dataGridViewCell)
        {
            InitializeComponent();
            this.stockBarCode_dataGridViewCell = StockBarCode_dataGridViewCell;
            this.stockCode_dataGridViewCell = StockCode_dataGridViewCell;
            this.stockName_dataGridViewCell = StockName_dataGridViewCell;
            this.stokBirimi_Combobox = StokBirimi_Combobox;
            this.stockKDV_dataGridViewCell = StockKDV_dataGridViewCell;
            this.birimFiyat_dataGridViewCell = BirimFiyat_dataGridViewCell;
        }


        static Creater creater = new Creater();
        db_operation stock_operation = creater.FactoryMethod(database_PreliminaryAccounting.Stocks);
        

        private void FrmStokAcilir_Load(object sender, EventArgs e)
        {
            stock_operation.List(Stoklar_dataGridView);

          
        }

        private void Stoklar_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SecilenStok();
        }
        private void SecilenStok() 
        {
            if (Stoklar_dataGridView.CurrentRow.Selected)
            {
                DataRow row =stock_operation.Query(Convert.ToInt32(Stoklar_dataGridView.SelectedRows[0].Cells["StokKodu_Column"].Value)).Rows[0];
                
                    stockBarCode_dataGridViewCell.Value = row["StockBarcode"].ToString();
                    stockCode_dataGridViewCell.Value = row["StockCode"].ToString();
                    stockName_dataGridViewCell.Value = row["StockName"].ToString();
                    stokBirimi_Combobox.Items.Clear();
                    stokBirimi_Combobox.Items.AddRange(row["StockMainUnitType"],row["StockSecondUnitType"],row["StockThirdUnitType"]);
                    stockKDV_dataGridViewCell.Value = row["StockKDV"].ToString();


            }
            this.Close();

        }

        private void choose_button_Click(object sender, EventArgs e)
        {
            SecilenStok();
        }

        private void Iptal_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
