
namespace WindowsFormsApp1
{
    partial class PopupTransaksiPembelian
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
            this.jatuhtempoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.jatuhtempoText = new System.Windows.Forms.Label();
            this.pengirimanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selesaiButton
            // 
            this.selesaiButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selesaiButton.Location = new System.Drawing.Point(321, 180);
            this.selesaiButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selesaiButton.Name = "selesaiButton";
            this.selesaiButton.Size = new System.Drawing.Size(173, 37);
            this.selesaiButton.TabIndex = 80;
            this.selesaiButton.Text = "Selesai\r\n\r\n";
            this.selesaiButton.UseVisualStyleBackColor = true;
            this.selesaiButton.Click += new System.EventHandler(this.selesaiButton_Click);
            // 
            // jatuhtempoDateTimePicker
            // 
            this.jatuhtempoDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jatuhtempoDateTimePicker.Location = new System.Drawing.Point(388, 107);
            this.jatuhtempoDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jatuhtempoDateTimePicker.Name = "jatuhtempoDateTimePicker";
            this.jatuhtempoDateTimePicker.Size = new System.Drawing.Size(349, 32);
            this.jatuhtempoDateTimePicker.TabIndex = 79;
            this.jatuhtempoDateTimePicker.Visible = false;
            // 
            // jatuhtempoText
            // 
            this.jatuhtempoText.AutoSize = true;
            this.jatuhtempoText.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jatuhtempoText.Location = new System.Drawing.Point(59, 102);
            this.jatuhtempoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jatuhtempoText.Name = "jatuhtempoText";
            this.jatuhtempoText.Size = new System.Drawing.Size(170, 33);
            this.jatuhtempoText.TabIndex = 78;
            this.jatuhtempoText.Text = "Jatuh Tempo";
            this.jatuhtempoText.Visible = false;
            // 
            // pengirimanDateTimePicker
            // 
            this.pengirimanDateTimePicker.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengirimanDateTimePicker.Location = new System.Drawing.Point(388, 59);
            this.pengirimanDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pengirimanDateTimePicker.Name = "pengirimanDateTimePicker";
            this.pengirimanDateTimePicker.Size = new System.Drawing.Size(349, 32);
            this.pengirimanDateTimePicker.TabIndex = 77;
            this.pengirimanDateTimePicker.ValueChanged += new System.EventHandler(this.pengirimanDateTimePicker_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 33);
            this.label10.TabIndex = 76;
            this.label10.Text = "Tanggal Pengiriman";
            // 
            // PopupTransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 254);
            this.Controls.Add(this.selesaiButton);
            this.Controls.Add(this.jatuhtempoDateTimePicker);
            this.Controls.Add(this.jatuhtempoText);
            this.Controls.Add(this.pengirimanDateTimePicker);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PopupTransaksiPembelian";
            this.Text = "PopupTransaksiPembelian";
            this.Load += new System.EventHandler(this.PopupTransaksiPembelian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selesaiButton;
        private System.Windows.Forms.DateTimePicker jatuhtempoDateTimePicker;
        private System.Windows.Forms.Label jatuhtempoText;
        private System.Windows.Forms.DateTimePicker pengirimanDateTimePicker;
        private System.Windows.Forms.Label label10;
    }
}