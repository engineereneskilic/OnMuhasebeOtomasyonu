namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmDekontlar
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
            this.DekontlarBaslik_label = new System.Windows.Forms.Label();
            this.Dekontlar_dataGridView = new System.Windows.Forms.DataGridView();
            this.IslemTipi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borc_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alacak_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PB_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dekontlar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DekontlarBaslik_label
            // 
            this.DekontlarBaslik_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.DekontlarBaslik_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DekontlarBaslik_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.DekontlarBaslik_label.Location = new System.Drawing.Point(12, 9);
            this.DekontlarBaslik_label.Name = "DekontlarBaslik_label";
            this.DekontlarBaslik_label.Size = new System.Drawing.Size(891, 21);
            this.DekontlarBaslik_label.TabIndex = 0;
            this.DekontlarBaslik_label.Text = "Dekontlar";
            this.DekontlarBaslik_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dekontlar_dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dekontlar_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dekontlar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dekontlar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dekontlar_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dekontlar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dekontlar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IslemTipi_column,
            this.Tarih_column,
            this.CariAdi_column,
            this.Borc_column,
            this.Alacak_column,
            this.PB_column,
            this.Aciklama_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dekontlar_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dekontlar_dataGridView.Location = new System.Drawing.Point(12, 33);
            this.Dekontlar_dataGridView.Name = "Dekontlar_dataGridView";
            this.Dekontlar_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dekontlar_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dekontlar_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dekontlar_dataGridView.Size = new System.Drawing.Size(891, 150);
            this.Dekontlar_dataGridView.TabIndex = 1;
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
            // PB_column
            // 
            this.PB_column.HeaderText = "PB";
            this.PB_column.Name = "PB_column";
            this.PB_column.ReadOnly = true;
            // 
            // Aciklama_column
            // 
            this.Aciklama_column.HeaderText = "Açıklama";
            this.Aciklama_column.Name = "Aciklama_column";
            this.Aciklama_column.ReadOnly = true;
            // 
            // FrmDekontlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 408);
            this.Controls.Add(this.Dekontlar_dataGridView);
            this.Controls.Add(this.DekontlarBaslik_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDekontlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDekontlar";
            ((System.ComponentModel.ISupportInitialize)(this.Dekontlar_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DekontlarBaslik_label;
        private System.Windows.Forms.DataGridView Dekontlar_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTipi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borc_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alacak_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PB_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama_column;
    }
}