
namespace WindowsFormsApp1
{
    partial class DetailReminder
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
            this.dgvdetail = new System.Windows.Forms.DataGridView();
            this.tbid = new System.Windows.Forms.TextBox();
            this.lebeldetail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelnama = new System.Windows.Forms.Label();
            this.labelalamat = new System.Windows.Forms.Label();
            this.labelnotelp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdetail
            // 
            this.dgvdetail.AllowUserToAddRows = false;
            this.dgvdetail.AllowUserToDeleteRows = false;
            this.dgvdetail.AllowUserToOrderColumns = true;
            this.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvdetail.Location = new System.Drawing.Point(12, 48);
            this.dgvdetail.Name = "dgvdetail";
            this.dgvdetail.Size = new System.Drawing.Size(680, 267);
            this.dgvdetail.TabIndex = 0;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(12, 12);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(50, 20);
            this.tbid.TabIndex = 1;
            this.tbid.Visible = false;
            // 
            // lebeldetail
            // 
            this.lebeldetail.AutoSize = true;
            this.lebeldetail.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.lebeldetail.Location = new System.Drawing.Point(376, 9);
            this.lebeldetail.Name = "lebeldetail";
            this.lebeldetail.Size = new System.Drawing.Size(41, 23);
            this.lebeldetail.TabIndex = 2;
            this.lebeldetail.Text = "text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Alamat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "No Telp:";
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.labelnama.Location = new System.Drawing.Point(92, 318);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(41, 23);
            this.labelnama.TabIndex = 7;
            this.labelnama.Text = "text";
            // 
            // labelalamat
            // 
            this.labelalamat.AutoSize = true;
            this.labelalamat.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.labelalamat.Location = new System.Drawing.Point(92, 341);
            this.labelalamat.Name = "labelalamat";
            this.labelalamat.Size = new System.Drawing.Size(41, 23);
            this.labelalamat.TabIndex = 8;
            this.labelalamat.Text = "text";
            // 
            // labelnotelp
            // 
            this.labelnotelp.AutoSize = true;
            this.labelnotelp.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.labelnotelp.Location = new System.Drawing.Point(92, 364);
            this.labelnotelp.Name = "labelnotelp";
            this.labelnotelp.Size = new System.Drawing.Size(41, 23);
            this.labelnotelp.TabIndex = 9;
            this.labelnotelp.Text = "text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label4.Location = new System.Drawing.Point(113, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Transaksi Penjualan Tanggal:";
            // 
            // DetailReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelnotelp);
            this.Controls.Add(this.labelalamat);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lebeldetail);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.dgvdetail);
            this.Name = "DetailReminder";
            this.Text = "DetailReminder";
            this.Load += new System.EventHandler(this.DetailReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdetail;
        public System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label lebeldetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelnama;
        public System.Windows.Forms.Label labelalamat;
        public System.Windows.Forms.Label labelnotelp;
        private System.Windows.Forms.Label label4;
    }
}