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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        static Creater creater = new Creater();
        db_operation Bank_operation = creater.FactoryMethod(database_PreliminaryAccounting.Banks);
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            Bank_operation.List(bankalar_dataGridView);
            BankaHareketiYenile();
        }

        private void YeniEkle_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankaKarti form_bankakarti = new FrmBankaKarti(bankalar_dataGridView,true);
            form_bankakarti.Show();
        }

        private void bankalar_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BankaHareketiYenile();
        }

        private void Sil_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bankalar_dataGridView.SelectedRows[0].Cells["HesapNo_column"].Value != null)
            {
                int BankAccountNo = Convert.ToInt32(bankalar_dataGridView.SelectedRows[0].Cells["BankAccountNo"].Value);
                Bank_operation.Delete(Convert.ToInt32(BankAccountNo));
            }
            bankalar_dataGridView.Rows.Clear();
            Bank_operation.List(bankalar_dataGridView);
        }

        private void ListeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
             bankalar_dataGridView.Rows.Clear();
             Bank_operation.List(bankalar_dataGridView);
        }

        private void bankalar_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bankalar_dataGridView.CurrentRow.Selected)
            {
                FrmBankaKarti frm_stokkarti = new FrmBankaKarti(bankalar_dataGridView,false);
                frm_stokkarti.Show();
            }
        }
        public void BankaHareketiYenile()
        {
            BankaIslemleri_dataGridView.Rows.Clear();
            DataTable bbankaHareketleri = Bank_operation.Query(1);

            foreach (DataRow row in bbankaHareketleri.Rows)
            {
                
                if (bbankaHareketleri.Columns.Count == 17) // İlgili stoğun hareketi varsa listelesin
                {
                    BankaIslemleri_dataGridView.Rows.Add(row["ProcessType"].ToString(), row["ProcessDate"].ToString().Substring(0,10),row["CurrentName"].ToString(),row["Descript"].ToString(),row["NetCredit"].ToString(),row["NetDebt"].ToString(),row["Expense"].ToString(),row["Currency"].ToString());
                }
            }
        }
    }
}
