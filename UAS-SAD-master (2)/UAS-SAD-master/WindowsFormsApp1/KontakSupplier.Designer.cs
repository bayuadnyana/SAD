
namespace WindowsFormsApp1
{
    partial class KontakSupplier
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.tambah = new System.Windows.Forms.Label();
            this.dgvkontak = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkontak)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Masukan Nama";
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(228, 35);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(401, 29);
            this.searchbox.TabIndex = 47;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // tambah
            // 
            this.tambah.AutoSize = true;
            this.tambah.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah.Location = new System.Drawing.Point(1013, 35);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(200, 23);
            this.tambah.TabIndex = 46;
            this.tambah.Text = "Tambahkan Kontak(+)";
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // dgvkontak
            // 
            this.dgvkontak.AllowUserToAddRows = false;
            this.dgvkontak.AllowUserToDeleteRows = false;
            this.dgvkontak.AllowUserToResizeColumns = false;
            this.dgvkontak.AllowUserToResizeRows = false;
            this.dgvkontak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkontak.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvkontak.Location = new System.Drawing.Point(52, 84);
            this.dgvkontak.Name = "dgvkontak";
            this.dgvkontak.Size = new System.Drawing.Size(1161, 562);
            this.dgvkontak.TabIndex = 45;
            this.dgvkontak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkontak_CellClick);
            // 
            // KontakSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.dgvkontak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KontakSupplier";
            this.Text = "KontakSupplier";
            this.Load += new System.EventHandler(this.KontakSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkontak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Label tambah;
        private System.Windows.Forms.DataGridView dgvkontak;
    }
}