namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmStoklar
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
            this.StoklarBaslik_label = new System.Windows.Forms.Label();
            this.Stoklar_dataGridView = new System.Windows.Forms.DataGridView();
            this.Stock_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.YeniEkle_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sil_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListeyiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StokHareketleriBaslik_label = new System.Windows.Forms.Label();
            this.StokHareketleri_dataGridView = new System.Windows.Forms.DataGridView();
            this.IslemTarihi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giren_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cikan_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indirim_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokTuru_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokKodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mevcut_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiyatA_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiyatB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnvanterEderi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Stoklar_dataGridView)).BeginInit();
            this.Stock_contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StokHareketleri_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StoklarBaslik_label
            // 
            this.StoklarBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.StoklarBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StoklarBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.StoklarBaslik_label.Location = new System.Drawing.Point(12, 9);
            this.StoklarBaslik_label.Name = "StoklarBaslik_label";
            this.StoklarBaslik_label.Size = new System.Drawing.Size(877, 21);
            this.StoklarBaslik_label.TabIndex = 0;
            this.StoklarBaslik_label.Text = "Stoklar";
            this.StoklarBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Stoklar_dataGridView
            // 
            this.Stoklar_dataGridView.AllowUserToAddRows = false;
            this.Stoklar_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Stoklar_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Stoklar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Stoklar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stoklar_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Stoklar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stoklar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokTuru_column,
            this.StokKodu_column,
            this.StokAdi_column,
            this.Mevcut_column,
            this.Birim_column,
            this.FiyatA_column,
            this.FiyatB_column,
            this.EnvanterEderi_column});
            this.Stoklar_dataGridView.ContextMenuStrip = this.Stock_contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Stoklar_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Stoklar_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.Stoklar_dataGridView.Name = "Stoklar_dataGridView";
            this.Stoklar_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stoklar_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Stoklar_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Stoklar_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Stoklar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Stoklar_dataGridView.Size = new System.Drawing.Size(877, 150);
            this.Stoklar_dataGridView.TabIndex = 1;
            this.Stoklar_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stoklar_dataGridView_CellClick);
            this.Stoklar_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stoklar_dataGridView_CellDoubleClick);
            // 
            // Stock_contextMenuStrip
            // 
            this.Stock_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniEkle_ToolStripMenuItem,
            this.Sil_ToolStripMenuItem,
            this.ListeyiYenileToolStripMenuItem});
            this.Stock_contextMenuStrip.Name = "CurrentCards_contextMenuStrip";
            this.Stock_contextMenuStrip.Size = new System.Drawing.Size(143, 70);
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
            // StokHareketleriBaslik_label
            // 
            this.StokHareketleriBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.StokHareketleriBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StokHareketleriBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.StokHareketleriBaslik_label.Location = new System.Drawing.Point(12, 186);
            this.StokHareketleriBaslik_label.Name = "StokHareketleriBaslik_label";
            this.StokHareketleriBaslik_label.Size = new System.Drawing.Size(877, 21);
            this.StokHareketleriBaslik_label.TabIndex = 2;
            this.StokHareketleriBaslik_label.Text = "Stok Hareketleri";
            this.StokHareketleriBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StokHareketleri_dataGridView
            // 
            this.StokHareketleri_dataGridView.AllowUserToAddRows = false;
            this.StokHareketleri_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StokHareketleri_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.StokHareketleri_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StokHareketleri_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StokHareketleri_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.StokHareketleri_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StokHareketleri_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IslemTarihi_column,
            this.IslemTipi_column,
            this.CariKodu_column,
            this.CariAdi_column,
            this.Giren_column,
            this.Cikan_column,
            this.BirimFiyat_column,
            this.ToplamTutar_column,
            this.Indirim_column,
            this.FaturaNo_column});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StokHareketleri_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.StokHareketleri_dataGridView.Location = new System.Drawing.Point(12, 210);
            this.StokHareketleri_dataGridView.Name = "StokHareketleri_dataGridView";
            this.StokHareketleri_dataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StokHareketleri_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.StokHareketleri_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StokHareketleri_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.StokHareketleri_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StokHareketleri_dataGridView.Size = new System.Drawing.Size(877, 150);
            this.StokHareketleri_dataGridView.TabIndex = 3;
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
            // CariKodu_column
            // 
            this.CariKodu_column.HeaderText = "Cari Kodu";
            this.CariKodu_column.Name = "CariKodu_column";
            this.CariKodu_column.ReadOnly = true;
            // 
            // CariAdi_column
            // 
            this.CariAdi_column.HeaderText = "Cari Adı";
            this.CariAdi_column.Name = "CariAdi_column";
            this.CariAdi_column.ReadOnly = true;
            // 
            // Giren_column
            // 
            this.Giren_column.HeaderText = "GIREN +";
            this.Giren_column.Name = "Giren_column";
            this.Giren_column.ReadOnly = true;
            // 
            // Cikan_column
            // 
            this.Cikan_column.HeaderText = "CIKAN -";
            this.Cikan_column.Name = "Cikan_column";
            this.Cikan_column.ReadOnly = true;
            // 
            // BirimFiyat_column
            // 
            this.BirimFiyat_column.HeaderText = "Birim Fiyat";
            this.BirimFiyat_column.Name = "BirimFiyat_column";
            this.BirimFiyat_column.ReadOnly = true;
            // 
            // ToplamTutar_column
            // 
            this.ToplamTutar_column.HeaderText = "Toplam Tutar";
            this.ToplamTutar_column.Name = "ToplamTutar_column";
            this.ToplamTutar_column.ReadOnly = true;
            // 
            // Indirim_column
            // 
            this.Indirim_column.HeaderText = "İndirim";
            this.Indirim_column.Name = "Indirim_column";
            this.Indirim_column.ReadOnly = true;
            // 
            // FaturaNo_column
            // 
            this.FaturaNo_column.HeaderText = "Fatura No";
            this.FaturaNo_column.Name = "FaturaNo_column";
            this.FaturaNo_column.ReadOnly = true;
            // 
            // StokTuru_column
            // 
            this.StokTuru_column.HeaderText = "Stok Türü";
            this.StokTuru_column.Name = "StokTuru_column";
            this.StokTuru_column.ReadOnly = true;
            // 
            // StokKodu_column
            // 
            this.StokKodu_column.HeaderText = "Stok Kodu";
            this.StokKodu_column.Name = "StokKodu_column";
            this.StokKodu_column.ReadOnly = true;
            // 
            // StokAdi_column
            // 
            this.StokAdi_column.HeaderText = "Stok Adı";
            this.StokAdi_column.Name = "StokAdi_column";
            this.StokAdi_column.ReadOnly = true;
            // 
            // Mevcut_column
            // 
            this.Mevcut_column.HeaderText = "Mevcut";
            this.Mevcut_column.Name = "Mevcut_column";
            this.Mevcut_column.ReadOnly = true;
            // 
            // Birim_column
            // 
            this.Birim_column.HeaderText = "Birim";
            this.Birim_column.Name = "Birim_column";
            this.Birim_column.ReadOnly = true;
            // 
            // FiyatA_column
            // 
            this.FiyatA_column.HeaderText = "I.Br.Satış Fiyatı";
            this.FiyatA_column.Name = "FiyatA_column";
            this.FiyatA_column.ReadOnly = true;
            // 
            // FiyatB_column
            // 
            this.FiyatB_column.HeaderText = "II.Br.Satış Fiyatı";
            this.FiyatB_column.Name = "FiyatB_column";
            this.FiyatB_column.ReadOnly = true;
            // 
            // EnvanterEderi_column
            // 
            this.EnvanterEderi_column.HeaderText = "Envanter Ederi";
            this.EnvanterEderi_column.Name = "EnvanterEderi_column";
            this.EnvanterEderi_column.ReadOnly = true;
            // 
            // FrmStoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 408);
            this.Controls.Add(this.StokHareketleri_dataGridView);
            this.Controls.Add(this.StokHareketleriBaslik_label);
            this.Controls.Add(this.Stoklar_dataGridView);
            this.Controls.Add(this.StoklarBaslik_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStoklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmStoklar";
            this.Load += new System.EventHandler(this.FrmStoklar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stoklar_dataGridView)).EndInit();
            this.Stock_contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StokHareketleri_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StoklarBaslik_label;
        private System.Windows.Forms.Label StokHareketleriBaslik_label;
        private System.Windows.Forms.DataGridView StokHareketleri_dataGridView;
        private System.Windows.Forms.ContextMenuStrip Stock_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem YeniEkle_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sil_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListeyiYenileToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTarihi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giren_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cikan_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamTutar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indirim_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokTuru_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokKodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mevcut_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiyatA_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiyatB_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnvanterEderi_column;
        public System.Windows.Forms.DataGridView Stoklar_dataGridView;
    }
}