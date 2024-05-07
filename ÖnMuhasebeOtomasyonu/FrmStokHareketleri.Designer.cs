namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmStokHareketleri
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
            this.StokHareketleriBaslik_label = new System.Windows.Forms.Label();
            this.StokHareketleri_dataGridView = new System.Windows.Forms.DataGridView();
            this.IslemTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IrsaliyeNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetBorc_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAlacak_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVDahil_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRM_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HareketDetayiBaslik_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TURU_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepoNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giren_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cikan_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birimi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StokHareketleri_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StokHareketleriBaslik_label
            // 
            this.StokHareketleriBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.StokHareketleriBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StokHareketleriBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.StokHareketleriBaslik_label.Location = new System.Drawing.Point(12, 9);
            this.StokHareketleriBaslik_label.Name = "StokHareketleriBaslik_label";
            this.StokHareketleriBaslik_label.Size = new System.Drawing.Size(652, 21);
            this.StokHareketleriBaslik_label.TabIndex = 0;
            this.StokHareketleriBaslik_label.Text = "Stok Hareketleri";
            this.StokHareketleriBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StokHareketleri_dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StokHareketleri_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StokHareketleri_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StokHareketleri_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StokHareketleri_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StokHareketleri_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IslemTipi_column,
            this.Tarih_column,
            this.IrsaliyeNo_column,
            this.CariKodu_column,
            this.CariAdi_column,
            this.NetBorc_column,
            this.NetAlacak_column,
            this.KDVDahil_column,
            this.DRM_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StokHareketleri_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StokHareketleri_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.StokHareketleri_dataGridView.Name = "StokHareketleri_dataGridView";
            this.StokHareketleri_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StokHareketleri_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StokHareketleri_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StokHareketleri_dataGridView.Size = new System.Drawing.Size(652, 150);
            this.StokHareketleri_dataGridView.TabIndex = 1;
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
            // IrsaliyeNo_column
            // 
            this.IrsaliyeNo_column.HeaderText = "İrsaliye No";
            this.IrsaliyeNo_column.Name = "IrsaliyeNo_column";
            this.IrsaliyeNo_column.ReadOnly = true;
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
            // KDVDahil_column
            // 
            this.KDVDahil_column.HeaderText = "KDV Dahil ?";
            this.KDVDahil_column.Name = "KDVDahil_column";
            this.KDVDahil_column.ReadOnly = true;
            // 
            // DRM_column
            // 
            this.DRM_column.HeaderText = "DRM";
            this.DRM_column.Name = "DRM_column";
            this.DRM_column.ReadOnly = true;
            // 
            // HareketDetayiBaslik_label
            // 
            this.HareketDetayiBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.HareketDetayiBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HareketDetayiBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.HareketDetayiBaslik_label.Location = new System.Drawing.Point(12, 186);
            this.HareketDetayiBaslik_label.Name = "HareketDetayiBaslik_label";
            this.HareketDetayiBaslik_label.Size = new System.Drawing.Size(652, 21);
            this.HareketDetayiBaslik_label.TabIndex = 2;
            this.HareketDetayiBaslik_label.Text = "Hareket Detayı";
            this.HareketDetayiBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TURU_column,
            this.Kodu_column,
            this.Aciklama_column,
            this.DepoNo_column,
            this.Giren_column,
            this.Cikan_column,
            this.Birimi_column,
            this.BirimFiyat_column});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // TURU_column
            // 
            this.TURU_column.HeaderText = "TURU";
            this.TURU_column.Name = "TURU_column";
            this.TURU_column.ReadOnly = true;
            // 
            // Kodu_column
            // 
            this.Kodu_column.HeaderText = "Kodu";
            this.Kodu_column.Name = "Kodu_column";
            this.Kodu_column.ReadOnly = true;
            // 
            // Aciklama_column
            // 
            this.Aciklama_column.HeaderText = "Açıklama";
            this.Aciklama_column.Name = "Aciklama_column";
            this.Aciklama_column.ReadOnly = true;
            // 
            // DepoNo_column
            // 
            this.DepoNo_column.HeaderText = "Depo No";
            this.DepoNo_column.Name = "DepoNo_column";
            this.DepoNo_column.ReadOnly = true;
            // 
            // Giren_column
            // 
            this.Giren_column.HeaderText = "Giren +";
            this.Giren_column.Name = "Giren_column";
            this.Giren_column.ReadOnly = true;
            // 
            // Cikan_column
            // 
            this.Cikan_column.HeaderText = "Çıkan -";
            this.Cikan_column.Name = "Cikan_column";
            this.Cikan_column.ReadOnly = true;
            // 
            // Birimi_column
            // 
            this.Birimi_column.HeaderText = "Birimi";
            this.Birimi_column.Name = "Birimi_column";
            this.Birimi_column.ReadOnly = true;
            // 
            // BirimFiyat_column
            // 
            this.BirimFiyat_column.HeaderText = "Birim Fiyat";
            this.BirimFiyat_column.Name = "BirimFiyat_column";
            this.BirimFiyat_column.ReadOnly = true;
            // 
            // FrmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HareketDetayiBaslik_label);
            this.Controls.Add(this.StokHareketleri_dataGridView);
            this.Controls.Add(this.StokHareketleriBaslik_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStokHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmStokHareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.StokHareketleri_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label StokHareketleriBaslik_label;
        private System.Windows.Forms.DataGridView StokHareketleri_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IrsaliyeNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetBorc_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAlacak_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVDahil_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRM_column;
        private System.Windows.Forms.Label HareketDetayiBaslik_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TURU_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepoNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giren_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cikan_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birimi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat_column;
    }
}