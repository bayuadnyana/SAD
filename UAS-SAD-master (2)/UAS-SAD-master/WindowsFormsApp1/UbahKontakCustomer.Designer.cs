
namespace WindowsFormsApp1
{
    partial class UbahKontakCustomer
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnotelp = new System.Windows.Forms.TextBox();
            this.tbalamat = new System.Windows.Forms.TextBox();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.btbatal = new System.Windows.Forms.Button();
            this.btsimpan = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "No Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nama";
            // 
            // tbnotelp
            // 
            this.tbnotelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnotelp.Location = new System.Drawing.Point(180, 142);
            this.tbnotelp.Name = "tbnotelp";
            this.tbnotelp.Size = new System.Drawing.Size(396, 29);
            this.tbnotelp.TabIndex = 45;
            this.tbnotelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnotelp_KeyPress);
            // 
            // tbalamat
            // 
            this.tbalamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbalamat.Location = new System.Drawing.Point(180, 81);
            this.tbalamat.Name = "tbalamat";
            this.tbalamat.Size = new System.Drawing.Size(396, 29);
            this.tbalamat.TabIndex = 44;
            // 
            // tbnama
            // 
            this.tbnama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnama.Location = new System.Drawing.Point(180, 25);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(396, 29);
            this.tbnama.TabIndex = 43;
            // 
            // btbatal
            // 
            this.btbatal.BackColor = System.Drawing.Color.Yellow;
            this.btbatal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbatal.Location = new System.Drawing.Point(233, 206);
            this.btbatal.Name = "btbatal";
            this.btbatal.Size = new System.Drawing.Size(143, 30);
            this.btbatal.TabIndex = 56;
            this.btbatal.Text = "Batal";
            this.btbatal.UseVisualStyleBackColor = false;
            this.btbatal.Click += new System.EventHandler(this.btbatal_Click);
            // 
            // btsimpan
            // 
            this.btsimpan.BackColor = System.Drawing.Color.LawnGreen;
            this.btsimpan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsimpan.Location = new System.Drawing.Point(72, 206);
            this.btsimpan.Name = "btsimpan";
            this.btsimpan.Size = new System.Drawing.Size(143, 30);
            this.btsimpan.TabIndex = 55;
            this.btsimpan.Text = "Simpan";
            this.btsimpan.UseVisualStyleBackColor = false;
            this.btsimpan.Click += new System.EventHandler(this.btsimpan_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.Red;
            this.btdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Location = new System.Drawing.Point(393, 206);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(143, 30);
            this.btdelete.TabIndex = 54;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(102, 28);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(54, 20);
            this.tbid.TabIndex = 57;
            this.tbid.Visible = false;
            // 
            // UbahKontakCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 248);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.btbatal);
            this.Controls.Add(this.btsimpan);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.tbnotelp);
            this.Controls.Add(this.tbalamat);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UbahKontakCustomer";
            this.Text = "UbahKontakCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btbatal;
        private System.Windows.Forms.Button btsimpan;
        private System.Windows.Forms.Button btdelete;
        public System.Windows.Forms.TextBox tbnama;
        public System.Windows.Forms.TextBox tbnotelp;
        public System.Windows.Forms.TextBox tbalamat;
        public System.Windows.Forms.TextBox tbid;
    }
}