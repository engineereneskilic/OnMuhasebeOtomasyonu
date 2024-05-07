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
using _DataLayer;

namespace ÖnMuhasebeOtomasyonu
{
    public partial class FrmCariHesapKarti : Form
    {
        private DataGridView CariKartlar_dataGridView;
        private bool Yenimi;
        public FrmCariHesapKarti(DataGridView cariKartlar_dataGridView,bool yenimi)
        {
            InitializeComponent();

            this.CariKartlar_dataGridView = cariKartlar_dataGridView;
            this.Yenimi = yenimi;
        }


       


        static Creater creater = new Creater();
        db_operation CurrentCards_operation = creater.FactoryMethod(database_PreliminaryAccounting.CurrentCards);

        private void FrmCariHesapKarti_Load(object sender, EventArgs e)
        {
            CurrentCode_textBox.Text = (CurrentCards_operation.TableRowCount()+2).ToString();
            

            KutularıDoldur();

        }

        private void KutularıDoldur()
        {
            if (!Yenimi)
            {
                int CurrentCode = Convert.ToInt32(CariKartlar_dataGridView.SelectedRows[0].Cells["CariKodu_column"].Value);
                CariKartlar_dataGridView.Refresh();

                DataRow row = CurrentCards_operation.Query(CurrentCode).Rows[0]; // Geçerli Current code göre tüm bilgileri alıyor.
                CurrentCode_textBox.Text = row["CurrentCode"].ToString();
                CurrentName_textBox.Text = row["CurrentName"].ToString();
                CurrentType_comboBox.Text = row["CurrentType"].ToString();
                FirstInformation_textBox.Text = row["FirstInformation"].ToString();
                SecondInformation_textBox.Text = row["SecondInformation"].ToString();
                FirstPhone_textbox.Text = row["FirstPhone"].ToString();
                SecondPhone_textBox.Text = row["SecondPhone"].ToString();
                FaxNo_textBox.Text = row["FaxNo"].ToString();
                GsmNo_textBox.Text = row["GsmNo"].ToString();
                Address_textBox.Text = row["Address"].ToString();
                Email_textBox.Text = row["Email"].ToString();
                Province_textBox.Text = row["Province"].ToString();
                District_textBox.Text = row["District"].ToString();
                notes_richTextBox.Text = row["Notes"].ToString();
            }
        }

        private void HesapKoduAcilir_button_Click(object sender, EventArgs e)
        {
            CurrentCode_textBox.Text = Convert.ToString(Convert.ToInt32(CurrentCode_textBox.Text) + 1); 
        }

        //Tablolar
        CurrentCards currentcards = CurrentCards.Instance;
        CurrentCardDetails currentcarddetails = CurrentCardDetails.Instance;
        

        private void Kaydet_button_Click(object sender, EventArgs e)
        {
           

            currentcards.CurrentCode = Convert.ToInt32(CurrentCode_textBox.Text);
            currentcarddetails.CurrentCode = currentcards.CurrentCode;
            currentcards.CurrentType = CurrentType_comboBox.Text.ToString();
            currentcards.CurrentName = CurrentName_textBox.Text;
            currentcarddetails.FirstInformation = FirstInformation_textBox.Text;
            currentcarddetails.SecondInformation = SecondInformation_textBox.Text;
            currentcarddetails.FirstPhone = Convert.ToString(FirstPhone_textbox.Text);
            currentcarddetails.SecondPhone = Convert.ToString(SecondPhone_textBox.Text);
            currentcarddetails.FaxNo = FaxNo_textBox.Text;
            currentcarddetails.GsmNo = Convert.ToString(GsmNo_textBox.Text);
            currentcarddetails.Address = Address_textBox.Text;
            currentcarddetails.Email = Email_textBox.Text;
            currentcarddetails.Province = Province_textBox.Text;
            currentcarddetails.District = District_textBox.Text;
            currentcarddetails.Notes = notes_richTextBox.Text;
            CurrentCards_operation.Insert_Update();
        }



        private void Iptal_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Onceki_button_Click(object sender, EventArgs e)
        {
            if (CariKartlar_dataGridView.Rows.Count!=0)
            {
                int rowIndex = CariKartlar_dataGridView.SelectedRows[0].Index;
                if (0 < rowIndex)
                {

                    CariKartlar_dataGridView.Rows[rowIndex - 1].Selected = true;
                    CariKartlar_dataGridView.Rows[rowIndex].Selected = false;
                    KutularıDoldur();
                }
            }
        }

        private void Sonraki_button_Click(object sender, EventArgs e)
        {
            if (CariKartlar_dataGridView.Rows.Count != 0)
            {
                int rowIndex = CariKartlar_dataGridView.SelectedRows[0].Index;

                if (CariKartlar_dataGridView.Rows.Count > rowIndex + 1)
                {

                    CariKartlar_dataGridView.Rows[rowIndex + 1].Selected = true;
                    CariKartlar_dataGridView.Rows[rowIndex].Selected = false;
                    KutularıDoldur();
                }
            }
        }

        private void Sil_button_Click(object sender, EventArgs e)
        {
            if (CariKartlar_dataGridView.Rows.Count != 0)
            {
                CurrentCards_operation.Delete(Convert.ToInt32(CurrentCode_textBox.Text));
                CariKartlar_dataGridView.Rows.Clear();
                CurrentCards_operation.List(CariKartlar_dataGridView);
                this.Close();
            }
        }

        private void Yeni_button_Click(object sender, EventArgs e)
        {
            FrmCariHesapKarti frmcarihesapkarti = new FrmCariHesapKarti(CariKartlar_dataGridView,true);
            frmcarihesapkarti.Show();
        }

        private void FrmCariHesapKarti_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "FrmCariAcilir")
                {
                    FrmCariAcilir frm_Fatura = (FrmCariAcilir)Application.OpenForms[i];
                    frm_Fatura.CariKartlar_dataGridView.Rows.Clear();
                    CurrentCards_operation.List(frm_Fatura.CariKartlar_dataGridView);
                }else
                if(Application.OpenForms[i].Name == "FrmCariKartlar")
                {
                    FrmCariKartlar frm_Cariler = (FrmCariKartlar)Application.OpenForms[i];
                    frm_Cariler.CariKartlar_dataGridView.Rows.Clear();
                    CurrentCards_operation.List(frm_Cariler.CariKartlar_dataGridView);
                }
                
            }
        }
    }
}
