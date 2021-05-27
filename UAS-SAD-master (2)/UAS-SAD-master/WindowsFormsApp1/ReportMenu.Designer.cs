
namespace WindowsFormsApp1
{
    partial class ReportMenu
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.timeAkhir = new System.Windows.Forms.DateTimePicker();
            this.timeAwal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(692, 37);
            this.label5.TabIndex = 47;
            this.label5.Text = " Cek Report Pembelian / Penjualan / Sisa Stock";
            // 
            // cbReport
            // 
            this.cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReport.FormattingEnabled = true;
            this.cbReport.Items.AddRange(new object[] {
            "Penjualan",
            "Pembelian",
            "Sisa Stock"});
            this.cbReport.Location = new System.Drawing.Point(574, 160);
            this.cbReport.Name = "cbReport";
            this.cbReport.Size = new System.Drawing.Size(249, 32);
            this.cbReport.TabIndex = 55;
            // 
            // cbBarang
            // 
            this.cbBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(574, 208);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(249, 32);
            this.cbBarang.TabIndex = 54;
            // 
            // timeAkhir
            // 
            this.timeAkhir.CustomFormat = "yyyy-MM-dd";
            this.timeAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeAkhir.Location = new System.Drawing.Point(574, 310);
            this.timeAkhir.Name = "timeAkhir";
            this.timeAkhir.Size = new System.Drawing.Size(249, 29);
            this.timeAkhir.TabIndex = 53;
            // 
            // timeAwal
            // 
            this.timeAwal.CustomFormat = "yyyy-MM-dd";
            this.timeAwal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeAwal.Location = new System.Drawing.Point(574, 257);
            this.timeAwal.Name = "timeAwal";
            this.timeAwal.Size = new System.Drawing.Size(249, 29);
            this.timeAwal.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Jenis Report";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.Location = new System.Drawing.Point(407, 211);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(119, 24);
            this.v.TabIndex = 50;
            this.v.Text = "Jenis Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tanggal Akhir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tanggal Awal";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(574, 402);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 35);
            this.btnOK.TabIndex = 56;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbReport);
            this.Controls.Add(this.cbBarang);
            this.Controls.Add(this.timeAkhir);
            this.Controls.Add(this.timeAwal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Menu";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.DateTimePicker timeAkhir;
        private System.Windows.Forms.DateTimePicker timeAwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
    }
}