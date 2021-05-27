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
    public partial class KontakCustomer : Form
    {
        public KontakCustomer()
        {
            InitializeComponent();
        }

        private void KontakCustomer_load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=ud_sinar_mas";
            string sqlini = "SELECT nama_customer 'Nama' , alamat 'Alamat' , no_telepon 'Nomor Telepon', customer_id, 'Edit' as `Ubah` FROM customer";
            MySqlConnection connection = new MySqlConnection(connectionString);
            SqlFunction sql = new SqlFunction(connectionString);
            DataTable data = sql.selectQuery(sqlini);
            dgvkontak.DataSource = data;
            dgvkontak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvkontak.Columns["customer_id"].Visible = false;
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            var ubah = new PopUpTambahkanKontakCustomer();
            ubah.ShowDialog();
            KontakCustomer_load(sender, e);
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=ud_sinar_mas";
            string sqlini = "SELECT nama_customer 'Nama' , alamat 'Alamat' , no_telepon 'Nomor Telepon', customer_id, 'Edit' as `Ubah` FROM customer WHERE nama_customer LIKE '%" + searchbox.Text+"%'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            SqlFunction sql = new SqlFunction(connectionString);
            DataTable data = sql.selectQuery(sqlini);
            dgvkontak.DataSource = data;
            dgvkontak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvkontak.Columns["customer_id"].Visible = false;
        }

        private void dgvkontak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                UbahKontakCustomer edit = new UbahKontakCustomer();
                edit.tbnama.Text = this.dgvkontak.CurrentRow.Cells[0].Value.ToString();
                edit.tbalamat.Text = this.dgvkontak.CurrentRow.Cells[1].Value.ToString();
                edit.tbnotelp.Text = this.dgvkontak.CurrentRow.Cells[2].Value.ToString();
                edit.tbid.Text = this.dgvkontak.CurrentRow.Cells[3].Value.ToString();
                edit.ShowDialog();
                KontakCustomer_load(sender, e);
            }
        }
    }
}
