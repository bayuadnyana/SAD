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
    public partial class KontakSupplier : Form
    {
        public KontakSupplier()
        {
            InitializeComponent();
        }

        private void KontakSupplier_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=ud_sinar_mas";
            string sqlini = "SELECT nama_supplier 'Nama' , alamat 'Alamat' , no_telepon 'Nomor Telepon', supplier_id, 'Edit' as `Ubah` FROM supplier";
            MySqlConnection connection = new MySqlConnection(connectionString);
            SqlFunction sql = new SqlFunction(connectionString);
            DataTable data = sql.selectQuery(sqlini);
            dgvkontak.DataSource = data;
            dgvkontak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvkontak.Columns["supplier_id"].Visible = false;
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=ud_sinar_mas";
            string sqlini = "SELECT nama_supplier 'Nama' , alamat 'Alamat' , no_telepon 'Nomor Telepon', supplier_id, 'Edit' as `Ubah` FROM supplier WHERE nama_supplier LIKE '%" + searchbox.Text + "%'";
            MySqlConnection connection = new MySqlConnection(connectionString);
            SqlFunction sql = new SqlFunction(connectionString);
            DataTable data = sql.selectQuery(sqlini);
            dgvkontak.DataSource = data;
            dgvkontak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvkontak.Columns["supplier_id"].Visible = false;
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            var ubah = new PopUpTambahkanKontakSupplier();
            ubah.ShowDialog();
        }

        private void dgvkontak_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                UbahKontakSupplier edit = new UbahKontakSupplier();
                edit.tbnama.Text = this.dgvkontak.CurrentRow.Cells[0].Value.ToString();
                edit.tbalamat.Text = this.dgvkontak.CurrentRow.Cells[1].Value.ToString();
                edit.tbnotelp.Text = this.dgvkontak.CurrentRow.Cells[2].Value.ToString();
                edit.tbid.Text = this.dgvkontak.CurrentRow.Cells[3].Value.ToString();
                edit.ShowDialog();
                KontakSupplier_Load(sender, e);
            }
        }

        private void dgvkontak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                UbahKontakSupplier edit = new UbahKontakSupplier();
                edit.tbnama.Text = this.dgvkontak.CurrentRow.Cells[0].Value.ToString();
                edit.tbalamat.Text = this.dgvkontak.CurrentRow.Cells[1].Value.ToString();
                edit.tbnotelp.Text = this.dgvkontak.CurrentRow.Cells[2].Value.ToString();
                edit.tbid.Text = this.dgvkontak.CurrentRow.Cells[3].Value.ToString();
                edit.ShowDialog();
                KontakSupplier_Load(sender, e);
            }
        }
    }
}
