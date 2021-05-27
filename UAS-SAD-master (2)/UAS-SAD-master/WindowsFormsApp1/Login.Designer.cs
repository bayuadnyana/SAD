
namespace WindowsFormsApp1
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.lbnama = new System.Windows.Forms.Label();
            this.lbpin = new System.Windows.Forms.Label();
            this.tbanama = new System.Windows.Forms.TextBox();
            this.tbpin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.BTlogin = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnama.Location = new System.Drawing.Point(236, 251);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(36, 13);
            this.lbnama.TabIndex = 0;
            this.lbnama.Text = "NAMA";
            // 
            // lbpin
            // 
            this.lbpin.AutoSize = true;
            this.lbpin.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpin.Location = new System.Drawing.Point(236, 292);
            this.lbpin.Name = "lbpin";
            this.lbpin.Size = new System.Drawing.Size(24, 13);
            this.lbpin.TabIndex = 1;
            this.lbpin.Text = "PIN";
            this.lbpin.Click += new System.EventHandler(this.lbpin_Click);
            // 
            // tbanama
            // 
            this.tbanama.Location = new System.Drawing.Point(329, 244);
            this.tbanama.Name = "tbanama";
            this.tbanama.Size = new System.Drawing.Size(198, 20);
            this.tbanama.TabIndex = 2;
            // 
            // tbpin
            // 
            this.tbpin.Location = new System.Drawing.Point(329, 291);
            this.tbpin.Name = "tbpin";
            this.tbpin.Size = new System.Drawing.Size(198, 20);
            this.tbpin.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.crispy_chips;
            this.pictureBox1.Location = new System.Drawing.Point(309, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(148)))), ((int)(((byte)(87)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 245);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(148)))), ((int)(((byte)(87)))));
            this.pictureBox4.Location = new System.Drawing.Point(-1, 429);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(800, 30);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.pictureBox5.Location = new System.Drawing.Point(-1, -20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 239);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.pictureBox6.Location = new System.Drawing.Point(760, -20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 239);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(148)))), ((int)(((byte)(87)))));
            this.pictureBox3.Location = new System.Drawing.Point(760, 214);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 245);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.pictureBox7.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(800, 30);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // BTlogin
            // 
            this.BTlogin.BorderColor = System.Drawing.Color.Silver;
            this.BTlogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(148)))), ((int)(((byte)(87)))));
            this.BTlogin.FlatAppearance.BorderSize = 0;
            this.BTlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTlogin.Location = new System.Drawing.Point(329, 358);
            this.BTlogin.Name = "BTlogin";
            this.BTlogin.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.BTlogin.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(73)))), ((int)(((byte)(101)))));
            this.BTlogin.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BTlogin.Size = new System.Drawing.Size(142, 34);
            this.BTlogin.TabIndex = 6;
            this.BTlogin.Text = "LOG IN";
            this.BTlogin.TextColor = System.Drawing.Color.White;
            this.BTlogin.UseVisualStyleBackColor = true;
            this.BTlogin.Click += new System.EventHandler(this.BTlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(798, 454);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTlogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbpin);
            this.Controls.Add(this.tbanama);
            this.Controls.Add(this.lbpin);
            this.Controls.Add(this.lbnama);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label lbpin;
        private System.Windows.Forms.TextBox tbanama;
        private System.Windows.Forms.TextBox tbpin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ePOSOne.btnProduct.Button_WOC BTlogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

