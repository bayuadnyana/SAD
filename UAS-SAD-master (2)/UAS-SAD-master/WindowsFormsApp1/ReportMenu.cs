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
    public partial class ReportMenu : Form
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;user=root;password=;database=ud_sinar_mas";
            string sql = "SELECT 'All' AS `nama_barang`,'All' AS `barang.barang_id` UNION SELECT nama_barang, barang.barang_id FROM `barang`";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter();
            MySqlCommand sqlCommand = new MySqlCommand(sql, connection);
            DataTable ds = new DataTable();
            connection.Open();
            dataadapter.SelectCommand = sqlCommand;
            dataadapter.Fill(ds);
            connection.Close();
            cbBarang.DisplayMember = "nama_barang";
            cbBarang.ValueMember = "barang.barang_id";
            cbBarang.DataSource = ds;
        }
        public static string Barangku;
        public static string Reportku;
        public static string Awalan;
        public static string Akhiran;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbBarang.Text == "")
            {
                MessageBox.Show("Tolong Masukan Barang Yang Di Cari!");
            }
            else if (cbReport.Text == "")
            {
                MessageBox.Show("Tolong Masukan Report Yang Di Cari!");
            }
            else
            {
                this.Hide();
                ReportPenjualan pe = new ReportPenjualan();
                Barangku = cbBarang.Text;
                Reportku = cbReport.Text;
                Awalan = timeAwal.Text;
                Akhiran = timeAkhir.Text;
                pe.ShowDialog();
            }
        }

        private void timeAwal_ValueChanged(object sender, EventArgs e)
        {
            timeAwal.Format = DateTimePickerFormat.Custom;
            timeAwal.CustomFormat = "yyyy-MM-dd ";
        }

        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReport.SelectedItem == "Sisa Stock")
            {
                timeAwal.Enabled = false;
                timeAkhir.Enabled = false;
            }
        }
    }
}
