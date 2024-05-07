namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmSiparisler
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
            this.SiparislerBaslik_label = new System.Windows.Forms.Label();
            this.Siparisler_dataGridView = new System.Windows.Forms.DataGridView();
            this.SiparisNo_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetBorc_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAlacak_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparislerPB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisDetayiBaslik_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Durumu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kodu_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Karsilanan_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birimi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toplam_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiparisDetayiPB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HazirMiktar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BekleyenMiktar_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Siparisler_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SiparislerBaslik_label
            // 
            this.SiparislerBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.SiparislerBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SiparislerBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SiparislerBaslik_label.Location = new System.Drawing.Point(12, 9);
            this.SiparislerBaslik_label.Name = "SiparislerBaslik_label";
            this.SiparislerBaslik_label.Size = new System.Drawing.Size(652, 21);
            this.SiparislerBaslik_label.TabIndex = 0;
            this.SiparislerBaslik_label.Text = "Siparişler";
            this.SiparislerBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Siparisler_dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Siparisler_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Siparisler_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Siparisler_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Siparisler_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Siparisler_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiparisNo_column,
            this.IslemTipi_column,
            this.Tarih_column,
            this.CariKodu_column,
            this.CariAdi_column,
            this.NetBorc_column,
            this.NetAlacak_column,
            this.SiparislerPB_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Siparisler_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Siparisler_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.Siparisler_dataGridView.Name = "Siparisler_dataGridView";
            this.Siparisler_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Siparisler_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Siparisler_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Siparisler_dataGridView.Size = new System.Drawing.Size(652, 150);
            this.Siparisler_dataGridView.TabIndex = 1;
            // 
            // SiparisNo_column
            // 
            this.SiparisNo_column.HeaderText = "Sipariş No";
            this.SiparisNo_column.Name = "SiparisNo_column";
            this.SiparisNo_column.ReadOnly = true;
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
            // SiparislerPB_column
            // 
            this.SiparislerPB_column.HeaderText = "PB";
            this.SiparislerPB_column.Name = "SiparislerPB_column";
            this.SiparislerPB_column.ReadOnly = true;
            // 
            // SiparisDetayiBaslik_label
            // 
            this.SiparisDetayiBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.SiparisDetayiBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SiparisDetayiBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SiparisDetayiBaslik_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SiparisDetayiBaslik_label.Location = new System.Drawing.Point(12, 186);
            this.SiparisDetayiBaslik_label.Name = "SiparisDetayiBaslik_label";
            this.SiparisDetayiBaslik_label.Size = new System.Drawing.Size(652, 21);
            this.SiparisDetayiBaslik_label.TabIndex = 2;
            this.SiparisDetayiBaslik_label.Text = "Sipariş Detayı";
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
            this.Durumu_column,
            this.Kodu_column,
            this.Aciklama_column,
            this.Miktar_column,
            this.Karsilanan_column,
            this.Birimi_column,
            this.BirimFiyat_column,
            this.Toplam_column,
            this.SiparisDetayiPB_column,
            this.HazirMiktar_column,
            this.BekleyenMiktar_column});
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
            // Durumu_column
            // 
            this.Durumu_column.HeaderText = "Durumu";
            this.Durumu_column.Name = "Durumu_column";
            this.Durumu_column.ReadOnly = true;
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
            // Miktar_column
            // 
            this.Miktar_column.HeaderText = "Miktar";
            this.Miktar_column.Name = "Miktar_column";
            this.Miktar_column.ReadOnly = true;
            // 
            // Karsilanan_column
            // 
            this.Karsilanan_column.HeaderText = "Karşılanan";
            this.Karsilanan_column.Name = "Karsilanan_column";
            this.Karsilanan_column.ReadOnly = true;
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
            // Toplam_column
            // 
            this.Toplam_column.HeaderText = "Toplam";
            this.Toplam_column.Name = "Toplam_column";
            this.Toplam_column.ReadOnly = true;
            // 
            // SiparisDetayiPB_column
            // 
            this.SiparisDetayiPB_column.HeaderText = "PB";
            this.SiparisDetayiPB_column.Name = "SiparisDetayiPB_column";
            this.SiparisDetayiPB_column.ReadOnly = true;
            // 
            // HazirMiktar_column
            // 
            this.HazirMiktar_column.HeaderText = "Hazır Miktar";
            this.HazirMiktar_column.Name = "HazirMiktar_column";
            this.HazirMiktar_column.ReadOnly = true;
            // 
            // BekleyenMiktar_column
            // 
            this.BekleyenMiktar_column.HeaderText = "Bekleyen Miktar";
            this.BekleyenMiktar_column.Name = "BekleyenMiktar_column";
            this.BekleyenMiktar_column.ReadOnly = true;
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SiparisDetayiBaslik_label);
            this.Controls.Add(this.Siparisler_dataGridView);
            this.Controls.Add(this.SiparislerBaslik_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmSiparisler";
            ((System.ComponentModel.ISupportInitialize)(this.Siparisler_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SiparislerBaslik_label;
        private System.Windows.Forms.DataGridView Siparisler_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisNo_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetBorc_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAlacak_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparislerPB_column;
        private System.Windows.Forms.Label SiparisDetayiBaslik_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durumu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kodu_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Karsilanan_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birimi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toplam_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiparisDetayiPB_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn HazirMiktar_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn BekleyenMiktar_column;
    }
}