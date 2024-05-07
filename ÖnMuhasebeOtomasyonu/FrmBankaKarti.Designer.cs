namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmBankaKarti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IslemTablolari_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Kaydet_button = new System.Windows.Forms.Button();
            this.Sil_button = new System.Windows.Forms.Button();
            this.Yeni_button = new System.Windows.Forms.Button();
            this.Iptal_button = new System.Windows.Forms.Button();
            this.Sonraki_button = new System.Windows.Forms.Button();
            this.Onceki_button = new System.Windows.Forms.Button();
            this.hesapbilgileri_groupBox = new System.Windows.Forms.GroupBox();
            this.BankAccountHolderAdress_textBox = new System.Windows.Forms.RichTextBox();
            this.BankAccountHolder_textBox = new System.Windows.Forms.TextBox();
            this.BankAccountHolderPhone_textBox = new System.Windows.Forms.TextBox();
            this.BankBranch_textBox = new System.Windows.Forms.TextBox();
            this.BankAccountName_textBox = new System.Windows.Forms.TextBox();
            this.BankName_textBox = new System.Windows.Forms.TextBox();
            this.IbanNo_textBox = new System.Windows.Forms.TextBox();
            this.accountNo_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IslemTablolari_tableLayoutPanel.SuspendLayout();
            this.hesapbilgileri_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IslemTablolari_tableLayoutPanel
            // 
            this.IslemTablolari_tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.IslemTablolari_tableLayoutPanel.ColumnCount = 6;
            this.IslemTablolari_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IslemTablolari_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IslemTablolari_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IslemTablolari_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IslemTablolari_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IslemTablolari_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.IslemTablolari_tableLayoutPanel.Controls.Add(this.Kaydet_button, 0, 0);
            this.IslemTablolari_tableLayoutPanel.Controls.Add(this.Sil_button, 5, 0);
            this.IslemTablolari_tableLayoutPanel.Controls.Add(this.Yeni_button, 2, 0);
            this.IslemTablolari_tableLayoutPanel.Controls.Add(this.Iptal_button, 1, 0);
            this.IslemTablolari_tableLayoutPanel.Controls.Add(this.Sonraki_button, 4, 0);
            this.IslemTablolari_tableLayoutPanel.Controls.Add(this.Onceki_button, 3, 0);
            this.IslemTablolari_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.IslemTablolari_tableLayoutPanel.Name = "IslemTablolari_tableLayoutPanel";
            this.IslemTablolari_tableLayoutPanel.RowCount = 1;
            this.IslemTablolari_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IslemTablolari_tableLayoutPanel.Size = new System.Drawing.Size(767, 35);
            this.IslemTablolari_tableLayoutPanel.TabIndex = 1;
            // 
            // Kaydet_button
            // 
            this.Kaydet_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Kaydett;
            this.Kaydet_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Kaydet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Kaydet_button.Location = new System.Drawing.Point(5, 5);
            this.Kaydet_button.Name = "Kaydet_button";
            this.Kaydet_button.Size = new System.Drawing.Size(80, 25);
            this.Kaydet_button.TabIndex = 0;
            this.Kaydet_button.Text = "       Kaydet";
            this.Kaydet_button.UseVisualStyleBackColor = true;
            this.Kaydet_button.Click += new System.EventHandler(this.Kaydet_button_Click);
            // 
            // Sil_button
            // 
            this.Sil_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Sil;
            this.Sil_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sil_button.Location = new System.Drawing.Point(445, 5);
            this.Sil_button.Name = "Sil_button";
            this.Sil_button.Size = new System.Drawing.Size(80, 25);
            this.Sil_button.TabIndex = 5;
            this.Sil_button.Text = "   Sil";
            this.Sil_button.UseVisualStyleBackColor = true;
            this.Sil_button.Click += new System.EventHandler(this.Sil_button_Click);
            // 
            // Yeni_button
            // 
            this.Yeni_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Yeni;
            this.Yeni_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Yeni_button.Location = new System.Drawing.Point(181, 5);
            this.Yeni_button.Name = "Yeni_button";
            this.Yeni_button.Size = new System.Drawing.Size(80, 25);
            this.Yeni_button.TabIndex = 2;
            this.Yeni_button.Text = "    Yeni";
            this.Yeni_button.UseVisualStyleBackColor = true;
            this.Yeni_button.Click += new System.EventHandler(this.Yeni_button_Click);
            // 
            // Iptal_button
            // 
            this.Iptal_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.İptal;
            this.Iptal_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Iptal_button.Location = new System.Drawing.Point(93, 5);
            this.Iptal_button.Name = "Iptal_button";
            this.Iptal_button.Size = new System.Drawing.Size(80, 25);
            this.Iptal_button.TabIndex = 1;
            this.Iptal_button.Text = "     İptal";
            this.Iptal_button.UseVisualStyleBackColor = true;
            this.Iptal_button.Click += new System.EventHandler(this.Iptal_button_Click);
            // 
            // Sonraki_button
            // 
            this.Sonraki_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.sonraki;
            this.Sonraki_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sonraki_button.Location = new System.Drawing.Point(357, 5);
            this.Sonraki_button.Name = "Sonraki_button";
            this.Sonraki_button.Size = new System.Drawing.Size(80, 25);
            this.Sonraki_button.TabIndex = 4;
            this.Sonraki_button.Text = "    Sonraki";
            this.Sonraki_button.UseVisualStyleBackColor = true;
            this.Sonraki_button.Click += new System.EventHandler(this.Sonraki_button_Click);
            // 
            // Onceki_button
            // 
            this.Onceki_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.önceki;
            this.Onceki_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Onceki_button.Location = new System.Drawing.Point(269, 5);
            this.Onceki_button.Name = "Onceki_button";
            this.Onceki_button.Size = new System.Drawing.Size(80, 25);
            this.Onceki_button.TabIndex = 3;
            this.Onceki_button.Text = "    Önceki";
            this.Onceki_button.UseVisualStyleBackColor = true;
            this.Onceki_button.Click += new System.EventHandler(this.Onceki_button_Click);
            // 
            // hesapbilgileri_groupBox
            // 
            this.hesapbilgileri_groupBox.Controls.Add(this.BankAccountHolderAdress_textBox);
            this.hesapbilgileri_groupBox.Controls.Add(this.BankAccountHolder_textBox);
            this.hesapbilgileri_groupBox.Controls.Add(this.BankAccountHolderPhone_textBox);
            this.hesapbilgileri_groupBox.Controls.Add(this.BankBranch_textBox);
            this.hesapbilgileri_groupBox.Controls.Add(this.BankAccountName_textBox);
            this.hesapbilgileri_groupBox.Controls.Add(this.BankName_textBox);
            this.hesapbilgileri_groupBox.Controls.Add(this.IbanNo_textBox);
            this.hesapbilgileri_groupBox.Controls.Add(this.accountNo_textBox);
            this.hesapbilgileri_groupBox.Controls.Add(this.label4);
            this.hesapbilgileri_groupBox.Controls.Add(this.label5);
            this.hesapbilgileri_groupBox.Controls.Add(this.label6);
            this.hesapbilgileri_groupBox.Controls.Add(this.label7);
            this.hesapbilgileri_groupBox.Controls.Add(this.label12);
            this.hesapbilgileri_groupBox.Controls.Add(this.label3);
            this.hesapbilgileri_groupBox.Controls.Add(this.label2);
            this.hesapbilgileri_groupBox.Controls.Add(this.label1);
            this.hesapbilgileri_groupBox.Location = new System.Drawing.Point(5, 41);
            this.hesapbilgileri_groupBox.Name = "hesapbilgileri_groupBox";
            this.hesapbilgileri_groupBox.Size = new System.Drawing.Size(520, 329);
            this.hesapbilgileri_groupBox.TabIndex = 2;
            this.hesapbilgileri_groupBox.TabStop = false;
            this.hesapbilgileri_groupBox.Text = "Hesap Bilgileri";
            // 
            // BankAccountHolderAdress_textBox
            // 
            this.BankAccountHolderAdress_textBox.Location = new System.Drawing.Point(114, 216);
            this.BankAccountHolderAdress_textBox.Name = "BankAccountHolderAdress_textBox";
            this.BankAccountHolderAdress_textBox.Size = new System.Drawing.Size(231, 70);
            this.BankAccountHolderAdress_textBox.TabIndex = 6;
            this.BankAccountHolderAdress_textBox.Text = "";
            // 
            // BankAccountHolder_textBox
            // 
            this.BankAccountHolder_textBox.Location = new System.Drawing.Point(115, 189);
            this.BankAccountHolder_textBox.Multiline = true;
            this.BankAccountHolder_textBox.Name = "BankAccountHolder_textBox";
            this.BankAccountHolder_textBox.Size = new System.Drawing.Size(230, 23);
            this.BankAccountHolder_textBox.TabIndex = 5;
            // 
            // BankAccountHolderPhone_textBox
            // 
            this.BankAccountHolderPhone_textBox.Location = new System.Drawing.Point(114, 294);
            this.BankAccountHolderPhone_textBox.Multiline = true;
            this.BankAccountHolderPhone_textBox.Name = "BankAccountHolderPhone_textBox";
            this.BankAccountHolderPhone_textBox.Size = new System.Drawing.Size(230, 23);
            this.BankAccountHolderPhone_textBox.TabIndex = 7;
            // 
            // BankBranch_textBox
            // 
            this.BankBranch_textBox.Location = new System.Drawing.Point(115, 162);
            this.BankBranch_textBox.Multiline = true;
            this.BankBranch_textBox.Name = "BankBranch_textBox";
            this.BankBranch_textBox.Size = new System.Drawing.Size(230, 23);
            this.BankBranch_textBox.TabIndex = 4;
            // 
            // BankAccountName_textBox
            // 
            this.BankAccountName_textBox.Location = new System.Drawing.Point(115, 134);
            this.BankAccountName_textBox.Multiline = true;
            this.BankAccountName_textBox.Name = "BankAccountName_textBox";
            this.BankAccountName_textBox.Size = new System.Drawing.Size(318, 23);
            this.BankAccountName_textBox.TabIndex = 3;
            // 
            // BankName_textBox
            // 
            this.BankName_textBox.Location = new System.Drawing.Point(115, 108);
            this.BankName_textBox.Multiline = true;
            this.BankName_textBox.Name = "BankName_textBox";
            this.BankName_textBox.Size = new System.Drawing.Size(317, 23);
            this.BankName_textBox.TabIndex = 2;
            // 
            // IbanNo_textBox
            // 
            this.IbanNo_textBox.Location = new System.Drawing.Point(114, 66);
            this.IbanNo_textBox.Multiline = true;
            this.IbanNo_textBox.Name = "IbanNo_textBox";
            this.IbanNo_textBox.Size = new System.Drawing.Size(230, 23);
            this.IbanNo_textBox.TabIndex = 1;
            // 
            // accountNo_textBox
            // 
            this.accountNo_textBox.Enabled = false;
            this.accountNo_textBox.Location = new System.Drawing.Point(114, 39);
            this.accountNo_textBox.Multiline = true;
            this.accountNo_textBox.Name = "accountNo_textBox";
            this.accountNo_textBox.ReadOnly = true;
            this.accountNo_textBox.Size = new System.Drawing.Size(230, 23);
            this.accountNo_textBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hesap Adı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bank Adı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 66);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "IBAN NO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 39);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Hesap No";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 294);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(103, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Telefonu";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 216);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 189);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "İlgili";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şubesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmBankaKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(538, 382);
            this.Controls.Add(this.hesapbilgileri_groupBox);
            this.Controls.Add(this.IslemTablolari_tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmBankaKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankaKarti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBankaKarti_FormClosed);
            this.Load += new System.EventHandler(this.FrmBankaKarti_Load);
            this.IslemTablolari_tableLayoutPanel.ResumeLayout(false);
            this.hesapbilgileri_groupBox.ResumeLayout(false);
            this.hesapbilgileri_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel IslemTablolari_tableLayoutPanel;
        private System.Windows.Forms.Button Kaydet_button;
        private System.Windows.Forms.Button Sil_button;
        private System.Windows.Forms.Button Yeni_button;
        private System.Windows.Forms.Button Iptal_button;
        private System.Windows.Forms.Button Sonraki_button;
        private System.Windows.Forms.Button Onceki_button;
        private System.Windows.Forms.GroupBox hesapbilgileri_groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BankAccountHolder_textBox;
        private System.Windows.Forms.TextBox BankAccountHolderPhone_textBox;
        private System.Windows.Forms.TextBox BankBranch_textBox;
        private System.Windows.Forms.TextBox BankAccountName_textBox;
        private System.Windows.Forms.TextBox BankName_textBox;
        private System.Windows.Forms.TextBox IbanNo_textBox;
        private System.Windows.Forms.TextBox accountNo_textBox;
        private System.Windows.Forms.RichTextBox BankAccountHolderAdress_textBox;
    }
}