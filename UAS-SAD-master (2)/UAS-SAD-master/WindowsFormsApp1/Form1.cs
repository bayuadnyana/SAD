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
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sembarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            this.StartPosition = FormStartPosition.CenterScreen;

            FormPembelian fp= new FormPembelian();
            fp.MdiParent = this;
            fp.Show();
            fp.Location = new Point(0, 0);
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            this.StartPosition = FormStartPosition.CenterScreen;

            FormPenjualan fj = new FormPenjualan();            
            fj.MdiParent = this;
            fj.Show();
            fj.Location = new Point(0, 0);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            this.StartPosition = FormStartPosition.CenterScreen;

            KontakCustomer kt = new KontakCustomer();
            kt.MdiParent = this;
            kt.Show();
            kt.Location = new Point(0, 0);
        }

        private void reminderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            this.StartPosition = FormStartPosition.CenterScreen;

            Reminder rm = new Reminder();
            rm.MdiParent = this;
            rm.Show();
            rm.Location = new Point(0, 0);
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            this.StartPosition = FormStartPosition.CenterScreen;

            StockBarang sb = new StockBarang();
            sb.MdiParent = this;
            sb.Show();
            sb.Location = new Point(0, 0);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            this.StartPosition = FormStartPosition.CenterScreen;

            ReportMenu rn = new ReportMenu();
            rn.MdiParent = this;
            rn.Show();
            rn.Location = new Point(0, 0);
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            this.StartPosition = FormStartPosition.CenterScreen;

            KontakSupplier kp = new KontakSupplier();
            kp.MdiParent = this;
            kp.Show();
            kp.Location = new Point(0, 0);
        }        
    }
}
