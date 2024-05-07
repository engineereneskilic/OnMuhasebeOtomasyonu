namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmBankalar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BankalarBaslik_label = new System.Windows.Forms.Label();
            this.bankalar_dataGridView = new System.Windows.Forms.DataGridView();
            this.Sira_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HesapNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaHesapAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaBakiyesi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaBirimi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaIslemleriBaslik_label = new System.Windows.Forms.Label();
            this.BankaIslemleri_dataGridView = new System.Windows.Forms.DataGridView();
            this.IslemTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorcTahsilEdilen_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlacakOdenen_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masraf_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.YeniEkle_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sil_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListeyiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bankalar_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaIslemleri_dataGridView)).BeginInit();
            this.bank_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BankalarBaslik_label
            // 
            this.BankalarBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.BankalarBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BankalarBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BankalarBaslik_label.Location = new System.Drawing.Point(12, 9);
            this.BankalarBaslik_label.Name = "BankalarBaslik_label";
            this.BankalarBaslik_label.Size = new System.Drawing.Size(877, 21);
            this.BankalarBaslik_label.TabIndex = 0;
            this.BankalarBaslik_label.Text = "Bankalar";
            this.BankalarBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bankalar_dataGridView
            // 
            this.bankalar_dataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bankalar_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bankalar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bankalar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bankalar_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bankalar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankalar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira_column,
            this.HesapNo_column,
            this.BankaAdi_column,
            this.BankaHesapAdi_column,
            this.BankaBakiyesi_column,
            this.ParaBirimi_column});
            this.bankalar_dataGridView.ContextMenuStrip = this.bank_contextMenuStrip;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bankalar_dataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.bankalar_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.bankalar_dataGridView.Name = "bankalar_dataGridView";
            this.bankalar_dataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bankalar_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.bankalar_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bankalar_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.bankalar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bankalar_dataGridView.Size = new System.Drawing.Size(877, 150);
            this.bankalar_dataGridView.TabIndex = 1;
            this.bankalar_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bankalar_dataGridView_CellClick);
            this.bankalar_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bankalar_dataGridView_CellDoubleClick);
            // 
            // Sira_column
            // 
            this.Sira_column.HeaderText = "Sıra";
            this.Sira_column.Name = "Sira_column";
            this.Sira_column.ReadOnly = true;
            // 
            // HesapNo_column
            // 
            this.HesapNo_column.HeaderText = "Hesap No";
            this.HesapNo_column.Name = "HesapNo_column";
            this.HesapNo_column.ReadOnly = true;
            // 
            // BankaAdi_column
            // 
            this.BankaAdi_column.HeaderText = "Banka Adı";
            this.BankaAdi_column.Name = "BankaAdi_column";
            this.BankaAdi_column.ReadOnly = true;
            // 
            // BankaHesapAdi_column
            // 
            this.BankaHesapAdi_column.HeaderText = "Banka Hesap Adı";
            this.BankaHesapAdi_column.Name = "BankaHesapAdi_column";
            this.BankaHesapAdi_column.ReadOnly = true;
            // 
            // BankaBakiyesi_column
            // 
            this.BankaBakiyesi_column.HeaderText = "Banka Bakiyesi";
            this.BankaBakiyesi_column.Name = "BankaBakiyesi_column";
            this.BankaBakiyesi_column.ReadOnly = true;
            // 
            // ParaBirimi_column
            // 
            this.ParaBirimi_column.HeaderText = "Para Birimi";
            this.ParaBirimi_column.Name = "ParaBirimi_column";
            this.ParaBirimi_column.ReadOnly = true;
            // 
            // BankaIslemleriBaslik_label
            // 
            this.BankaIslemleriBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.BankaIslemleriBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BankaIslemleriBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.BankaIslemleriBaslik_label.Location = new System.Drawing.Point(12, 186);
            this.BankaIslemleriBaslik_label.Name = "BankaIslemleriBaslik_label";
            this.BankaIslemleriBaslik_label.Size = new System.Drawing.Size(877, 21);
            this.BankaIslemleriBaslik_label.TabIndex = 2;
            this.BankaIslemleriBaslik_label.Text = "Banka İşlemleri";
            this.BankaIslemleriBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BankaIslemleri_dataGridView
            // 
            this.BankaIslemleri_dataGridView.AllowUserToAddRows = false;
            this.BankaIslemleri_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BankaIslemleri_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BankaIslemleri_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankaIslemleri_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BankaIslemleri_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BankaIslemleri_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankaIslemleri_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IslemTipi_column,
            this.Tarih_column,
            this.CariAdi_column,
            this.Aciklama_column,
            this.BorcTahsilEdilen_column,
            this.AlacakOdenen_column,
            this.Masraf_column,
            this.PB_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BankaIslemleri_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BankaIslemleri_dataGridView.Location = new System.Drawing.Point(12, 210);
            this.BankaIslemleri_dataGridView.Name = "BankaIslemleri_dataGridView";
            this.BankaIslemleri_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BankaIslemleri_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BankaIslemleri_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BankaIslemleri_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BankaIslemleri_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BankaIslemleri_dataGridView.Size = new System.Drawing.Size(877, 150);
            this.BankaIslemleri_dataGridView.TabIndex = 3;
            // 
            // IslemTipi_column
            // 
            this.IslemTipi_column.HeaderText = "İşlem Tipi";
            this.IslemTipi_column.Name = "IslemTipi_column";
            this.IslemTipi_column.ReadOnly = true;
            // 
            // Tarih_column
            // 
            this.Tarih_column.HeaderText = "Tarih";
            this.Tarih_column.Name = "Tarih_column";
            this.Tarih_column.ReadOnly = true;
            // 
            // CariAdi_column
            // 
            this.CariAdi_column.HeaderText = "Cari Adı";
            this.CariAdi_column.Name = "CariAdi_column";
            this.CariAdi_column.ReadOnly = true;
            // 
            // Aciklama_column
            // 
            this.Aciklama_column.HeaderText = "Açıklama";
            this.Aciklama_column.Name = "Aciklama_column";
            this.Aciklama_column.ReadOnly = true;
            // 
            // BorcTahsilEdilen_column
            // 
            this.BorcTahsilEdilen_column.HeaderText = "BORÇ (Tahsil Edilen)";
            this.BorcTahsilEdilen_column.Name = "BorcTahsilEdilen_column";
            this.BorcTahsilEdilen_column.ReadOnly = true;
            // 
            // AlacakOdenen_column
            // 
            this.AlacakOdenen_column.HeaderText = "Alacak (Ödenen)";
            this.AlacakOdenen_column.Name = "AlacakOdenen_column";
            this.AlacakOdenen_column.ReadOnly = true;
            // 
            // Masraf_column
            // 
            this.Masraf_column.HeaderText = "Masraf";
            this.Masraf_column.Name = "Masraf_column";
            this.Masraf_column.ReadOnly = true;
            // 
            // PB_column
            // 
            this.PB_column.HeaderText = "PB";
            this.PB_column.Name = "PB_column";
            this.PB_column.ReadOnly = true;
            // 
            // bank_contextMenuStrip
            // 
            this.bank_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniEkle_ToolStripMenuItem,
            this.Sil_ToolStripMenuItem,
            this.ListeyiYenileToolStripMenuItem});
            this.bank_contextMenuStrip.Name = "CurrentCards_contextMenuStrip";
            this.bank_contextMenuStrip.Size = new System.Drawing.Size(143, 70);
            // 
            // YeniEkle_ToolStripMenuItem
            // 
            this.YeniEkle_ToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Yeni;
            this.YeniEkle_ToolStripMenuItem.Name = "YeniEkle_ToolStripMenuItem";
            this.YeniEkle_ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.YeniEkle_ToolStripMenuItem.Text = "Yeni Ekle";
            this.YeniEkle_ToolStripMenuItem.Click += new System.EventHandler(this.YeniEkle_ToolStripMenuItem_Click);
            // 
            // Sil_ToolStripMenuItem
            // 
            this.Sil_ToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Sil;
            this.Sil_ToolStripMenuItem.Name = "Sil_ToolStripMenuItem";
            this.Sil_ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.Sil_ToolStripMenuItem.Text = "Sil";
            this.Sil_ToolStripMenuItem.Click += new System.EventHandler(this.Sil_ToolStripMenuItem_Click);
            // 
            // ListeyiYenileToolStripMenuItem
            // 
            this.ListeyiYenileToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.yenile;
            this.ListeyiYenileToolStripMenuItem.Name = "ListeyiYenileToolStripMenuItem";
            this.ListeyiYenileToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ListeyiYenileToolStripMenuItem.Text = "Listeyi Yenile";
            this.ListeyiYenileToolStripMenuItem.Click += new System.EventHandler(this.ListeyiYenileToolStripMenuItem_Click);
            // 
            // FrmBankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 408);
            this.Controls.Add(this.BankaIslemleri_dataGridView);
            this.Controls.Add(this.BankaIslemleriBaslik_label);
            this.Controls.Add(this.bankalar_dataGridView);
            this.Controls.Add(this.BankalarBaslik_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmBankalar";
            this.Load += new System.EventHandler(this.FrmBankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankalar_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaIslemleri_dataGridView)).EndInit();
            this.bank_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BankalarBaslik_label;
        private System.Windows.Forms.Label BankaIslemleriBaslik_label;
        private System.Windows.Forms.DataGridView BankaIslemleri_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorcTahsilEdilen_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlacakOdenen_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masraf_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PB_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaHesapAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaBakiyesi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaBirimi_column;
        public System.Windows.Forms.DataGridView bankalar_dataGridView;
        private System.Windows.Forms.ContextMenuStrip bank_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem YeniEkle_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sil_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListeyiYenileToolStripMenuItem;
    }
}