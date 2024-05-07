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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        static Creater creater = new Creater();
        db_operation Stock_operation = creater.FactoryMethod(database_PreliminaryAccounting.Stocks);

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            Stock_operation.List(Stoklar_dataGridView);
            StokDetayıYenile();



        }
        private void YeniEkle_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokKarti frm_stokkarti = new FrmStokKarti(Stoklar_dataGridView,true);
            frm_stokkarti.Show();
        }

        private void Stoklar_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StokDetayıYenile();
        }

        private void Sil_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Stoklar_dataGridView.SelectedRows[0].Cells["StokKodu_column"].Value != null)
            {
                int StockCode = Convert.ToInt32(Stoklar_dataGridView.SelectedRows[0].Cells["StokKodu_column"].Value);
                Stock_operation.Delete(Convert.ToInt32(StockCode));
            }
                Stoklar_dataGridView.Rows.Clear();
                Stock_operation.List(Stoklar_dataGridView);
            
        }

        private void ListeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stoklar_dataGridView.Rows.Clear();
            Stock_operation.List(Stoklar_dataGridView);
        }

        private void Stoklar_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (Stoklar_dataGridView.CurrentRow.Selected)
            {
                FrmStokKarti frm_stokkarti = new FrmStokKarti(Stoklar_dataGridView, false);
                frm_stokkarti.Show();
            }
        }
        public void StokDetayıYenile()
        {
            StokHareketleri_dataGridView.Rows.Clear();
            DataTable StokHareketleri = Stock_operation.Query(Convert.ToInt32(Stoklar_dataGridView.SelectedRows[0].Cells["StokKodu_column"].Value));

            foreach (DataRow row in StokHareketleri.Rows)
            {

                if (StokHareketleri.Columns.Count==29) // İlgili stoğun hareketi varsa listelesin
                {
                    StokHareketleri_dataGridView.Rows.Add(row["ProcessDate"].ToString().Substring(0, 10), row["ProcessType"].ToString(), row["CurrentCode"].ToString(), row["CurrentName"].ToString(), row["IncomingAmount"].ToString(), row["Yield"].ToString(), row["UnitPrice"].ToString(), row["TotalAmount"].ToString(), row["Discount"].ToString(), row["BillCode"].ToString());
                }

                
            }

        }
       
    }
}
