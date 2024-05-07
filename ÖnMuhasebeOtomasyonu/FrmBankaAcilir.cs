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
    public partial class FrmBankaAcilir : Form
    {
        private TextBox BankAccountNo_textBox;
        private TextBox BankAccountName_textbox;

        public FrmBankaAcilir(TextBox bankAccountNo_textBox, TextBox bankAccountName_textbox)
        {
            InitializeComponent();
            this.BankAccountNo_textBox = bankAccountNo_textBox;
            this.BankAccountName_textbox = bankAccountName_textbox;
        }

        static Creater creater = new Creater();
        db_operation bank_operation = creater.FactoryMethod(database_PreliminaryAccounting.Banks);


        private void FrmBankaAcilir_Load(object sender, EventArgs e)
        {
            bankalar_dataGridView.Rows.Clear();
            bank_operation.List(bankalar_dataGridView);
        }

        private void bankalar_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bankalar_dataGridView.CurrentRow.Selected)
            {
                BankAccountNo_textBox.Text = Convert.ToString(bankalar_dataGridView.SelectedRows[0].Cells["Sıra_column"].Value);
                BankAccountName_textbox.Text = Convert.ToString(bankalar_dataGridView.SelectedRows[0].Cells["hesapadi_column"].Value);
            }
            this.Close();
        }

        private void sec_button_Click_1(object sender, EventArgs e)
        {
            if (bankalar_dataGridView.CurrentRow.Selected)
            {
                BankAccountNo_textBox.Text = Convert.ToString(bankalar_dataGridView.SelectedRows[0].Cells["Sıra_column"].Value);
                BankAccountName_textbox.Text = Convert.ToString(bankalar_dataGridView.SelectedRows[0].Cells["hesapadi_column"].Value);
            }
            this.Close();
        }
    }
}
