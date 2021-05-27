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
    public partial class DetailReminder : Form
    {
        public DetailReminder()
        {
            InitializeComponent();
        }

        private void DetailReminder_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;uid=root;pwd=;database=ud_sinar_mas";
                string sqldetail = "SELECT barang.nama_barang 'Barang' ,  penjualan_barang_supplier.jumlah_pemesanan 'Quantity', barang_supplier.harga_jual 'Harga' , penjualan_barang_supplier.sub_total 'Jumlah' FROM barang, penjualan_barang_supplier, barang_supplier, transaksi_penjualan WHERE barang.barang_id = barang_supplier.barang_id AND penjualan_barang_supplier.barang_supplier_id = barang_supplier.barang_supplier_id AND transaksi_penjualan.penjualan_id = penjualan_barang_supplier.penjualan_id AND transaksi_penjualan.penjualan_id = '" + tbid.Text + "'";
                string sqllabel = "SELECT tanggal_penjualan FROM transaksi_penjualan WHERE penjualan_id = '" + tbid.Text + "'";
                MySqlConnection connection = new MySqlConnection(connectionString);
                SqlFunction sql = new SqlFunction(connectionString);
                DataTable label = sql.selectQuery(sqllabel);
                string tanggal = label.Rows[0]["tanggal_penjualan"].ToString();
                DateTime tanggalDateTime = DateTime.ParseExact(tanggal, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                string tanggalTransaksi = tanggalDateTime.ToString("dd-MM-yyyy");
                DataTable data = sql.selectQuery(sqldetail);
                dgvdetail.DataSource = data;
                lebeldetail.Text = tanggalTransaksi;
                dgvdetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
