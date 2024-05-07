namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmCekSenetler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CekSenetBordrolarıBaslik_label = new System.Windows.Forms.Label();
            this.CekSenetBordroları_dataGridView = new System.Windows.Forms.DataGridView();
            this.SeriNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarihi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CekSenetBordrolarıCariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToplamTutar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankaAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CekSenetlerBaslik_label = new System.Windows.Forms.Label();
            this.CekSenetler_dataGridView = new System.Windows.Forms.DataGridView();
            this.CekNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durumu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTarihi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdemeTarihi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CekSenetlerCariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutarı_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevredilenCariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CekSenetBordroları_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CekSenetler_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CekSenetBordrolarıBaslik_label
            // 
            this.CekSenetBordrolarıBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.CekSenetBordrolarıBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CekSenetBordrolarıBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CekSenetBordrolarıBaslik_label.Location = new System.Drawing.Point(12, 9);
            this.CekSenetBordrolarıBaslik_label.Name = "CekSenetBordrolarıBaslik_label";
            this.CekSenetBordrolarıBaslik_label.Size = new System.Drawing.Size(891, 21);
            this.CekSenetBordrolarıBaslik_label.TabIndex = 0;
            this.CekSenetBordrolarıBaslik_label.Text = "Çek Senet  Bordroları";
            this.CekSenetBordrolarıBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CekSenetBordroları_dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CekSenetBordroları_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CekSenetBordroları_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CekSenetBordroları_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CekSenetBordroları_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CekSenetBordroları_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CekSenetBordroları_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeriNo_column,
            this.Tarihi_column,
            this.IslemTipi_column,
            this.CariKodu_column,
            this.CekSenetBordrolarıCariAdi_column,
            this.ToplamTutar_column,
            this.BankaAdi_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CekSenetBordroları_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CekSenetBordroları_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.CekSenetBordroları_dataGridView.Name = "CekSenetBordroları_dataGridView";
            this.CekSenetBordroları_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CekSenetBordroları_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CekSenetBordroları_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CekSenetBordroları_dataGridView.Size = new System.Drawing.Size(891, 150);
            this.CekSenetBordroları_dataGridView.TabIndex = 1;
            // 
            // SeriNo_column
            // 
            this.SeriNo_column.HeaderText = "Seri No";
            this.SeriNo_column.Name = "SeriNo_column";
            this.SeriNo_column.ReadOnly = true;
            // 
            // Tarihi_column
            // 
            this.Tarihi_column.HeaderText = "Tarihi";
            this.Tarihi_column.Name = "Tarihi_column";
            this.Tarihi_column.ReadOnly = true;
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
            // CekSenetBordrolarıCariAdi_column
            // 
            this.CekSenetBordrolarıCariAdi_column.HeaderText = "Cari Adı";
            this.CekSenetBordrolarıCariAdi_column.Name = "CekSenetBordrolarıCariAdi_column";
            this.CekSenetBordrolarıCariAdi_column.ReadOnly = true;
            // 
            // ToplamTutar_column
            // 
            this.ToplamTutar_column.HeaderText = "Toplam Tutar";
            this.ToplamTutar_column.Name = "ToplamTutar_column";
            this.ToplamTutar_column.ReadOnly = true;
            // 
            // BankaAdi_column
            // 
            this.BankaAdi_column.HeaderText = "Banka Adı";
            this.BankaAdi_column.Name = "BankaAdi_column";
            this.BankaAdi_column.ReadOnly = true;
            // 
            // CekSenetlerBaslik_label
            // 
            this.CekSenetlerBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.CekSenetlerBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CekSenetlerBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CekSenetlerBaslik_label.Location = new System.Drawing.Point(12, 186);
            this.CekSenetlerBaslik_label.Name = "CekSenetlerBaslik_label";
            this.CekSenetlerBaslik_label.Size = new System.Drawing.Size(891, 21);
            this.CekSenetlerBaslik_label.TabIndex = 2;
            this.CekSenetlerBaslik_label.Text = "Çek Senetler";
            this.CekSenetlerBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CekSenetler_dataGridView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CekSenetler_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.CekSenetler_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CekSenetler_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CekSenetler_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CekSenetler_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CekSenetler_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CekNo_column,
            this.Durumu_column,
            this.IslemTarihi_column,
            this.OdemeTarihi_column,
            this.CekSenetlerCariAdi_column,
            this.Tutarı_column,
            this.PB_column,
            this.DevredilenCariAdi_column});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CekSenetler_dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.CekSenetler_dataGridView.Location = new System.Drawing.Point(12, 210);
            this.CekSenetler_dataGridView.Name = "CekSenetler_dataGridView";
            this.CekSenetler_dataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CekSenetler_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CekSenetler_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.CekSenetler_dataGridView.Size = new System.Drawing.Size(891, 150);
            this.CekSenetler_dataGridView.TabIndex = 3;
            // 
            // CekNo_column
            // 
            this.CekNo_column.HeaderText = "Çek No";
            this.CekNo_column.Name = "CekNo_column";
            this.CekNo_column.ReadOnly = true;
            // 
            // Durumu_column
            // 
            this.Durumu_column.HeaderText = "Durumu";
            this.Durumu_column.Name = "Durumu_column";
            this.Durumu_column.ReadOnly = true;
            // 
            // IslemTarihi_column
            // 
            this.IslemTarihi_column.HeaderText = "İşlem Tarihi";
            this.IslemTarihi_column.Name = "IslemTarihi_column";
            this.IslemTarihi_column.ReadOnly = true;
            // 
            // OdemeTarihi_column
            // 
            this.OdemeTarihi_column.HeaderText = "Ödeme Tarihi";
            this.OdemeTarihi_column.Name = "OdemeTarihi_column";
            this.OdemeTarihi_column.ReadOnly = true;
            // 
            // CekSenetlerCariAdi_column
            // 
            this.CekSenetlerCariAdi_column.HeaderText = "Cari Adı";
            this.CekSenetlerCariAdi_column.Name = "CekSenetlerCariAdi_column";
            this.CekSenetlerCariAdi_column.ReadOnly = true;
            // 
            // Tutarı_column
            // 
            this.Tutarı_column.HeaderText = "Tutarı";
            this.Tutarı_column.Name = "Tutarı_column";
            this.Tutarı_column.ReadOnly = true;
            // 
            // PB_column
            // 
            this.PB_column.HeaderText = "PB";
            this.PB_column.Name = "PB_column";
            this.PB_column.ReadOnly = true;
            // 
            // DevredilenCariAdi_column
            // 
            this.DevredilenCariAdi_column.HeaderText = "Devredilen Cari Adı";
            this.DevredilenCariAdi_column.Name = "DevredilenCariAdi_column";
            this.DevredilenCariAdi_column.ReadOnly = true;
            // 
            // FrmCekSenetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 408);
            this.Controls.Add(this.CekSenetler_dataGridView);
            this.Controls.Add(this.CekSenetlerBaslik_label);
            this.Controls.Add(this.CekSenetBordroları_dataGridView);
            this.Controls.Add(this.CekSenetBordrolarıBaslik_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCekSenetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmCekSenetler";
            ((System.ComponentModel.ISupportInitialize)(this.CekSenetBordroları_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CekSenetler_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CekSenetBordrolarıBaslik_label;
        private System.Windows.Forms.DataGridView CekSenetBordroları_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarihi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CekSenetBordrolarıCariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToplamTutar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankaAdi_column;
        private System.Windows.Forms.Label CekSenetlerBaslik_label;
        private System.Windows.Forms.DataGridView CekSenetler_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CekNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durumu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTarihi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdemeTarihi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CekSenetlerCariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutarı_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PB_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevredilenCariAdi_column;
    }
}