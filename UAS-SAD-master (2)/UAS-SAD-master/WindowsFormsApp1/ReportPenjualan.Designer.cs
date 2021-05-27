
namespace WindowsFormsApp1
{
    partial class ReportPenjualan
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
            this.lreport = new System.Windows.Forms.Label();
            this.dgPenjualan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // lreport
            // 
            this.lreport.AutoSize = true;
            this.lreport.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lreport.Location = new System.Drawing.Point(524, 37);
            this.lreport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lreport.Name = "lreport";
            this.lreport.Size = new System.Drawing.Size(219, 33);
            this.lreport.TabIndex = 4;
            this.lreport.Text = "Report Penjualan";
            // 
            // dgPenjualan
            // 
            this.dgPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPenjualan.Location = new System.Drawing.Point(12, 92);
            this.dgPenjualan.Name = "dgPenjualan";
            this.dgPenjualan.RowHeadersWidth = 51;
            this.dgPenjualan.Size = new System.Drawing.Size(1240, 577);
            this.dgPenjualan.TabIndex = 5;
            // 
            // ReportPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dgPenjualan);
            this.Controls.Add(this.lreport);
            this.Name = "ReportPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repor Penjualan";
            this.Load += new System.EventHandler(this.ReportPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lreport;
        private System.Windows.Forms.DataGridView dgPenjualan;
    }
}