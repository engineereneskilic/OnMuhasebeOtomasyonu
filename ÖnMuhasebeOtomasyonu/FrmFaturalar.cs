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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        static Creater creater = new Creater();
        db_operation Bills_operation = creater.FactoryMethod(database_PreliminaryAccounting.Bills);

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            Bills_operation.List(Faturalar_dataGridView);
            FaturaDetayıYenile();
        }

        private void alışFaturasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatis_AlisFaturasi formAlisFaturasi = new FrmSatis_AlisFaturasi("Alış", true, Bills_operation.TableRowCount());
            formAlisFaturasi.Show();
            FaturaDetayıYenile();
            
        }

        private void ListeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faturalar_dataGridView.Rows.Clear();
            Bills_operation.List(Faturalar_dataGridView);
        }

        private void Sil_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int BillCode = Convert.ToInt32(Faturalar_dataGridView.SelectedRows[0].Cells["FaturaNo_column"].Value);

            Bills_operation.Delete(Convert.ToInt32(BillCode));
            Faturalar_dataGridView.Rows.Clear();
            Bills_operation.List(Faturalar_dataGridView);
            FaturaDetayıYenile();
        }

        private void Faturalar_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FaturaDetayıYenile();

        }
        private void Faturalar_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Faturalar_dataGridView.CurrentRow.Selected)
            {
                string ProcessType = Faturalar_dataGridView.SelectedRows[0].Cells["IslemTipi_column"].Value.ToString();
                FrmSatis_AlisFaturasi frm_fatura = new FrmSatis_AlisFaturasi(ProcessType.Split(' ')[0].ToString(), false, Convert.ToInt32(Faturalar_dataGridView.SelectedRows[0].Cells["FaturaNo_column"].Value));
                frm_fatura.Show();
            }
            
        }

        public  void FaturaDetayıYenile()
        {
            FaturaDetaylari_dataGridView.Rows.Clear();
            if (Faturalar_dataGridView.Rows.Count != 0)
            { // tablo boşsa seçili değer yoktur detay yenileme 
                
                DataTable FaturaDetaylari = Bills_operation.Query(Convert.ToInt32(Faturalar_dataGridView.SelectedRows[0].Cells["FaturaNo_column"].Value));
                foreach (DataRow row in FaturaDetaylari.Rows)
                {

                    FaturaDetaylari_dataGridView.Rows.Add(row["LineType"].ToString(), row["StockCode"].ToString(), row["Discript"].ToString(), row["UnitType"].ToString(), row["IncomingAmount"].ToString(), row["Yield"].ToString(), row["UnitPrice"].ToString(), row["LineTotalAmount"].ToString(), row["Kdv"].ToString(), row["Discount"].ToString(), row["Currency"].ToString());
                }
            }
        }

        private void satışFaturasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatis_AlisFaturasi formAlisFaturasi = new FrmSatis_AlisFaturasi("Satış", true, Bills_operation.TableRowCount());
            formAlisFaturasi.Show();
            FaturaDetayıYenile();
        }

    }
}
