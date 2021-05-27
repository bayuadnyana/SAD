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
    public partial class PopupTransaksiPenjualan : Form
    {
        public string connString = "datasource=127.0.0.1;port=3306;username=root;password=;Convert Zero Datetime = True";
        private SqlFunction sqlFunc;
        public string penjualanID;
        public FormPenjualan formPenjualan;
        public PopupTransaksiPenjualan()
        {
            InitializeComponent();
            
        }

        private void PopupTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            sqlFunc = new SqlFunction(connString);
            
            //Fill AutoComplete Customer Name
            string sqlQuery = "SELECT cs.nama_customer `Nama Customer` FROM ud_sinar_mas.customer cs";
            DataTable customerDt = new DataTable();
            customerDt = sqlFunc.selectQuery(sqlQuery);

            AutoCompleteStringCollection customerCollectionString = new AutoCompleteStringCollection();
            for (int i = 0; i < customerDt.Rows.Count; i++)
            {
                customerCollectionString.Add(customerDt.Rows[i]["Nama Customer"].ToString());
            }

            //AutoSuggest
            custTextbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            custTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            custTextbox.AutoCompleteCustomSource = customerCollectionString;
        }
        //pengirimanDateTimePicker.Value.ToString("yyyy-MM-dd")                

        private void langgananCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //Langganan
            if (langgananCheckbox.Checked == true)
            {                               
                hargaBaruNumeric.Visible = true;
                hargaBaruText.Visible = true;
            }
            else
            {             
                hargaBaruText.Visible = false;
                hargaBaruNumeric.Visible = false;
            }
        }

        private void hutangCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (hutangCheckbox.Checked == true)
            {
                bayarNumeric.Visible = true;
                jatuhtempoDateTimePicker.Visible = true;
                bayarText.Visible = true;
                jatuhtempoText.Visible = true;
            }
            else
            {
                bayarNumeric.Visible = false;
                jatuhtempoDateTimePicker.Visible = false;
                bayarText.Visible = false;
                jatuhtempoText.Visible = false;
            }
        }

        private void pengirimanDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            jatuhtempoDateTimePicker.MinDate = pengirimanDateTimePicker.Value;
            jatuhtempoDateTimePicker.Value = pengirimanDateTimePicker.Value;
        }

        private void selesaiButton_Click(object sender, EventArgs e)
        {
            //Check if content filled or not
            bool clearanceCheck = completionChecker();
            
            //Data insertion if complete
            if(clearanceCheck == true)
            {
                //Getting data to update : PenjualanID, Create new id customer if not exist, grand total, tanggal penjualan, pembayaran id (0: Hutang, 1: Lunas), total_bayar if hutang, tanggal jatuh tempo if hutang, status
                //Find Penjualan ID
                string idPenjualan = penjualanID;

                //Set Customer ID
                string idCustomer;
                string sqlQuery = "SELECT customer_id `ID Customer` FROM ud_sinar_mas.customer WHERE UPPER(nama_customer) = UPPER('"+ custTextbox.Text +"')";
                DataTable custDt = sqlFunc.selectQuery(sqlQuery);
                int custExist = custDt.Rows.Count;

                if(custExist > 0)
                {
                    idCustomer = custDt.Rows[0]["ID Customer"].ToString();
                }
                else
                {
                    sqlQuery = "INSERT INTO ud_sinar_mas.customer(`nama_customer`, `alamat`, `no_telepon`) VALUES ('"+ custTextbox.Text + "', '" + alamatTextbox + "', '" + teleponTextbox.Text +"')";
                    sqlFunc.insertQuery(sqlQuery);

                    sqlQuery = "SELECT MAX(auto_num) `Nomor ID` FROM ud_sinar_mas.customer";
                    DataTable forIdCustomer = sqlFunc.selectQuery(sqlQuery);
                    idCustomer = "C" + forIdCustomer.Rows[0]["Nomor ID"].ToString();
                }

                //Set Grand Total
                sqlQuery = "SELECT SUM(sub_total) `Grand Total` FROM ud_sinar_mas.penjualan_barang_supplier WHERE penjualan_id = '"+ idPenjualan +"'";
                DataTable grandDt = sqlFunc.selectQuery(sqlQuery);
                string grandTotal = grandDt.Rows[0]["Grand Total"].ToString();

                //Set Tanggal Penjualan                
                string tanggalPengiriman = pengirimanDateTimePicker.Value.ToString("yyyy-MM-dd");

                //Set Pembayaran ID
                //Set Total Bayar
                //Set Tanggal Jatuh Tempo
                //Set Status

                string pembayaranId;
                string totalBayar;
                string tanggalJatuhTempo;
                string status;
                if(hutangCheckbox.Checked == true)
                {
                    pembayaranId = "P1";
                    totalBayar = bayarNumeric.Value.ToString();
                    tanggalJatuhTempo = jatuhtempoDateTimePicker.Value.ToString("yyyy-MM-dd");
                    status = "0";
                }
                else
                {
                    pembayaranId = "P2";
                    totalBayar = grandTotal;
                    tanggalJatuhTempo = tanggalPengiriman;
                    status = "1";
                }
                
                //Insert Transaksi Penjualan
                sqlQuery = "UPDATE ud_sinar_mas.transaksi_penjualan SET customer_id = '"+ idCustomer +"', grand_total = '"+ grandTotal +"', tanggal_penjualan = '"+ tanggalPengiriman +"', pembayaran_id = '"+ pembayaranId +"', total_bayar = '"+ totalBayar +"', tanggal_jatuh_tempo = '"+ tanggalJatuhTempo +"', status = '"+ status +"' WHERE penjualan_id = '"+ idPenjualan +"'";
                sqlFunc.updateQuery(sqlQuery);



                //Update Stock
                StockReduction();

                //After insert event
                
                formPenjualan.status = true;
                formPenjualan.TransaksiPenjualan_OnLoad(sender, e);                
                this.Close();

            }
            //Not completed, give back MessageBox
            else
            {
                MessageBox.Show("Data tidak lengkap!");
            }

        }

        private void custTextbox_TextChanged(object sender, EventArgs e)
        {
            string namaCustomer = custTextbox.Text;
            string sqlQuery = "SELECT alamat `Alamat`, no_telepon `Nomor Telepon` FROM ud_sinar_mas.customer WHERE UPPER(nama_customer) = UPPER('" + namaCustomer + "')";
            DataTable custDt = sqlFunc.selectQuery(sqlQuery);
            int custExist = custDt.Rows.Count;
            if (custExist > 0)
            {
                custInfoDisabler();
                alamatTextbox.Text = custDt.Rows[0]["Alamat"].ToString();
                teleponTextbox.Text = custDt.Rows[0]["Nomor Telepon"].ToString();
            }
            else
            {
                custInfoEnabler();
                alamatTextbox.Text = "";
                teleponTextbox.Text = "";
            }
        }

        /*
        ///////////////////////////
          Functions and Procedures
        ///////////////////////////
        */

        private void StockReduction()
        {
            string sqlQuery;
            int itemCount = formPenjualan.counter;
            string[] barangsupplierId = formPenjualan.barangsupplierIdPublic;
            int[] reductionAmmount = formPenjualan.ammountToReduce;
            for(int items = 0; items < itemCount; items++)
            {
                sqlQuery = "UPDATE ud_sinar_mas.barang_supplier SET jumlah_barang = jumlah_barang - "+ reductionAmmount[items].ToString() +" WHERE barang_supplier_id = '"+ barangsupplierId[items] +"'";
                sqlFunc.updateQuery(sqlQuery);
            }

        }

        private void custInfoEnabler()
        {
            alamatTextbox.Enabled = true;
            teleponTextbox.Enabled = true;
        }
        private void custInfoDisabler()
        {
            alamatTextbox.Enabled = false;
            teleponTextbox.Enabled = false;
        }

        private bool completionChecker()
        {
            bool clearance = true;
           
            //Check customer, alamat dan nomor telepon
            if(alamatTextbox.Text == "" || teleponTextbox.Text == "" || custTextbox.Text == "")
            {
                clearance = false;  
            }

            //Check harga baru if langganan checked
            if(langgananCheckbox.Checked == true)
            {
                if(hargaBaruNumeric.Value == 0)
                {
                    clearance = false;
                }
            }            

            return clearance;
        }

        
    }
}
