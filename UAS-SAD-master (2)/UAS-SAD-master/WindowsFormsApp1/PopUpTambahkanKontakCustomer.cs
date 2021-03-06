using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class PopUpTambahkanKontakCustomer : Form
    {
        public PopUpTambahkanKontakCustomer()
        {
            InitializeComponent();
        }


        private void btbatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsimpan_Click(object sender, EventArgs e)
        {
            if (tbnama.Text == "" || tbalamat.Text == "" || tbnotelp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong");
            }
            else
            {

                string connectionString = "server=localhost;uid=root;pwd=;database=ud_sinar_mas";
                MySqlConnection conn = new MySqlConnection(connectionString);
                string sql = "INSERT INTO customer (nama_customer, alamat, no_telepon) VALUES ('"+tbnama.Text+"', '" +tbalamat.Text+"', '"+tbnotelp.Text+"')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kontak berhasil ditambahkan");
                conn.Close();
                this.Close();
            }
        }

        private void tbnotelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
