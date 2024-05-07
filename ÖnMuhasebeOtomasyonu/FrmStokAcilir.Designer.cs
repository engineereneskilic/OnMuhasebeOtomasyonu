namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmStokAcilir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Stoklar_dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Iptal_button = new System.Windows.Forms.Button();
            this.choose_button = new System.Windows.Forms.Button();
            this.StokTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokKodu_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAdi_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mevcut_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyatı_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Stoklar_dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stoklar_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Stoklar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stoklar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StokTipi_column,
            this.StokKodu_Column,
            this.StockAdi_Column,
            this.Mevcut_Column,
            this.Birim_column,
            this.BirimFiyatı_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Stoklar_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Stoklar_dataGridView.Location = new System.Drawing.Point(-3, -1);
            this.Stoklar_dataGridView.Name = "Stoklar_dataGridView";
            this.Stoklar_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stoklar_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Stoklar_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.Stoklar_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Stoklar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Stoklar_dataGridView.Size = new System.Drawing.Size(722, 224);
            this.Stoklar_dataGridView.TabIndex = 9;
            this.Stoklar_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stoklar_dataGridView_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 488F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Controls.Add(this.Iptal_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.choose_button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 224);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 36);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Iptal_button
            // 
            this.Iptal_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.İptal;
            this.Iptal_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Iptal_button.Location = new System.Drawing.Point(593, 5);
            this.Iptal_button.Name = "Iptal_button";
            this.Iptal_button.Size = new System.Drawing.Size(89, 25);
            this.Iptal_button.TabIndex = 6;
            this.Iptal_button.Text = "     İptal";
            this.Iptal_button.UseVisualStyleBackColor = true;
            this.Iptal_button.Click += new System.EventHandler(this.Iptal_button_Click);
            // 
            // choose_button
            // 
            this.choose_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Kaydett;
            this.choose_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.choose_button.Location = new System.Drawing.Point(495, 5);
            this.choose_button.Name = "choose_button";
            this.choose_button.Size = new System.Drawing.Size(90, 25);
            this.choose_button.TabIndex = 5;
            this.choose_button.Text = "       Seç";
            this.choose_button.UseVisualStyleBackColor = true;
            this.choose_button.Click += new System.EventHandler(this.choose_button_Click);
            // 
            // StokTipi_column
            // 
            this.StokTipi_column.HeaderText = "Stok Tipi";
            this.StokTipi_column.Name = "StokTipi_column";
            this.StokTipi_column.ReadOnly = true;
            // 
            // StokKodu_Column
            // 
            this.StokKodu_Column.HeaderText = "Stok Kodu";
            this.StokKodu_Column.Name = "StokKodu_Column";
            this.StokKodu_Column.ReadOnly = true;
            // 
            // StockAdi_Column
            // 
            this.StockAdi_Column.HeaderText = "Stok Adı";
            this.StockAdi_Column.Name = "StockAdi_Column";
            this.StockAdi_Column.ReadOnly = true;
            // 
            // Mevcut_Column
            // 
            this.Mevcut_Column.HeaderText = "Mevcut";
            this.Mevcut_Column.Name = "Mevcut_Column";
            this.Mevcut_Column.ReadOnly = true;
            // 
            // Birim_column
            // 
            this.Birim_column.HeaderText = "Birim";
            this.Birim_column.Name = "Birim_column";
            this.Birim_column.ReadOnly = true;
            // 
            // BirimFiyatı_column
            // 
            this.BirimFiyatı_column.HeaderText = "Birim Fiyatı";
            this.BirimFiyatı_column.Name = "BirimFiyatı_column";
            this.BirimFiyatı_column.ReadOnly = true;
            // 
            // FrmStokAcilir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(721, 262);
            this.Controls.Add(this.Stoklar_dataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmStokAcilir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.FrmStokAcilir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stoklar_dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Stoklar_dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Iptal_button;
        private System.Windows.Forms.Button choose_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokKodu_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAdi_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mevcut_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyatı_column;
    }
}