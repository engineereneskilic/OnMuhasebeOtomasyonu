namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmCariAcilir
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Iptal_button = new System.Windows.Forms.Button();
            this.choose_button = new System.Windows.Forms.Button();
            this.yeni_ekle_button = new System.Windows.Forms.Button();
            this.CariKartlar_dataGridView = new System.Windows.Forms.DataGridView();
            this.CariTürü_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKartlarBakiyeBorc_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKartlarBakiyeAlacak_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeni_ekle_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeyiYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CariKartlar_dataGridView)).BeginInit();
            this.yeni_ekle_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.Iptal_button, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.choose_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.yeni_ekle_button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-6, 225);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 36);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Iptal_button
            // 
            this.Iptal_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.İptal;
            this.Iptal_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Iptal_button.Location = new System.Drawing.Point(619, 5);
            this.Iptal_button.Name = "Iptal_button";
            this.Iptal_button.Size = new System.Drawing.Size(89, 25);
            this.Iptal_button.TabIndex = 6;
            this.Iptal_button.Text = "     İptal";
            this.Iptal_button.UseVisualStyleBackColor = true;
            this.Iptal_button.Click += new System.EventHandler(this.Iptal_button_Click);
            // 
            // choose_button
            // 
            this.choose_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.choose_button.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Kaydett;
            this.choose_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.choose_button.Location = new System.Drawing.Point(522, 5);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(89, 25);
            this.choose_button.TabIndex = 5;
            this.choose_button.Text = "       Seç";
            this.choose_button.UseVisualStyleBackColor = true;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // yeni_ekle_button
            // 
            this.yeni_ekle_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yeni_ekle_button.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Yeni;
            this.yeni_ekle_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yeni_ekle_button.Location = new System.Drawing.Point(427, 5);
            this.yeni_ekle_button.Name = "yeni_ekle_button";
            this.yeni_ekle_button.Size = new System.Drawing.Size(87, 25);
            this.yeni_ekle_button.TabIndex = 7;
            this.yeni_ekle_button.Text = "Yeni Ekle";
            this.yeni_ekle_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yeni_ekle_button.UseVisualStyleBackColor = true;
            this.yeni_ekle_button.Click += new System.EventHandler(this.yeni_ekle_button_Click);
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
            this.CariKartlarBakiyeAlacak_column});
            this.CariKartlar_dataGridView.ContextMenuStrip = this.yeni_ekle_contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CariKartlar_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CariKartlar_dataGridView.Location = new System.Drawing.Point(-6, 0);
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
            this.CariKartlar_dataGridView.Size = new System.Drawing.Size(722, 224);
            this.CariKartlar_dataGridView.TabIndex = 7;
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
            // yeni_ekle_contextMenuStrip
            // 
            this.yeni_ekle_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniEkleToolStripMenuItem,
            this.listeyiYenileToolStripMenuItem});
            this.yeni_ekle_contextMenuStrip.Name = "yeni_ekle_contextMenuStrip";
            this.yeni_ekle_contextMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // yeniEkleToolStripMenuItem
            // 
            this.yeniEkleToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Yeni;
            this.yeniEkleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yeniEkleToolStripMenuItem.Name = "yeniEkleToolStripMenuItem";
            this.yeniEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yeniEkleToolStripMenuItem.Text = "Yeni Ekle";
            this.yeniEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniEkleToolStripMenuItem_Click);
            // 
            // listeyiYenileToolStripMenuItem
            // 
            this.listeyiYenileToolStripMenuItem.Image = global::ÖnMuhasebeOtomasyonu.Properties.Resources.yenile;
            this.listeyiYenileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listeyiYenileToolStripMenuItem.Name = "listeyiYenileToolStripMenuItem";
            this.listeyiYenileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listeyiYenileToolStripMenuItem.Text = "Listeyi Yenile";
            this.listeyiYenileToolStripMenuItem.Click += new System.EventHandler(this.listeyiYenileToolStripMenuItem_Click);
            // 
            // FrmCariAcilir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(716, 263);
            this.Controls.Add(this.CariKartlar_dataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmCariAcilir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Kart Listesi";
            this.Load += new System.EventHandler(this.FrmCariAcilir_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CariKartlar_dataGridView)).EndInit();
            this.yeni_ekle_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choose_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Iptal_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTürü_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKartlarBakiyeBorc_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKartlarBakiyeAlacak_column;
        private System.Windows.Forms.Button yeni_ekle_button;
        private System.Windows.Forms.ContextMenuStrip yeni_ekle_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem yeniEkleToolStripMenuItem;
        public System.Windows.Forms.DataGridView CariKartlar_dataGridView;
        private System.Windows.Forms.ToolStripMenuItem listeyiYenileToolStripMenuItem;
    }
}