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
    public partial class UbahProduk : Form
    {
        public UbahProduk()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UbahProduk_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownsisastock_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;user=root;password=;database=ud_sinar_mas";
            string sql = "UPDATE barang_supplier, supplier, barang SET harga_beli='" + this.numericupdownharga.Value + "',jumlah_barang = '"+ this.numericUpDownsisastock.Value +"' WHERE barang_supplier.supplier_id = supplier.supplier_id AND barang.barang_id = barang_supplier.barang_id AND nama_supplier =  '"+this.ubahnamaproduk.Text+"' AND nama_barang = '"+ this.ubahnamasupplier.Text+"'; ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;user=root;password=;database=ud_sinar_mas";
            string sql = "DELETE barang_supplier FROM barang, barang_supplier, supplier WHERE barang.barang_id = barang_supplier.barang_id AND barang_supplier.supplier_id = supplier.supplier_id AND nama_supplier = '" + this.ubahnamaproduk.Text + "' AND nama_barang = '" + this.ubahnamasupplier.Text + "' AND harga_beli = '" + this.numericupdownharga.Text + "' AND jumlah_barang = '" + this.numericUpDownsisastock.Text + "'; ";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
