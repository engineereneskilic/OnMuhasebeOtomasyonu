using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _BusinessLayer;
namespace ÖnMuhasebeOtomasyonu
{
    public partial class FrmCariKartlar : Form
    {
        public FrmCariKartlar()
        {
            InitializeComponent();
        }

        static Creater creater = new Creater();
        db_operation CurrentCards_operation = creater.FactoryMethod(database_PreliminaryAccounting.CurrentCards);

        private void FrmCariKartlar_Load(object sender, EventArgs e)
        {
            // listele
            CurrentCards_operation.List(CariKartlar_dataGridView);
            HesapHareketiYenile();
            
        }

        private void YeniEkle_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCariHesapKarti frm_carikart = new FrmCariHesapKarti(CariKartlar_dataGridView,true);
            frm_carikart.Show();
        }


        private void ListeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariKartlar_dataGridView.Rows.Clear();
            CurrentCards_operation.List(CariKartlar_dataGridView);
        }

        private void Sil_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurrentCode = Convert.ToInt32(CariKartlar_dataGridView.SelectedRows[0].Cells["CariKodu_column"].Value);

            CurrentCards_operation.Delete(Convert.ToInt32(CurrentCode));
            CariKartlar_dataGridView.Rows.Clear();
            CurrentCards_operation.List(CariKartlar_dataGridView);
        }

        private void CariKartlar_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CariKartlar_dataGridView.CurrentRow.Selected)
            {
                FrmCariHesapKarti frm_carikart = new FrmCariHesapKarti(CariKartlar_dataGridView, false);
                frm_carikart.Show();
            }
        }
        public void HesapHareketiYenile()
        {
            HesapHareketleri_dataGridView.Rows.Clear();
            DataTable StokHareketleri =  CurrentCards_operation.Query(Convert.ToInt32(CariKartlar_dataGridView.SelectedRows[0].Cells["CariKodu_column"].Value));

            foreach (DataRow row in StokHareketleri.Rows)
            {
                if (StokHareketleri.Columns.Count == 21) // dönen hareketli gelirse hareketlerini göstersin
                { 
                    HesapHareketleri_dataGridView.Rows.Add(row["MovementDate"].ToString().Substring(0,10), row["SequenceNo"].ToString(), row["ProcessType"].ToString(), row["Descript"].ToString(), row["Debt"].ToString(), row["Credit"].ToString(), row["Currency"].ToString());
                }
            }

        }

        private void CariKartlar_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HesapHareketiYenile();
        }

        private void gelenHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asdf gelen_havale = new asdf("Gelen");
            gelen_havale.Show();
        }

        private void gidenHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asdf gelen_havale = new asdf("Gönderilen");
            gelen_havale.Show();
        }

        db_operation Bill_operation = creater.FactoryMethod(database_PreliminaryAccounting.Bills);

        private void satışFaturasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatis_AlisFaturasi formAlisFaturasi = new FrmSatis_AlisFaturasi("Satış", true, Bill_operation.TableRowCount());
            formAlisFaturasi.Show();
        }

        private void alışFaturasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatis_AlisFaturasi formAlisFaturasi = new FrmSatis_AlisFaturasi("Alış", true, Bill_operation.TableRowCount());
            formAlisFaturasi.Show();
        }
    }
}
