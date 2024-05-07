namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmCariKartlar
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
            this.CariKartlarBaslik_label = new System.Windows.Forms.Label();
            this.CariKartlar_dataGridView = new System.Windows.Forms.DataGridView();
            this.CariTürü_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKartlarBakiyeBorc_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKartlarBakiyeAlacak_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKartlarPB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Il_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilce_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCards_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.YeniEkle_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sil_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListeyiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HesapHareketleriBaslik_label = new System.Windows.Forms.Label();
            this.HesapHareketleri_dataGridView = new System.Windows.Forms.DataGridView();
            this.Tarih_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borc_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alacak_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HesapHareketleriPB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountMoventscontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniCariHareketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahsilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.satışFaturasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alışFaturasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenHavaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gidenHavaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.CariKartlar_dataGridView)).BeginInit();
            this.CurrentCards_contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HesapHareketleri_dataGridView)).BeginInit();
            this.AccountMoventscontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CariKartlarBaslik_label
            // 
            this.CariKartlarBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.CariKartlarBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CariKartlarBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CariKartlarBaslik_label.Location = new System.Drawing.Point(12, 9);
            this.CariKartlarBaslik_label.Name = "CariKartlarBaslik_label";
            this.CariKartlarBaslik_label.Size = new System.Drawing.Size(877, 21);
            this.CariKartlarBaslik_label.TabIndex = 0;
            this.CariKartlarBaslik_label.Text = "Cari Kartlar";
            this.CariKartlarBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CariKartlar_dataGridView
            // 
            this.CariKartlar_dataGridView.AllowUserToAddRows = false;
            this.CariKartlar_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CariKartlar_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CariKartlar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CariKartlar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CariKartlar_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CariKartlar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CariKartlar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CariTürü_column,
            this.CariKodu_column,
            this.CariAdi_column,
            this.CariKartlarBakiyeBorc_column,
            this.CariKartlarBakiyeAlacak_column,
            this.CariKartlarPB_column,
            this.Il_column,
            this.Ilce_column});
            this.CariKartlar_dataGridView.ContextMenuStrip = this.CurrentCards_contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CariKartlar_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CariKartlar_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.CariKartlar_dataGridView.Name = "CariKartlar_dataGridView";
            this.CariKartlar_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CariKartlar_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CariKartlar_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.CariKartlar_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CariKartlar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CariKartlar_dataGridView.Size = new System.Drawing.Size(877, 150);
            this.CariKartlar_dataGridView.TabIndex = 1;
            this.CariKartlar_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CariKartlar_dataGridView_CellClick);
            this.CariKartlar_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CariKartlar_dataGridView_CellDoubleClick);
            // 
            // CariTürü_column
            // 
            this.CariTürü_column.HeaderText = "Cari Türü";
            this.CariTürü_column.Name = "CariTürü_column";
            this.CariTürü_column.ReadOnly = true;
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
            // CariKartlarBakiyeBorc_column
            // 
            this.CariKartlarBakiyeBorc_column.HeaderText = "Bakiye Borç";
            this.CariKartlarBakiyeBorc_column.Name = "CariKartlarBakiyeBorc_column";
            this.CariKartlarBakiyeBorc_column.ReadOnly = true;
            // 
            // CariKartlarBakiyeAlacak_column
            // 
            this.CariKartlarBakiyeAlacak_column.HeaderText = "Bakiye Alacak";
            this.CariKartlarBakiyeAlacak_column.Name = "CariKartlarBakiyeAlacak_column";
            this.CariKartlarBakiyeAlacak_column.ReadOnly = true;
            // 
            // CariKartlarPB_column
            // 
            this.CariKartlarPB_column.HeaderText = "PB";
            this.CariKartlarPB_column.Name = "CariKartlarPB_column";
            this.CariKartlarPB_column.ReadOnly = true;
            // 
            // Il_column
            // 
            this.Il_column.HeaderText = "Il";
            this.Il_column.Name = "Il_column";
            this.Il_column.ReadOnly = true;
            // 
            // Ilce_column
            // 
            this.Ilce_column.HeaderText = "Ilçe";
            this.Ilce_column.Name = "Ilce_column";
            this.Ilce_column.ReadOnly = true;
            // 
            // CurrentCards_contextMenuStrip
            // 
            this.CurrentCards_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniEkle_ToolStripMenuItem,
            this.Sil_ToolStripMenuItem,
            this.ListeyiYenileToolStripMenuItem});
            this.CurrentCards_contextMenuStrip.Name = "CurrentCards_contextMenuStrip";
            this.CurrentCards_contextMenuStrip.Size = new System.Drawing.Size(143, 70);
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
            // HesapHareketleriBaslik_label
            // 
            this.HesapHareketleriBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.HesapHareketleriBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HesapHareketleriBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.HesapHareketleriBaslik_label.Location = new System.Drawing.Point(12, 186);
            this.HesapHareketleriBaslik_label.Name = "HesapHareketleriBaslik_label";
            this.HesapHareketleriBaslik_label.Size = new System.Drawing.Size(877, 21);
            this.HesapHareketleriBaslik_label.TabIndex = 2;
            this.HesapHareketleriBaslik_label.Text = "Hesap Hareketleri";
            // 
            // HesapHareketleri_dataGridView
            // 
            this.HesapHareketleri_dataGridView.AllowUserToAddRows = false;
            this.HesapHareketleri_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HesapHareketleri_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.HesapHareketleri_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HesapHareketleri_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HesapHareketleri_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.HesapHareketleri_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HesapHareketleri_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih_column,
            this.SeriNo_column,
            this.IslemTipi_column,
            this.Aciklama_column,
            this.Borc_column,
            this.Alacak_column,
            this.HesapHareketleriPB_column});
            this.HesapHareketleri_dataGridView.ContextMenuStrip = this.AccountMoventscontextMenuStrip;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HesapHareketleri_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.HesapHareketleri_dataGridView.Location = new System.Drawing.Point(12, 210);
            this.HesapHareketleri_dataGridView.Name = "HesapHareketleri_dataGridView";
            this.HesapHareketleri_dataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HesapHareketleri_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.HesapHareketleri_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HesapHareketleri_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.HesapHareketleri_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HesapHareketleri_dataGridView.Size = new System.Drawing.Size(877, 150);
            this.HesapHareketleri_dataGridView.TabIndex = 2;
            // 
            // Tarih_column
            // 
            this.Tarih_column.HeaderText = "Tarih";
            this.Tarih_column.Name = "Tarih_column";
            this.Tarih_column.ReadOnly = true;
            // 
            // SeriNo_column
            // 
            this.SeriNo_column.HeaderText = "Seri No";
            this.SeriNo_column.Name = "SeriNo_column";
            this.SeriNo_column.ReadOnly = true;
            // 
            // IslemTipi_column
            // 
            this.IslemTipi_column.HeaderText = "İşlem Tipi";
            this.IslemTipi_column.Name = "IslemTipi_column";
            this.IslemTipi_column.ReadOnly = true;
            // 
            // Aciklama_column
            // 
            this.Aciklama_column.HeaderText = "Açıklama";
            this.Aciklama_column.Name = "Aciklama_column";
            this.Aciklama_column.ReadOnly = true;
            // 
            // Borc_column
            // 
            this.Borc_column.HeaderText = "Borç";
            this.Borc_column.Name = "Borc_column";
            this.Borc_column.ReadOnly = true;
            // 
            // Alacak_column
            // 
            this.Alacak_column.HeaderText = "Alacak";
            this.Alacak_column.Name = "Alacak_column";
            this.Alacak_column.ReadOnly = true;
            // 
            // HesapHareketleriPB_column
            // 
            this.HesapHareketleriPB_column.HeaderText = "PB";
            this.HesapHareketleriPB_column.Name = "HesapHareketleriPB_column";
            this.HesapHareketleriPB_column.ReadOnly = true;
            // 
            // AccountMoventscontextMenuStrip
            // 
            this.AccountMoventscontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniCariHareketToolStripMenuItem});
            this.AccountMoventscontextMenuStrip.Name = "AccountMoventscontextMenuStrip";
            this.AccountMoventscontextMenuStrip.Size = new System.Drawing.Size(166, 48);
            // 
            // yeniCariHareketToolStripMenuItem
            // 
            this.yeniCariHareketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tahsilToolStripMenuItem,
            this.ödemeToolStripMenuItem,
            this.toolStripSeparator1,
            this.satışFaturasıToolStripMenuItem,
            this.alışFaturasıToolStripMenuItem,
            this.toolStripSeparator2,
            this.gelenHavaleToolStripMenuItem,
            this.gidenHavaleToolStripMenuItem});
            this.yeniCariHareketToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Yeni;
            this.yeniCariHareketToolStripMenuItem.Name = "yeniCariHareketToolStripMenuItem";
            this.yeniCariHareketToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.yeniCariHareketToolStripMenuItem.Text = "Yeni Cari Hareket";
            // 
            // tahsilToolStripMenuItem
            // 
            this.tahsilToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Tahsil;
            this.tahsilToolStripMenuItem.Name = "tahsilToolStripMenuItem";
            this.tahsilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tahsilToolStripMenuItem.Text = "Tahsil";
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Odeme;
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ödemeToolStripMenuItem.Text = "Ödeme";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // satışFaturasıToolStripMenuItem
            // 
            this.satışFaturasıToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.SatisFaturasi;
            this.satışFaturasıToolStripMenuItem.Name = "satışFaturasıToolStripMenuItem";
            this.satışFaturasıToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.satışFaturasıToolStripMenuItem.Text = "Satış Faturası";
            this.satışFaturasıToolStripMenuItem.Click += new System.EventHandler(this.satışFaturasıToolStripMenuItem_Click);
            // 
            // alışFaturasıToolStripMenuItem
            // 
            this.alışFaturasıToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.AlisFaturasi;
            this.alışFaturasıToolStripMenuItem.Name = "alışFaturasıToolStripMenuItem";
            this.alışFaturasıToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alışFaturasıToolStripMenuItem.Text = "Alış Faturası";
            this.alışFaturasıToolStripMenuItem.Click += new System.EventHandler(this.alışFaturasıToolStripMenuItem_Click);
            // 
            // gelenHavaleToolStripMenuItem
            // 
            this.gelenHavaleToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.in_ico_32x32;
            this.gelenHavaleToolStripMenuItem.Name = "gelenHavaleToolStripMenuItem";
            this.gelenHavaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gelenHavaleToolStripMenuItem.Text = "Gelen Havale";
            this.gelenHavaleToolStripMenuItem.Click += new System.EventHandler(this.gelenHavaleToolStripMenuItem_Click);
            // 
            // gidenHavaleToolStripMenuItem
            // 
            this.gidenHavaleToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.up1;
            this.gidenHavaleToolStripMenuItem.Name = "gidenHavaleToolStripMenuItem";
            this.gidenHavaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gidenHavaleToolStripMenuItem.Text = "Giden Havale";
            this.gidenHavaleToolStripMenuItem.Click += new System.EventHandler(this.gidenHavaleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // FrmCariKartlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 408);
            this.Controls.Add(this.HesapHareketleri_dataGridView);
            this.Controls.Add(this.HesapHareketleriBaslik_label);
            this.Controls.Add(this.CariKartlar_dataGridView);
            this.Controls.Add(this.CariKartlarBaslik_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCariKartlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmCariKartlar";
            this.Load += new System.EventHandler(this.FrmCariKartlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CariKartlar_dataGridView)).EndInit();
            this.CurrentCards_contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HesapHareketleri_dataGridView)).EndInit();
            this.AccountMoventscontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CariKartlarBaslik_label;
        private System.Windows.Forms.Label HesapHareketleriBaslik_label;
        private System.Windows.Forms.DataGridView HesapHareketleri_dataGridView;
        private System.Windows.Forms.ContextMenuStrip CurrentCards_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem YeniEkle_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sil_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListeyiYenileToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTürü_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKartlarBakiyeBorc_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKartlarBakiyeAlacak_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKartlarPB_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Il_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilce_column;
        public System.Windows.Forms.DataGridView CariKartlar_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borc_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alacak_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapHareketleriPB_column;
        private System.Windows.Forms.ContextMenuStrip AccountMoventscontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem yeniCariHareketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahsilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem satışFaturasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alışFaturasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelenHavaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gidenHavaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}