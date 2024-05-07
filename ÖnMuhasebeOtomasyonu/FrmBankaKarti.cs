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
    public partial class FrmBankaKarti : Form
    {
        private DataGridView bankalar_dataGridView;
        private bool yenimi;

        public FrmBankaKarti(DataGridView Bankalar_dataGridView,bool Yenimi)
        {
            InitializeComponent();
            this.bankalar_dataGridView = Bankalar_dataGridView;
            this.yenimi = Yenimi;
        }
        static Creater creater = new Creater();
        db_operation Bank_operation = creater.FactoryMethod(database_PreliminaryAccounting.Banks);
        private void FrmBankaKarti_Load(object sender, EventArgs e)
        {
            accountNo_textBox.Text = (Bank_operation.TableRowCount() + 1).ToString();

            KutularıDoldur();
        }
        private void KutularıDoldur()
        {
            if (!yenimi)
            {

                int BankAccountNo = Convert.ToInt32(bankalar_dataGridView.SelectedRows[0].Cells["HesapNo_column"].Value);
                bankalar_dataGridView.Refresh();

                DataRow row = Bank_operation.Query(BankAccountNo).Rows[0]; // Geçerli Current code göre tüm bilgileri alıyor.

                accountNo_textBox.Text = row["BankAccountNo"].ToString();
                IbanNo_textBox.Text = row["IbanNo"].ToString();
                BankName_textBox.Text = row["BankName"].ToString();
                BankAccountName_textBox.Text = row["BankAccountName"].ToString();
                BankBranch_textBox.Text = row["BankBranch"].ToString();
                BankAccountHolder_textBox.Text = row["BankAccountHolder"].ToString();
                BankAccountHolderAdress_textBox.Text = row["BankAccountHolderAdress"].ToString();
                BankAccountHolderPhone_textBox.Text = row["BankAccountHolderPhone"].ToString();

            }
        }

        Banks bank = Banks.Instance;
        private void Kaydet_button_Click(object sender, EventArgs e)
        {
            bank.BankAccountNo = Convert.ToInt32(accountNo_textBox.Text);
            bank.IbanNo = IbanNo_textBox.Text;
            bank.BankName = BankName_textBox.Text;
            bank.BankAccountName = BankAccountName_textBox.Text;
            bank.BankBranch = BankBranch_textBox.Text;
            bank.BankAccountHolder = BankAccountHolder_textBox.Text;
            bank.BankAccountHolderAdress = BankAccountHolderAdress_textBox.Text;
            bank.BankAccountHolderPhone = BankAccountHolderPhone_textBox.Text;
            //bank.BankBalance // ilginçtir entitiy float tipindeki değişken class'ın değişkenine 0 değeri verince hata veriyor.
            bank.Currency = "TL";
            Bank_operation.Insert_Update();

        }

        private void Iptal_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yeni_button_Click(object sender, EventArgs e)
        {
            FrmBankaKarti form_bankakarti = new FrmBankaKarti(bankalar_dataGridView,true);
            form_bankakarti.Show();
        }

        private void Onceki_button_Click(object sender, EventArgs e)
        {
            int rowIndex = bankalar_dataGridView.SelectedRows[0].Index;
            if (0 < rowIndex)
            {

                bankalar_dataGridView.Rows[rowIndex - 1].Selected = true;
                bankalar_dataGridView.Rows[rowIndex].Selected = false;
                KutularıDoldur();
            }
        }

        private void Sonraki_button_Click(object sender, EventArgs e)
        {
            int rowIndex = bankalar_dataGridView.SelectedRows[0].Index;

            if (bankalar_dataGridView.Rows.Count > rowIndex + 1)
            {

                bankalar_dataGridView.Rows[rowIndex + 1].Selected = true;
                bankalar_dataGridView.Rows[rowIndex].Selected = false;
                KutularıDoldur();
            }
        }

        private void Sil_button_Click(object sender, EventArgs e)
        {
            Bank_operation.Delete(Convert.ToInt32(accountNo_textBox.Text));
            bankalar_dataGridView.Rows.Clear();
            Bank_operation.List(bankalar_dataGridView);
            this.Close();
        }

        private void FrmBankaKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "FrmBankalar")
                {
                    FrmBankalar frm_Bankalar = (FrmBankalar)Application.OpenForms[i];
                    frm_Bankalar.bankalar_dataGridView.Rows.Clear();
                    Bank_operation.List(frm_Bankalar.bankalar_dataGridView);
                    frm_Bankalar.BankaHareketiYenile();
                }
            }
        }
    }
}
