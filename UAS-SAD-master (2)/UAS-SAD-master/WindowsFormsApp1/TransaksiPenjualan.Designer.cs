
namespace WindowsFormsApp1
{
    partial class FormPenjualan
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
            this.jumlahNumeric = new System.Windows.Forms.NumericUpDown();
            this.supplierCombobox = new System.Windows.Forms.ComboBox();
            this.barangCombobox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.subnotaDataGridView = new System.Windows.Forms.DataGridView();
            this.allNotaDataGridView = new System.Windows.Forms.DataGridView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.insertButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selesaiButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnotaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allNotaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jumlahNumeric
            // 
            this.jumlahNumeric.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahNumeric.Location = new System.Drawing.Point(226, 122);
            this.jumlahNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.jumlahNumeric.Name = "jumlahNumeric";
            this.jumlahNumeric.Size = new System.Drawing.Size(216, 21);
            this.jumlahNumeric.TabIndex = 42;
            this.jumlahNumeric.ValueChanged += new System.EventHandler(this.jumlahNumeric_ValueChanged);
            // 
            // supplierCombobox
            // 
            this.supplierCombobox.Enabled = false;
            this.supplierCombobox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierCombobox.FormattingEnabled = true;
            this.supplierCombobox.Location = new System.Drawing.Point(226, 86);
            this.supplierCombobox.Name = "supplierCombobox";
            this.supplierCombobox.Size = new System.Drawing.Size(216, 21);
            this.supplierCombobox.TabIndex = 41;
            this.supplierCombobox.UseWaitCursor = true;
            this.supplierCombobox.SelectedIndexChanged += new System.EventHandler(this.supplierCombobox_SelectedIndexChanged);
            // 
            // barangCombobox
            // 
            this.barangCombobox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangCombobox.FormattingEnabled = true;
            this.barangCombobox.Location = new System.Drawing.Point(226, 50);
            this.barangCombobox.Name = "barangCombobox";
            this.barangCombobox.Size = new System.Drawing.Size(216, 21);
            this.barangCombobox.TabIndex = 40;
            this.barangCombobox.SelectedIndexChanged += new System.EventHandler(this.barangCombobox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Barang";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(17, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "transaction >";
            // 
            // subnotaDataGridView
            // 
            this.subnotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subnotaDataGridView.Location = new System.Drawing.Point(23, 252);
            this.subnotaDataGridView.Name = "subnotaDataGridView";
            this.subnotaDataGridView.RowHeadersWidth = 51;
            this.subnotaDataGridView.Size = new System.Drawing.Size(526, 398);
            this.subnotaDataGridView.TabIndex = 57;
            // 
            // allNotaDataGridView
            // 
            this.allNotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allNotaDataGridView.Location = new System.Drawing.Point(640, 75);
            this.allNotaDataGridView.Name = "allNotaDataGridView";
            this.allNotaDataGridView.RowHeadersWidth = 51;
            this.allNotaDataGridView.Size = new System.Drawing.Size(600, 575);
            this.allNotaDataGridView.TabIndex = 58;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(226, 158);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(18, 19);
            this.totalLabel.TabIndex = 60;
            this.totalLabel.Text = "0";
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(266, 194);
            this.insertButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(136, 29);
            this.insertButton.TabIndex = 64;
            this.insertButton.Text = "Masukkan Data";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "Semua Pesanan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(640, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "Riwayat Transaksi Penjualan";
            // 
            // selesaiButton
            // 
            this.selesaiButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selesaiButton.Location = new System.Drawing.Point(19, 655);
            this.selesaiButton.Margin = new System.Windows.Forms.Padding(2);
            this.selesaiButton.Name = "selesaiButton";
            this.selesaiButton.Size = new System.Drawing.Size(136, 30);
            this.selesaiButton.TabIndex = 67;
            this.selesaiButton.Text = "Selesai";
            this.selesaiButton.UseVisualStyleBackColor = true;
            this.selesaiButton.Click += new System.EventHandler(this.selesaiButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(569, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 19);
            this.label14.TabIndex = 96;
            this.label14.Text = "Nota Penjualan";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(409, 655);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 30);
            this.cancelButton.TabIndex = 97;
            this.cancelButton.Text = "Batal";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.selesaiButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.allNotaDataGridView);
            this.Controls.Add(this.subnotaDataGridView);
            this.Controls.Add(this.jumlahNumeric);
            this.Controls.Add(this.supplierCombobox);
            this.Controls.Add(this.barangCombobox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPenjualan";
            this.Text = " ";
            this.Load += new System.EventHandler(this.TransaksiPenjualan_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.jumlahNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnotaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allNotaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown jumlahNumeric;
        private System.Windows.Forms.ComboBox supplierCombobox;
        private System.Windows.Forms.ComboBox barangCombobox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView subnotaDataGridView;
        private System.Windows.Forms.DataGridView allNotaDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selesaiButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cancelButton;
    }
}