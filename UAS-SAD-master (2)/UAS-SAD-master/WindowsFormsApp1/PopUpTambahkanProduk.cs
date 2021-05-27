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
    public partial class PopUpTambahkanProduk : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=ud_sinar_mas");
        MySqlCommand cmd = new MySqlCommand();
        public PopUpTambahkanProduk()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void PopUpTambahkanProduk_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            DataTable dt1 = null;
            using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;user=root;password=;database=ud_sinar_mas")) ;
            {
                con.Open();
                string strCmd = "SELECT nama_barang ,barang_id from barang";
                using (MySqlCommand cmd = new MySqlCommand(strCmd, con)) ;
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(strCmd, con);
                    dt = new DataTable("barang");
                    da.Fill(dt);
                    comboBox1.DisplayMember = "nama_barang";
                    comboBox1.ValueMember = "barang_id";
                    comboBox1.DataSource = dt;
                }
                string strCmd1 = "SELECT nama_supplier ,supplier_id from supplier";
                using (MySqlCommand cmd = new MySqlCommand(strCmd1, con)) ;
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(strCmd1, con);
                    dt1 = new DataTable("supplier");
                    da.Fill(dt1);
                    comboBox2.DisplayMember = "nama_supplier";
                    comboBox2.ValueMember = "supplier_id";
                    comboBox2.DataSource = dt1;
                }
            }
            string connectionString = "datasource=localhost;port=3306;user=root;password=;database=ud_sinar_mas";
            string sql = "SELECT nama_supplier, nama_barang, jumlah_barang, harga_jual, harga_beli FROM `barang`, `barang_supplier`, supplier WHERE barang.barang_id = barang_supplier.barang_id AND barang_supplier.supplier_id = supplier.supplier_id";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Authors_table");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Authors_table";
            dataGridView1.Refresh();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            bool IsDuplicate = false;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (comboBox2.Text == dataGridView1.Rows[i].Cells[0].Value.ToString() && comboBox1.Text == dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    MessageBox.Show("Sudah ada");
                    IsDuplicate = true;
                }
            }
            if (!IsDuplicate)
            {
                string connectionString = "datasource=localhost;port=3306;user=root;password=;database=ud_sinar_mas";
                string sql = "INSERT INTO `barang_supplier`(`barang_id`, `supplier_id`, `harga_jual`, `jumlah_barang`) VALUES ('" + comboBox1.SelectedValue + "','" + comboBox2.SelectedValue + "','" + numericUpDown1.Value + "','" + numericUpDown2.Value + "') ";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "Authors_table");
                connection.Close();
                this.Close();
            }

        }
        public void lihat_data()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
