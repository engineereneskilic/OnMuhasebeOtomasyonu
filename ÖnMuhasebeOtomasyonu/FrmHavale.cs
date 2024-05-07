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
    public partial class asdf : Form
    {
        private string havaleTipi;
        public asdf(string HavaleTipi)
        {
            InitializeComponent();
            this.havaleTipi = HavaleTipi;
        }

        DateTime tarih = DateTime.Today;
        private void asdf_Load(object sender, EventArgs e)
        {
            BankTransferDate_textBox.Text = tarih.Date.ToShortDateString();
            this.Text = havaleTipi + " Havale";
        }
        
        private void BankAccountNo_textBox_TextChanged(object sender, EventArgs e)
        {
            
            BankAccountNo_changedlabel.Text = BankAccountNo_textBox.Text;

        }

        private void BankName_textBox_TextChanged(object sender, EventArgs e)
        {
            BankAccountName_changedlabel.Text = BankName_textBox.Text;
        }


        private void banka_acilir_button_Click(object sender, EventArgs e)
        {
            FrmBankaAcilir formBankaAcilir = new FrmBankaAcilir(BankAccountNo_textBox, BankName_textBox);
            formBankaAcilir.Show();
        }

        private void cari_acilir_button_Click(object sender, EventArgs e)
        {
            FrmCariAcilir formCariAcilir = new FrmCariAcilir(CurrentCode_textBox, CurrentName_textBox);
            formCariAcilir.Show();
        }

        private void BankTransferPrice_textBox_Leave(object sender, EventArgs e)
        {
            BankTransferPrice_textBox.Text = cammonClass.ToStringTL(Convert.ToDouble(cammonClass.ZeroIfEmpty(BankTransferPrice_textBox.Text)));
            BankExpencePrice_textBox.Text = cammonClass.ToStringTL(Convert.ToDouble(Convert.ToDouble(cammonClass.ZeroIfEmpty(BankTransferPrice_textBox.Text)) / 100) * Convert.ToInt32(BankExpencePercent_textBox.Text));
        }

        private void BankExpencePercent_textBox_TextChanged(object sender, EventArgs e)
        {
            BankTransferPrice_textBox.Text = cammonClass.ToStringTL(Convert.ToDouble(cammonClass.ZeroIfEmpty(BankTransferPrice_textBox.Text)));
            BankExpencePrice_textBox.Text = cammonClass.ToStringTL(Convert.ToDouble(Convert.ToDouble(cammonClass.ZeroIfEmpty(BankTransferPrice_textBox.Text)) / 100) * Convert.ToInt32( cammonClass.ZeroIfEmpty(BankExpencePercent_textBox.Text)));
        }

        BankProcess bankprocess = BankProcess.Instance;

        static Creater creater = new Creater();
        db_operation bank_operation = creater.FactoryMethod(database_PreliminaryAccounting.Banks);

        private void Kaydet_button_Click(object sender, EventArgs e)
        {
            if (havaleTipi == "Gelen")
            {
                bankprocess.ProcessType = "Gelen Havale";
                bankprocess.NetDebt = Convert.ToDouble(cammonClass.ZeroIfEmpty(BankTransferPrice_textBox.Text));
                bankprocess.NetCredit = 0;
                bankprocess.BankAccountNo = Convert.ToInt32(BankAccountNo_textBox.Text);
                bankprocess.ProcessDate = Convert.ToDateTime(BankTransferDate_textBox.Text);
                bankprocess.CurrentCode = Convert.ToInt32(CurrentCode_textBox.Text);
                bankprocess.CurrentName = CurrentName_textBox.Text;
                bankprocess.Descript = BankDescript_textBox.Text;
                bankprocess.Expense = Convert.ToDouble(cammonClass.ZeroIfEmpty(BankExpencePrice_textBox.Text));
                bankprocess.Currency = "TL";
                bank_operation.Insert_Update();
            }
            else
            if (havaleTipi == "Gönderilen")
            {
                bankprocess.ProcessType = "Gönderilen Havale";
                bankprocess.NetCredit = Convert.ToDouble(cammonClass.ZeroIfEmpty(BankTransferPrice_textBox.Text));
                bankprocess.NetDebt = 0;
                bankprocess.BankAccountNo = Convert.ToInt32(BankAccountNo_textBox.Text);
                bankprocess.ProcessDate = Convert.ToDateTime(BankTransferDate_textBox.Text);
                bankprocess.CurrentCode = Convert.ToInt32(CurrentCode_textBox.Text);
                bankprocess.CurrentName = CurrentName_textBox.Text;
                bankprocess.Descript = BankDescript_textBox.Text;
                bankprocess.Expense = Convert.ToDouble(cammonClass.ZeroIfEmpty(BankExpencePrice_textBox.Text));
                bankprocess.Currency = "TL";
                bank_operation.Insert_Update();
            }
        }

    }
}
