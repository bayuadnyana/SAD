namespace WindowsFormsApp1
{
    partial class PopupTransaksiPenjualan
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
            this.label13 = new System.Windows.Forms.Label();
            this.hargaBaruNumeric = new System.Windows.Forms.NumericUpDown();
            this.jatuhtempoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bayarNumeric = new System.Windows.Forms.NumericUpDown();
            this.bayarText = new System.Windows.Forms.Label();
            this.jatuhtempoText = new System.Windows.Forms.Label();
            this.hutangCheckbox = new System.Windows.Forms.CheckBox();
            this.langgananCheckbox = new System.Windows.Forms.CheckBox();
            this.pengirimanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.hargaBaruText = new System.Windows.Forms.Label();
            this.custTextbox = new System.Windows.Forms.TextBox();
            this.selesaiButton = new System.Windows.Forms.Button();
            this.alamatTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teleponTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hargaBaruNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayarNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 23);
            this.label13.TabIndex = 41;
            this.label13.Text = "Nama Pelanggan";
            // 
            // hargaBaruNumeric
            // 
            this.hargaBaruNumeric.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaBaruNumeric.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hargaBaruNumeric.Location = new System.Drawing.Point(296, 204);
            this.hargaBaruNumeric.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.hargaBaruNumeric.Name = "hargaBaruNumeric";
            this.hargaBaruNumeric.Size = new System.Drawing.Size(216, 21);
            this.hargaBaruNumeric.TabIndex = 73;
            this.hargaBaruNumeric.Visible = false;
            // 
            // jatuhtempoDateTimePicker
            // 
            this.jatuhtempoDateTimePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jatuhtempoDateTimePicker.Location = new System.Drawing.Point(296, 304);
            this.jatuhtempoDateTimePicker.Name = "jatuhtempoDateTimePicker";
            this.jatuhtempoDateTimePicker.Size = new System.Drawing.Size(216, 21);
            this.jatuhtempoDateTimePicker.TabIndex = 72;
            this.jatuhtempoDateTimePicker.Visible = false;
            // 
            // bayarNumeric
            // 
            this.bayarNumeric.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayarNumeric.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.bayarNumeric.Location = new System.Drawing.Point(296, 268);
            this.bayarNumeric.Name = "bayarNumeric";
            this.bayarNumeric.Size = new System.Drawing.Size(216, 21);
            this.bayarNumeric.TabIndex = 71;
            this.bayarNumeric.Visible = false;
            // 
            // bayarText
            // 
            this.bayarText.AutoSize = true;
            this.bayarText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayarText.Location = new System.Drawing.Point(43, 274);
            this.bayarText.Name = "bayarText";
            this.bayarText.Size = new System.Drawing.Size(57, 23);
            this.bayarText.TabIndex = 70;
            this.bayarText.Text = "Bayar";
            this.bayarText.Visible = false;
            // 
            // jatuhtempoText
            // 
            this.jatuhtempoText.AutoSize = true;
            this.jatuhtempoText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jatuhtempoText.Location = new System.Drawing.Point(43, 308);
            this.jatuhtempoText.Name = "jatuhtempoText";
            this.jatuhtempoText.Size = new System.Drawing.Size(120, 23);
            this.jatuhtempoText.TabIndex = 69;
            this.jatuhtempoText.Text = "Jatuh Tempo";
            this.jatuhtempoText.Visible = false;
            // 
            // hutangCheckbox
            // 
            this.hutangCheckbox.AutoSize = true;
            this.hutangCheckbox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hutangCheckbox.Location = new System.Drawing.Point(47, 235);
            this.hutangCheckbox.Name = "hutangCheckbox";
            this.hutangCheckbox.Size = new System.Drawing.Size(91, 27);
            this.hutangCheckbox.TabIndex = 68;
            this.hutangCheckbox.Text = "Hutang";
            this.hutangCheckbox.UseVisualStyleBackColor = true;
            this.hutangCheckbox.CheckedChanged += new System.EventHandler(this.hutangCheckbox_CheckedChanged);
            // 
            // langgananCheckbox
            // 
            this.langgananCheckbox.AutoSize = true;
            this.langgananCheckbox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langgananCheckbox.Location = new System.Drawing.Point(47, 161);
            this.langgananCheckbox.Name = "langgananCheckbox";
            this.langgananCheckbox.Size = new System.Drawing.Size(123, 27);
            this.langgananCheckbox.TabIndex = 67;
            this.langgananCheckbox.Text = "Langganan";
            this.langgananCheckbox.UseVisualStyleBackColor = true;
            this.langgananCheckbox.CheckedChanged += new System.EventHandler(this.langgananCheckbox_CheckedChanged);
            // 
            // pengirimanDateTimePicker
            // 
            this.pengirimanDateTimePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengirimanDateTimePicker.Location = new System.Drawing.Point(296, 124);
            this.pengirimanDateTimePicker.Name = "pengirimanDateTimePicker";
            this.pengirimanDateTimePicker.Size = new System.Drawing.Size(216, 21);
            this.pengirimanDateTimePicker.TabIndex = 66;
            this.pengirimanDateTimePicker.ValueChanged += new System.EventHandler(this.pengirimanDateTimePicker_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 23);
            this.label10.TabIndex = 65;
            this.label10.Text = "Tanggal Pengiriman";
            // 
            // hargaBaruText
            // 
            this.hargaBaruText.AutoSize = true;
            this.hargaBaruText.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hargaBaruText.Location = new System.Drawing.Point(42, 198);
            this.hargaBaruText.Name = "hargaBaruText";
            this.hargaBaruText.Size = new System.Drawing.Size(106, 23);
            this.hargaBaruText.TabIndex = 64;
            this.hargaBaruText.Text = "Harga Baru";
            this.hargaBaruText.Visible = false;
            // 
            // custTextbox
            // 
            this.custTextbox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custTextbox.Location = new System.Drawing.Point(296, 19);
            this.custTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.custTextbox.Name = "custTextbox";
            this.custTextbox.Size = new System.Drawing.Size(216, 20);
            this.custTextbox.TabIndex = 74;
            this.custTextbox.TextChanged += new System.EventHandler(this.custTextbox_TextChanged);
            // 
            // selesaiButton
            // 
            this.selesaiButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selesaiButton.Location = new System.Drawing.Point(236, 369);
            this.selesaiButton.Name = "selesaiButton";
            this.selesaiButton.Size = new System.Drawing.Size(130, 30);
            this.selesaiButton.TabIndex = 75;
            this.selesaiButton.Text = "Selesai\r\n\r\n";
            this.selesaiButton.UseVisualStyleBackColor = true;
            this.selesaiButton.Click += new System.EventHandler(this.selesaiButton_Click);
            // 
            // alamatTextbox
            // 
            this.alamatTextbox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatTextbox.Location = new System.Drawing.Point(296, 53);
            this.alamatTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.alamatTextbox.Name = "alamatTextbox";
            this.alamatTextbox.Size = new System.Drawing.Size(216, 20);
            this.alamatTextbox.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "Alamat";
            // 
            // teleponTextbox
            // 
            this.teleponTextbox.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleponTextbox.Location = new System.Drawing.Point(296, 87);
            this.teleponTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.teleponTextbox.Name = "teleponTextbox";
            this.teleponTextbox.Size = new System.Drawing.Size(216, 20);
            this.teleponTextbox.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nomor Telepon";
            // 
            // PopupTransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teleponTextbox);
            this.Controls.Add(this.alamatTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selesaiButton);
            this.Controls.Add(this.custTextbox);
            this.Controls.Add(this.hargaBaruNumeric);
            this.Controls.Add(this.jatuhtempoDateTimePicker);
            this.Controls.Add(this.bayarNumeric);
            this.Controls.Add(this.bayarText);
            this.Controls.Add(this.jatuhtempoText);
            this.Controls.Add(this.hutangCheckbox);
            this.Controls.Add(this.langgananCheckbox);
            this.Controls.Add(this.pengirimanDateTimePicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hargaBaruText);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PopupTransaksiPenjualan";
            this.Text = "Rincian Pelanggan";
            this.Load += new System.EventHandler(this.PopupTransaksiPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hargaBaruNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayarNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown hargaBaruNumeric;
        private System.Windows.Forms.DateTimePicker jatuhtempoDateTimePicker;
        private System.Windows.Forms.NumericUpDown bayarNumeric;
        private System.Windows.Forms.Label bayarText;
        private System.Windows.Forms.Label jatuhtempoText;
        private System.Windows.Forms.CheckBox hutangCheckbox;
        private System.Windows.Forms.CheckBox langgananCheckbox;
        private System.Windows.Forms.DateTimePicker pengirimanDateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label hargaBaruText;
        private System.Windows.Forms.TextBox custTextbox;
        private System.Windows.Forms.Button selesaiButton;
        private System.Windows.Forms.TextBox alamatTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teleponTextbox;
        private System.Windows.Forms.Label label2;
    }
}