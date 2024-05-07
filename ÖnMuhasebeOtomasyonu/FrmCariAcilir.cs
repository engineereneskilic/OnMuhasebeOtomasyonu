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
    public partial class FrmCariAcilir : Form
    {
        private TextBox currentCode_textBox;
        private TextBox currentName_textBox;
        public FrmCariAcilir(TextBox currentCode_textBox, TextBox currentName_textBox)
        {
            this.currentCode_textBox = currentCode_textBox;
            this.currentName_textBox = currentName_textBox;
            InitializeComponent();
        }

        static Creater creater = new Creater();
        db_operation CurrentCards_operation = creater.FactoryMethod(database_PreliminaryAccounting.CurrentCards);
     

        private void FrmCariAcilir_Load(object sender, EventArgs e)
        {
            CariKartlar_dataGridView.Rows.Clear();
            CurrentCards_operation.List(CariKartlar_dataGridView);
        }

        private void CariKartlar_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CariKartlar_dataGridView.Rows.Count != 0)
            {
                SecilenCari();
            }
        }

        private void SecilenCari()
        {
            if (CariKartlar_dataGridView.CurrentRow.Selected)
            {
                currentCode_textBox.Text = Convert.ToString(CariKartlar_dataGridView.SelectedRows[0].Cells["CariKodu_column"].Value);
                currentName_textBox.Text = Convert.ToString(CariKartlar_dataGridView.SelectedRows[0].Cells["CariAdi_column"].Value);
            }
            this.Close();

        }

        private void choose_button_Click(object sender, EventArgs e)
        {
            if (CariKartlar_dataGridView.Rows.Count != 0)
            {
                SecilenCari();

            }
        }

        private void Iptal_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeni_ekle_button_Click(object sender, EventArgs e)
        {
            FrmCariHesapKarti frm_carikart = new FrmCariHesapKarti(CariKartlar_dataGridView, true);
            frm_carikart.Show();
            CurrentCards_operation.List(CariKartlar_dataGridView);
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCariHesapKarti frm_carikart = new FrmCariHesapKarti(CariKartlar_dataGridView, true);
            frm_carikart.Show();
            CurrentCards_operation.List(CariKartlar_dataGridView);
        }

        private void listeyiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariKartlar_dataGridView.Rows.Clear();
            CurrentCards_operation.List(CariKartlar_dataGridView);
        }
    }
}
