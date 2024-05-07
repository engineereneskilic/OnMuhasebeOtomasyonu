namespace ÖnMuhasebeOtomasyonu
{
    partial class FrmBankaAcilir
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Iptal_button = new System.Windows.Forms.Button();
            this.sec_button = new System.Windows.Forms.Button();
            this.bankalar_dataGridView = new System.Windows.Forms.DataGridView();
            this.Sıra_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banka_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapadi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hesapbakiyesi_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankalar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 488F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.Iptal_button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sec_button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 225);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 36);
            this.tableLayoutPanel1.TabIndex = 3;
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
            // 
            // sec_button
            // 
            this.sec_button.BackgroundImage = global::ÖnMuhasebeOtomasyonu.Properties.Resources.Kaydett;
            this.sec_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sec_button.Location = new System.Drawing.Point(495, 5);
            this.sec_button.Name = "sec_button";
            this.sec_button.Size = new System.Drawing.Size(90, 25);
            this.sec_button.TabIndex = 5;
            this.sec_button.Text = "       Seç";
            this.sec_button.UseVisualStyleBackColor = true;
            this.sec_button.Click += new System.EventHandler(this.sec_button_Click_1);
            // 
            // bankalar_dataGridView
            // 
            this.bankalar_dataGridView.AllowUserToAddRows = false;
            this.bankalar_dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bankalar_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bankalar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bankalar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bankalar_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bankalar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bankalar_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sıra_column,
            this.Banka_column,
            this.hesapadi_column,
            this.Hesapbakiyesi_column});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bankalar_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.bankalar_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.bankalar_dataGridView.Name = "bankalar_dataGridView";
            this.bankalar_dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bankalar_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bankalar_dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.bankalar_dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bankalar_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bankalar_dataGridView.Size = new System.Drawing.Size(722, 224);
            this.bankalar_dataGridView.TabIndex = 8;
            this.bankalar_dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bankalar_dataGridView_CellDoubleClick);
            // 
            // Sıra_column
            // 
            this.Sıra_column.HeaderText = "Sıra";
            this.Sıra_column.Name = "Sıra_column";
            this.Sıra_column.ReadOnly = true;
            // 
            // Banka_column
            // 
            this.Banka_column.HeaderText = "Banka";
            this.Banka_column.Name = "Banka_column";
            this.Banka_column.ReadOnly = true;
            // 
            // hesapadi_column
            // 
            this.hesapadi_column.HeaderText = "Hesap Adı";
            this.hesapadi_column.Name = "hesapadi_column";
            this.hesapadi_column.ReadOnly = true;
            // 
            // Hesapbakiyesi_column
            // 
            this.Hesapbakiyesi_column.HeaderText = "Hesap Bakiyesi";
            this.Hesapbakiyesi_column.Name = "Hesapbakiyesi_column";
            this.Hesapbakiyesi_column.ReadOnly = true;
            // 
            // FrmBankaAcilir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(726, 263);
            this.Controls.Add(this.bankalar_dataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmBankaAcilir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankaKartlari";
            this.Load += new System.EventHandler(this.FrmBankaAcilir_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bankalar_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Iptal_button;
        private System.Windows.Forms.Button sec_button;
        public System.Windows.Forms.DataGridView bankalar_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sıra_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banka_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapadi_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hesapbakiyesi_column;
    }
}