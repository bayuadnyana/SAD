using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BelajarDoang : Form
    {
        int PW;
        bool Hided;


        public BelajarDoang()
        {
            InitializeComponent();
            PW = PNisi.Width;
            Hided = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided) {
                PNisi.Width = PNisi.Width + 20;
                if(PNisi.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            } else {
                PNisi.Width = PNisi.Width - 20;
                if (PNisi.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }

            
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Hided) button1.Text = "H\nI\nD\nE";
            else button1.Text = "S\nH\nO\nW";
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
