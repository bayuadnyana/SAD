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
    public partial class ReportPenjualan : Form
    {
        public ReportPenjualan()
        {
            InitializeComponent();
        }

        private void ReportPenjualan_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;user=root;password=;database=ud_sinar_mas;Convert Zero Datetime = True";
            string sql = "";
            //Penjualan//
            if (ReportMenu.Reportku == "Penjualan" && ReportMenu.Barangku == "All")
            {
                lreport.Text = "Report Penjualan";
                sql = "SELECT nama_barang 'Barang', jumlah_pemesanan 'QTY', harga_jual'Harga/Item', sub_total'Total', tanggal_penjualan'Tanggal', nama_customer 'Customer' FROM `barang`, `barang_supplier`, `transaksi_penjualan`, `penjualan_barang_supplier`, `customer`, `supplier` WHERE tanggal_penjualan BETWEEN CAST('" + ReportMenu.Awalan + "' AS DATE) AND CAST('" + ReportMenu.Akhiran + "' AS DATE) AND barang.barang_id = barang_supplier.barang_id AND barang_supplier.supplier_id = supplier.supplier_id AND transaksi_penjualan.customer_id = customer.customer_id AND penjualan_barang_supplier.penjualan_id = transaksi_penjualan.penjualan_id AND barang_supplier.barang_supplier_id = penjualan_barang_supplier.barang_supplier_id ORDER BY tanggal_penjualan";
            }
            else if (ReportMenu.Reportku == "Penjualan")
            {
                lreport.Text = "Report Penjualan";
                sql = "SELECT nama_barang 'Barang', jumlah_pemesanan 'QTY', harga_jual'Harga/Item', sub_total'Total', tanggal_penjualan'Tanggal', nama_customer 'Customer' FROM `barang`, `barang_supplier`, `transaksi_penjualan`, `penjualan_barang_supplier`, `customer`, `supplier` WHERE tanggal_penjualan BETWEEN CAST('" + ReportMenu.Awalan + "' AS DATE) AND CAST('" + ReportMenu.Akhiran + "' AS DATE) AND barang.barang_id = barang_supplier.barang_id AND barang_supplier.supplier_id = supplier.supplier_id AND transaksi_penjualan.customer_id = customer.customer_id AND penjualan_barang_supplier.penjualan_id = transaksi_penjualan.penjualan_id AND barang_supplier.barang_supplier_id = penjualan_barang_supplier.barang_supplier_id AND nama_barang ='" + ReportMenu.Barangku + "'";
            }
            //PEMBELIAN//
            else if (ReportMenu.Reportku == "Pembelian" && ReportMenu.Barangku == "All")
            {
                lreport.Text = "Report Pembelian";
                sql = "SELECT nama_barang as 'Barang', jumlah_pembelian as 'QTY', harga_beli as 'Harga', sub_total as 'Total', tanggal_pembelian as 'Tanggal', nama_supplier as 'Supplier'from barang a, pembelian_barang_supplier b, barang_supplier c, transaksi_pembelian d, supplier e WHERE tanggal_pembelian BETWEEN CAST('" + ReportMenu.Awalan + "' AS DATE) AND CAST('" + ReportMenu.Akhiran + "' AS DATE) AND c.barang_id = a.barang_id AND c.barang_supplier_id = b.barang_supplier_id AND e.supplier_id = c.supplier_id ";
            }
            else if (ReportMenu.Reportku == "Pembelian")
            {
                lreport.Text = "Report Pembelian";
                sql = "SELECT nama_barang as 'Barang', jumlah_pembelian as 'QTY', harga_beli as 'Harga', sub_total as 'Total', tanggal_pembelian as 'Tanggal', nama_supplier as 'Supplier'from barang a, pembelian_barang_supplier b, barang_supplier c, transaksi_pembelian d, supplier e WHERE tanggal_pembelian BETWEEN CAST('" + ReportMenu.Awalan + "' AS DATE) AND CAST('" + ReportMenu.Akhiran + "' AS DATE) AND c.barang_id = a.barang_id AND c.barang_supplier_id = b.barang_supplier_id AND e.supplier_id = c.supplier_id  AND nama_barang ='" + ReportMenu.Barangku + "'";
            }
            //SISA STOCK//
            else if (ReportMenu.Reportku == "Sisa Stock" && ReportMenu.Barangku == "All")
            {
                lreport.Text = "Report Sisa Stock";
                sql = "SELECT nama_barang 'Barang', nama_supplier 'Supplier', harga_beli 'Harga/Item', jumlah_barang 'Quantity', (jumlah_barang - SUM(jumlah_pemesanan))  'Sisa Stock' FROM barang, barang_supplier, supplier, penjualan_barang_supplier WHERE  barang.barang_id = barang_supplier.barang_id AND barang_supplier.supplier_id = supplier.supplier_id AND penjualan_barang_supplier.barang_supplier_id = barang_supplier.barang_supplier_id GROUP BY barang_supplier.barang_supplier_id";
            }
            else if (ReportMenu.Reportku == "Sisa Stock")
            {
                lreport.Text = "Report Sisa Stock";
                sql = "SELECT nama_barang 'Barang', nama_supplier 'Supplier', harga_beli 'Harga/Item', jumlah_barang 'Quantity', (jumlah_barang - SUM(jumlah_pemesanan))  'Sisa Stock' FROM barang, barang_supplier, supplier, penjualan_barang_supplier WHERE barang.barang_id = barang_supplier.barang_id AND barang_supplier.supplier_id = supplier.supplier_id AND penjualan_barang_supplier.barang_supplier_id = barang_supplier.barang_supplier_id  AND nama_barang ='" + ReportMenu.Barangku + "' GROUP BY barang_supplier.barang_supplier_id";
            }
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            MySqlCommand sqlCommand = new MySqlCommand(sql, connection);
            DataTable ds = new DataTable();
            connection.Open();
            dataadapter.SelectCommand = sqlCommand;
            dataadapter.Fill(ds);
            connection.Close();
            dgPenjualan.DataSource = ds;
            dgPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //SELECT nama_barang, jumlah_pemesanan, harga_jual, sub_total, tanggal_penjualan, nama_customer FROM `barang`, `barang_supplier`, `transaksi_penjualan`, `penjualan_barang_supplier`, `customer`, `supplier` WHERE barang.barang_id = barang_supplier.barang_id AND barang_supplier.supplier_id = supplier.supplier_id AND transaksi_penjualan.customer_id = customer.customer_id AND penjualan_barang_supplier.penjualan_id = transaksi_penjualan.penjualan_id//
    }
}

