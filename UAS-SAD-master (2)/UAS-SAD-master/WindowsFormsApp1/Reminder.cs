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
    public partial class Reminder : Form
    {
        //MySqlConnection sqlConnection;
        //MySqlCommand sqlCommand;
        //MySqlDataAdapter sqlAdapter;
        //string sqlQuery = "";
        //string connectString = "server=localhost;uid=root;pwd=root;database=ud_sinar_mas;";

        public Reminder()
        {
            InitializeComponent();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;uid=root;pwd=;database=ud_sinar_mas";
                string sqlini = "SELECT tanggal_penjualan 'Tanggal' , nama_customer 'Pembeli', alamat 'Alamat' , no_telepon 'Nomor Telepon', transaksi_penjualan.penjualan_id, 'Detail' as `Cek` FROM transaksi_penjualan, penjualan_barang_supplier, customer, barang WHERE transaksi_penjualan.customer_id = customer.customer_id AND penjualan_barang_supplier.penjualan_id = transaksi_penjualan.penjualan_id AND MONTH(tanggal_penjualan) = MONTH(CURRENT_DATE) and DAY(tanggal_penjualan) >= DAY(CURRENT_DATE) GROUP BY nama_customer ORDER BY tanggal_penjualan";
                string sqldepan = "SELECT tanggal_penjualan 'Tanggal' , nama_customer 'Pembeli', alamat 'Alamat' , no_telepon 'Nomor Telepon', transaksi_penjualan.penjualan_id, 'Detail' as `Cek` FROM transaksi_penjualan, penjualan_barang_supplier, customer, barang WHERE transaksi_penjualan.customer_id = customer.customer_id AND penjualan_barang_supplier.penjualan_id = transaksi_penjualan.penjualan_id and MONTH(tanggal_penjualan) = MONTH(CURRENT_DATE) + 1 GROUP BY nama_customer ORDER BY tanggal_penjualan LIMIT 3";
                string sqlutang = "SELECT nama_customer 'Customer', grand_total 'Total Penjualan', total_bayar 'Total Pembayaran', (grand_total - total_bayar) 'Sisah Pembayaran', tanggal_jatuh_tempo 'Jatuh Tempo' FROM customer, transaksi_penjualan WHERE `status` = 0 AND customer.customer_id = transaksi_penjualan.customer_id AND DAY(tanggal_jatuh_tempo) >= DAY(CURRENT_DATE)";
                MySqlConnection connection = new MySqlConnection(connectionString);
                SqlFunction sql = new SqlFunction(connectionString);
                DataTable data1 = sql.selectQuery(sqlini);
                DataTable data2 = sql.selectQuery(sqldepan);
                DataTable data3 = sql.selectQuery(sqlutang);
                dgvbulanini.DataSource = data1;
                dgvbulandepan.DataSource = data2;
                dgvutang.DataSource = data3;
                dgvbulanini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvbulandepan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvutang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvbulanini.Columns["penjualan_id"].Visible = false;
                dgvbulandepan.Columns["penjualan_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvbulanini_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                DetailReminder edit = new DetailReminder();
                edit.tbid.Text = this.dgvbulanini.CurrentRow.Cells[4].Value.ToString();
                edit.labelnama.Text = dgvbulanini.CurrentRow.Cells[1].Value.ToString();
                edit.labelalamat.Text = dgvbulanini.CurrentRow.Cells[2].Value.ToString();
                edit.labelnotelp.Text = dgvbulanini.CurrentRow.Cells[3].Value.ToString();
                edit.ShowDialog();
            }
        }

        private void dgvbulandepan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 5)
            {
                DetailReminder edit = new DetailReminder();
                edit.tbid.Text = this.dgvbulandepan.CurrentRow.Cells[4].Value.ToString();
                edit.ShowDialog();
            }
        }
    }
}
