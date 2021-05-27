
namespace WindowsFormsApp1
{
    partial class FormPembelian
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
            this.selesaiButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.masukkandataButton = new System.Windows.Forms.Button();
            this.hargabaruNumeric = new System.Windows.Forms.NumericUpDown();
            this.totalLabel = new System.Windows.Forms.Label();
            this.allnotaDgv = new System.Windows.Forms.DataGridView();
            this.subnotaDgv = new System.Windows.Forms.DataGridView();
            this.hargabaruLabel = new System.Windows.Forms.Label();
            this.perubahanhargaCheckbox = new System.Windows.Forms.CheckBox();
            this.jumlahNumeric = new System.Windows.Forms.NumericUpDown();
            this.barangCombobox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.batalButton = new System.Windows.Forms.Button();
            this.supplierTextbox = new System.Windows.Forms.TextBox();
            this.alamatTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomorteleponTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hargaperliterNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hargabaruNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allnotaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnotaDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaperliterNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // selesaiButton
            // 
            this.selesaiButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selesaiButton.Location = new System.Drawing.Point(23, 655);
            this.selesaiButton.Margin = new System.Windows.Forms.Padding(2);
            this.selesaiButton.Name = "selesaiButton";
            this.selesaiButton.Size = new System.Drawing.Size(136, 30);
            this.selesaiButton.TabIndex = 94;
            this.selesaiButton.Text = "Selesai";
            this.selesaiButton.UseVisualStyleBackColor = true;
            this.selesaiButton.Click += new System.EventHandler(this.selesaiButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(640, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 19);
            this.label6.TabIndex = 93;
            this.label6.Text = "Riwayat Transaksi Pembelian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 92;
            this.label5.Text = "Semua Pesanan";
            // 
            // masukkandataButton
            // 
            this.masukkandataButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masukkandataButton.Location = new System.Drawing.Point(266, 374);
            this.masukkandataButton.Margin = new System.Windows.Forms.Padding(2);
            this.masukkandataButton.Name = "masukkandataButton";
            this.masukkandataButton.Size = new System.Drawing.Size(136, 29);
            this.masukkandataButton.TabIndex = 91;
            this.masukkandataButton.Text = "Masukkan Data";
            this.masukkandataButton.UseVisualStyleBackColor = true;
            this.masukkandataButton.Click += new System.EventHandler(this.masukkandataButton_Click);
            // 
            // hargabaruNumeric
            // 
            this.hargabaruNumeric.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargabaruNumeric.Location = new System.Drawing.Point(226, 302);
            this.hargabaruNumeric.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.hargabaruNumeric.Name = "hargabaruNumeric";
            this.hargabaruNumeric.Size = new System.Drawing.Size(216, 21);
            this.hargabaruNumeric.TabIndex = 66;
            this.hargabaruNumeric.Visible = false;
            this.hargabaruNumeric.ValueChanged += new System.EventHandler(this.hargabaruNumeric_ValueChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(226, 338);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(18, 19);
            this.totalLabel.TabIndex = 87;
            this.totalLabel.Text = "0";
            // 
            // allnotaDgv
            // 
            this.allnotaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allnotaDgv.Location = new System.Drawing.Point(640, 75);
            this.allnotaDgv.Name = "allnotaDgv";
            this.allnotaDgv.RowHeadersWidth = 51;
            this.allnotaDgv.Size = new System.Drawing.Size(600, 575);
            this.allnotaDgv.TabIndex = 85;
            // 
            // subnotaDgv
            // 
            this.subnotaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subnotaDgv.Location = new System.Drawing.Point(23, 432);
            this.subnotaDgv.Name = "subnotaDgv";
            this.subnotaDgv.RowHeadersWidth = 51;
            this.subnotaDgv.Size = new System.Drawing.Size(526, 218);
            this.subnotaDgv.TabIndex = 84;
            // 
            // hargabaruLabel
            // 
            this.hargabaruLabel.AutoSize = true;
            this.hargabaruLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargabaruLabel.Location = new System.Drawing.Point(19, 302);
            this.hargabaruLabel.Name = "hargabaruLabel";
            this.hargabaruLabel.Size = new System.Drawing.Size(88, 19);
            this.hargabaruLabel.TabIndex = 83;
            this.hargabaruLabel.Text = "Harga Baru";
            this.hargabaruLabel.Visible = false;
            // 
            // perubahanhargaCheckbox
            // 
            this.perubahanhargaCheckbox.AutoSize = true;
            this.perubahanhargaCheckbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perubahanhargaCheckbox.Location = new System.Drawing.Point(19, 266);
            this.perubahanhargaCheckbox.Name = "perubahanhargaCheckbox";
            this.perubahanhargaCheckbox.Size = new System.Drawing.Size(214, 23);
            this.perubahanhargaCheckbox.TabIndex = 81;
            this.perubahanhargaCheckbox.Text = "Perubahan Harga per Liter";
            this.perubahanhargaCheckbox.UseVisualStyleBackColor = true;
            this.perubahanhargaCheckbox.CheckedChanged += new System.EventHandler(this.perubahanhargaCheckbox_CheckedChanged);
            // 
            // jumlahNumeric
            // 
            this.jumlahNumeric.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahNumeric.Location = new System.Drawing.Point(226, 230);
            this.jumlahNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.jumlahNumeric.Name = "jumlahNumeric";
            this.jumlahNumeric.Size = new System.Drawing.Size(216, 21);
            this.jumlahNumeric.TabIndex = 78;
            this.jumlahNumeric.ValueChanged += new System.EventHandler(this.jumlahNumeric_ValueChanged);
            // 
            // barangCombobox
            // 
            this.barangCombobox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangCombobox.FormattingEnabled = true;
            this.barangCombobox.Location = new System.Drawing.Point(226, 50);
            this.barangCombobox.Name = "barangCombobox";
            this.barangCombobox.Size = new System.Drawing.Size(216, 21);
            this.barangCombobox.TabIndex = 76;
            this.barangCombobox.SelectedIndexChanged += new System.EventHandler(this.barangCombobox_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 75;
            this.label13.Text = "Barang";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 74;
            this.label12.Text = "Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 19);
            this.label11.TabIndex = 73;
            this.label11.Text = "Jumlah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(563, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 95;
            this.label1.Text = "Nota Pembelian";
            // 
            // batalButton
            // 
            this.batalButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalButton.Location = new System.Drawing.Point(413, 655);
            this.batalButton.Margin = new System.Windows.Forms.Padding(2);
            this.batalButton.Name = "batalButton";
            this.batalButton.Size = new System.Drawing.Size(136, 30);
            this.batalButton.TabIndex = 96;
            this.batalButton.Text = "Batal";
            this.batalButton.UseVisualStyleBackColor = true;
            this.batalButton.Click += new System.EventHandler(this.batalButton_Click);
            // 
            // supplierTextbox
            // 
            this.supplierTextbox.Location = new System.Drawing.Point(226, 86);
            this.supplierTextbox.Name = "supplierTextbox";
            this.supplierTextbox.Size = new System.Drawing.Size(216, 20);
            this.supplierTextbox.TabIndex = 97;
            this.supplierTextbox.TextChanged += new System.EventHandler(this.supplierTextbox_TextChanged);
            // 
            // alamatTextbox
            // 
            this.alamatTextbox.Location = new System.Drawing.Point(226, 123);
            this.alamatTextbox.Name = "alamatTextbox";
            this.alamatTextbox.Size = new System.Drawing.Size(216, 20);
            this.alamatTextbox.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Alamat";
            // 
            // nomorteleponTextbox
            // 
            this.nomorteleponTextbox.Location = new System.Drawing.Point(226, 160);
            this.nomorteleponTextbox.Name = "nomorteleponTextbox";
            this.nomorteleponTextbox.Size = new System.Drawing.Size(216, 20);
            this.nomorteleponTextbox.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 100;
            this.label4.Text = "Nomor Telepon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 19);
            this.label7.TabIndex = 102;
            this.label7.Text = "Harga per Liter";
            // 
            // hargaperliterNumeric
            // 
            this.hargaperliterNumeric.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaperliterNumeric.Location = new System.Drawing.Point(226, 196);
            this.hargaperliterNumeric.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.hargaperliterNumeric.Name = "hargaperliterNumeric";
            this.hargaperliterNumeric.Size = new System.Drawing.Size(216, 21);
            this.hargaperliterNumeric.TabIndex = 103;
            this.hargaperliterNumeric.ValueChanged += new System.EventHandler(this.hargaperliterNumeric_ValueChanged);
            // 
            // FormPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.hargaperliterNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nomorteleponTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alamatTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplierTextbox);
            this.Controls.Add(this.batalButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selesaiButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masukkandataButton);
            this.Controls.Add(this.hargabaruNumeric);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.allnotaDgv);
            this.Controls.Add(this.subnotaDgv);
            this.Controls.Add(this.hargabaruLabel);
            this.Controls.Add(this.perubahanhargaCheckbox);
            this.Controls.Add(this.jumlahNumeric);
            this.Controls.Add(this.barangCombobox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPembelian";
            this.Text = "M";
            this.Load += new System.EventHandler(this.FormPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hargabaruNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allnotaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subnotaDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hargaperliterNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selesaiButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button masukkandataButton;
        private System.Windows.Forms.NumericUpDown hargabaruNumeric;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView allnotaDgv;
        private System.Windows.Forms.DataGridView subnotaDgv;
        private System.Windows.Forms.Label hargabaruLabel;
        private System.Windows.Forms.CheckBox perubahanhargaCheckbox;
        private System.Windows.Forms.NumericUpDown jumlahNumeric;
        private System.Windows.Forms.ComboBox barangCombobox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button batalButton;
        private System.Windows.Forms.TextBox supplierTextbox;
        private System.Windows.Forms.TextBox alamatTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomorteleponTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown hargaperliterNumeric;
    }
}