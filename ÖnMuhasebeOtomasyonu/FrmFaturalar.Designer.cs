namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmFaturalar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FaturalarBaslik_label = new System.Windows.Forms.Label();
            this.Faturalar_dataGridView = new System.Windows.Forms.DataGridView();
            this.IslemTarihi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetBorc_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAlacak_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturalarPB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturalarIndirim_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masraf_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donem_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.YeniEkle_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alışFaturasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışFaturasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sil_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListeyiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FaturaDetayiBaslik_label = new System.Windows.Forms.Label();
            this.FaturaDetaylari_dataGridView = new System.Windows.Forms.DataGridView();
            this.SatırTuru_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birimi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirenMiktar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikanMiktar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kdv_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaDetayiIndirim_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaDetayiPB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Faturalar_dataGridView)).BeginInit();
            this.bill_contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FaturaDetaylari_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FaturalarBaslik_label
            // 
            this.FaturalarBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.FaturalarBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FaturalarBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FaturalarBaslik_label.Location = new System.Drawing.Point(12, 9);
            this.FaturalarBaslik_label.Name = "FaturalarBaslik_label";
            this.FaturalarBaslik_label.Size = new System.Drawing.Size(891, 21);
            this.FaturalarBaslik_label.TabIndex = 0;
            this.FaturalarBaslik_label.Text = "Faturalar";
            this.FaturalarBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Faturalar_dataGridView
            // 
            this.Faturalar_dataGridView.AllowUserToAddRows = false;
            this.Faturalar_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Faturalar_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Faturalar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Faturalar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Faturalar_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Faturalar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Faturalar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IslemTarihi_column,
            this.IslemTipi_column,
            this.FaturaNo_column,
            this.CariAdi_column,
            this.NetBorc_column,
            this.NetAlacak_column,
            this.FaturalarPB_column,
            this.FaturalarIndirim_column,
            this.Masraf_column,
            this.Donem_column});
            this.Faturalar_dataGridView.ContextMenuStrip = this.bill_contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Faturalar_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Faturalar_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.Faturalar_dataGridView.Name = "Faturalar_dataGridView";
            this.Faturalar_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Faturalar_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Faturalar_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Faturalar_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Faturalar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Faturalar_dataGridView.Size = new System.Drawing.Size(891, 150);
            this.Faturalar_dataGridView.TabIndex = 1;
            this.Faturalar_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Faturalar_dataGridView_CellClick);
            this.Faturalar_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Faturalar_dataGridView_CellDoubleClick);
            // 
            // IslemTarihi_column
            // 
            this.IslemTarihi_column.HeaderText = "İşlem Tarihi";
            this.IslemTarihi_column.Name = "IslemTarihi_column";
            this.IslemTarihi_column.ReadOnly = true;
            // 
            // IslemTipi_column
            // 
            this.IslemTipi_column.HeaderText = "İşlem Tipi";
            this.IslemTipi_column.Name = "IslemTipi_column";
            this.IslemTipi_column.ReadOnly = true;
            // 
            // FaturaNo_column
            // 
            this.FaturaNo_column.HeaderText = "Fatura No";
            this.FaturaNo_column.Name = "FaturaNo_column";
            this.FaturaNo_column.ReadOnly = true;
            // 
            // CariAdi_column
            // 
            this.CariAdi_column.HeaderText = "Cari Adı";
            this.CariAdi_column.Name = "CariAdi_column";
            this.CariAdi_column.ReadOnly = true;
            // 
            // NetBorc_column
            // 
            this.NetBorc_column.HeaderText = "Net Borç";
            this.NetBorc_column.Name = "NetBorc_column";
            this.NetBorc_column.ReadOnly = true;
            // 
            // NetAlacak_column
            // 
            this.NetAlacak_column.HeaderText = "Net Alacak";
            this.NetAlacak_column.Name = "NetAlacak_column";
            this.NetAlacak_column.ReadOnly = true;
            // 
            // FaturalarPB_column
            // 
            this.FaturalarPB_column.HeaderText = "PB";
            this.FaturalarPB_column.Name = "FaturalarPB_column";
            this.FaturalarPB_column.ReadOnly = true;
            // 
            // FaturalarIndirim_column
            // 
            this.FaturalarIndirim_column.HeaderText = "İndirim";
            this.FaturalarIndirim_column.Name = "FaturalarIndirim_column";
            this.FaturalarIndirim_column.ReadOnly = true;
            // 
            // Masraf_column
            // 
            this.Masraf_column.HeaderText = "Masraf";
            this.Masraf_column.Name = "Masraf_column";
            this.Masraf_column.ReadOnly = true;
            // 
            // Donem_column
            // 
            this.Donem_column.HeaderText = "Dönem";
            this.Donem_column.Name = "Donem_column";
            this.Donem_column.ReadOnly = true;
            // 
            // bill_contextMenuStrip
            // 
            this.bill_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniEkle_ToolStripMenuItem,
            this.Sil_ToolStripMenuItem,
            this.ListeyiYenileToolStripMenuItem});
            this.bill_contextMenuStrip.Name = "CurrentCards_contextMenuStrip";
            this.bill_contextMenuStrip.Size = new System.Drawing.Size(143, 70);
            // 
            // YeniEkle_ToolStripMenuItem
            // 
            this.YeniEkle_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alışFaturasıToolStripMenuItem,
            this.satışFaturasıToolStripMenuItem});
            this.YeniEkle_ToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Yeni;
            this.YeniEkle_ToolStripMenuItem.Name = "YeniEkle_ToolStripMenuItem";
            this.YeniEkle_ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.YeniEkle_ToolStripMenuItem.Text = "Yeni Ekle";
            // 
            // alışFaturasıToolStripMenuItem
            // 
            this.alışFaturasıToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.AlisFaturasi;
            this.alışFaturasıToolStripMenuItem.Name = "alışFaturasıToolStripMenuItem";
            this.alışFaturasıToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.alışFaturasıToolStripMenuItem.Text = "Alış Faturası";
            this.alışFaturasıToolStripMenuItem.Click += new System.EventHandler(this.alışFaturasıToolStripMenuItem_Click);
            // 
            // satışFaturasıToolStripMenuItem
            // 
            this.satışFaturasıToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.SatisFaturasi;
            this.satışFaturasıToolStripMenuItem.Name = "satışFaturasıToolStripMenuItem";
            this.satışFaturasıToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.satışFaturasıToolStripMenuItem.Text = "Satış Faturası";
            this.satışFaturasıToolStripMenuItem.Click += new System.EventHandler(this.satışFaturasıToolStripMenuItem_Click);
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
            // FaturaDetayiBaslik_label
            // 
            this.FaturaDetayiBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.FaturaDetayiBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FaturaDetayiBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FaturaDetayiBaslik_label.Location = new System.Drawing.Point(12, 186);
            this.FaturaDetayiBaslik_label.Name = "FaturaDetayiBaslik_label";
            this.FaturaDetayiBaslik_label.Size = new System.Drawing.Size(891, 21);
            this.FaturaDetayiBaslik_label.TabIndex = 2;
            this.FaturaDetayiBaslik_label.Text = "Fatura Detayı";
            this.FaturaDetayiBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FaturaDetaylari_dataGridView
            // 
            this.FaturaDetaylari_dataGridView.AllowUserToAddRows = false;
            this.FaturaDetaylari_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FaturaDetaylari_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.FaturaDetaylari_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FaturaDetaylari_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.FaturaDetaylari_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FaturaDetaylari_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatırTuru_column,
            this.Kodu_column,
            this.Aciklama_column,
            this.Birimi_column,
            this.GirenMiktar_column,
            this.CikanMiktar_column,
            this.BirimFiyat_column,
            this.ToplamTutar_column,
            this.Kdv_column,
            this.FaturaDetayiIndirim_column,
            this.FaturaDetayiPB_column});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FaturaDetaylari_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.FaturaDetaylari_dataGridView.Location = new System.Drawing.Point(12, 210);
            this.FaturaDetaylari_dataGridView.Name = "FaturaDetaylari_dataGridView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FaturaDetaylari_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.FaturaDetaylari_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FaturaDetaylari_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.FaturaDetaylari_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FaturaDetaylari_dataGridView.Size = new System.Drawing.Size(891, 150);
            this.FaturaDetaylari_dataGridView.TabIndex = 3;
            // 
            // SatırTuru_column
            // 
            this.SatırTuru_column.HeaderText = "Satır Türü";
            this.SatırTuru_column.Name = "SatırTuru_column";
            // 
            // Kodu_column
            // 
            this.Kodu_column.HeaderText = "Kodu";
            this.Kodu_column.Name = "Kodu_column";
            // 
            // Aciklama_column
            // 
            this.Aciklama_column.HeaderText = "Açıklama";
            this.Aciklama_column.Name = "Aciklama_column";
            // 
            // Birimi_column
            // 
            this.Birimi_column.HeaderText = "Birimi";
            this.Birimi_column.Name = "Birimi_column";
            // 
            // GirenMiktar_column
            // 
            this.GirenMiktar_column.HeaderText = "Giren Miktar";
            this.GirenMiktar_column.Name = "GirenMiktar_column";
            // 
            // CikanMiktar_column
            // 
            this.CikanMiktar_column.HeaderText = "Çıkan Miktar";
            this.CikanMiktar_column.Name = "CikanMiktar_column";
            // 
            // BirimFiyat_column
            // 
            this.BirimFiyat_column.HeaderText = "Birim Fiyat";
            this.BirimFiyat_column.Name = "BirimFiyat_column";
            // 
            // ToplamTutar_column
            // 
            this.ToplamTutar_column.HeaderText = "Toplam Tutar";
            this.ToplamTutar_column.Name = "ToplamTutar_column";
            // 
            // Kdv_column
            // 
            this.Kdv_column.HeaderText = "+ KDV";
            this.Kdv_column.Name = "Kdv_column";
            // 
            // FaturaDetayiIndirim_column
            // 
            this.FaturaDetayiIndirim_column.HeaderText = "- İndirim";
            this.FaturaDetayiIndirim_column.Name = "FaturaDetayiIndirim_column";
            // 
            // FaturaDetayiPB_column
            // 
            this.FaturaDetayiPB_column.HeaderText = "PB";
            this.FaturaDetayiPB_column.Name = "FaturaDetayiPB_column";
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 408);
            this.Controls.Add(this.FaturaDetaylari_dataGridView);
            this.Controls.Add(this.FaturaDetayiBaslik_label);
            this.Controls.Add(this.Faturalar_dataGridView);
            this.Controls.Add(this.FaturalarBaslik_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFaturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmFaturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Faturalar_dataGridView)).EndInit();
            this.bill_contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FaturaDetaylari_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FaturalarBaslik_label;
        private System.Windows.Forms.Label FaturaDetayiBaslik_label;
        private System.Windows.Forms.DataGridView FaturaDetaylari_dataGridView;
        private System.Windows.Forms.ContextMenuStrip bill_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem YeniEkle_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sil_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListeyiYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alışFaturasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışFaturasıToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTarihi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetBorc_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAlacak_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturalarPB_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturalarIndirim_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masraf_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donem_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatırTuru_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birimi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirenMiktar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikanMiktar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamTutar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kdv_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaDetayiIndirim_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaDetayiPB_column;
        public System.Windows.Forms.DataGridView Faturalar_dataGridView;
    }
}