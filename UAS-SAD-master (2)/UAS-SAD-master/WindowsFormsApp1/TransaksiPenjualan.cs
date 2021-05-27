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
    public partial class FormPenjualan : Form
    {
        //Import SQL Command Objects
        public string connString = "datasource=127.0.0.1;port=3306;username=root;password=;Convert Zero Datetime = True";
        private SqlFunction sqlFunc;
        string newPenjualanID;
        string numberID;
        public bool status = false;
        public string[] barangsupplierIdPublic = new string[100];
        public int[] ammountToReduce = new int[100];
        public int counter = 0;

        public FormPenjualan()
        {
            InitializeComponent();
            FormClosing += formClosed;
        }

        //FORM LOAD
        public void TransaksiPenjualan_OnLoad(object sender, EventArgs e)
        {
            //Get SQL Command Objects
            sqlFunc = new SqlFunction(connString);

            //Buat Penjualan ID Baru Untuk SubNota
            string sqlQuery = "INSERT INTO ud_sinar_mas.transaksi_penjualan(tanggal_penjualan) VALUES (NOW())";
            sqlFunc.insertQuery(sqlQuery);
            
            sqlQuery = "SELECT MAX(auto_num) `MAX` FROM ud_sinar_mas.transaksi_penjualan";
            DataTable maxID = new DataTable();
            maxID = sqlFunc.selectQuery(sqlQuery);
            numberID = maxID.Rows[0]["MAX"].ToString();
            newPenjualanID = "J" + numberID;                       

            //Fill Riwayat Transaksi Penjualan
            refreshRiwayatTransaksiPenjualan();

            //Fill Semua Pesanan with Empty            
            refreshSemuaPesanan();

            //Fill Barang Combobox
            barangComboboxFill();
                                          
        }  
        
        //INSERT BUTTON
        private void insertButton_Click(object sender, EventArgs e)
        {
            subTotalCalculate();
            //Check First
            bool clearancePass = cekContentCompletion();

            //Memasukkan Data ke Semua Pesanan
            if(clearancePass == true)
            {
                //Get Data for Semua Pesanan                                
                string barangID = barangCombobox.SelectedValue.ToString();
                string supplierID = supplierCombobox.SelectedValue.ToString();
                int jumlahBarang = Convert.ToInt32(jumlahNumeric.Value);                
                int hargaSubtotal;                
                hargaSubtotal = Convert.ToInt32(totalLabel.Text);

                //Get barang_supplier_id
                string sqlQuery = "SELECT bs.barang_supplier_id `ID` FROM ud_sinar_mas.barang_supplier bs WHERE bs.barang_id = '"+ barangID +"' AND bs.supplier_id = '"+ supplierID +"'";
                DataTable idDt = sqlFunc.selectQuery(sqlQuery);
                string barangsupplierID = idDt.Rows[0]["ID"].ToString();
                
                //Insert, Data Needed for Penjualan Barang Supplier : Penjualan ID, Barang Supplier ID, Jumlah Pemesanan, Sub Total
                sqlQuery = "INSERT INTO ud_sinar_mas.penjualan_barang_supplier(`penjualan_id`, `barang_supplier_id`, `jumlah_pemesanan`, `sub_total`) VALUES ('"+ newPenjualanID +"', '"+ barangsupplierID +"', '"+ jumlahBarang.ToString() +"', '"+ hargaSubtotal.ToString() +"')";
                sqlFunc.insertQuery(sqlQuery);               

                //Refresh Semua Pesanan
                refreshSemuaPesanan();

                //Stock Reduction
                StockReduction();

                //Clear items
                clearItems();
            }
            else
            {
                MessageBox.Show("Ada data yang kurang benar.");
            }

        }                      
                
        //Barang Combobox Change to Enable Supplier
        private void barangCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplierCombobox.Enabled = true;
            string sqlQuery = "SELECT s.supplier_id `ID Supplier`, s.nama_supplier `Nama Supplier` FROM ud_sinar_mas.supplier s, ud_sinar_mas.barang_supplier bs WHERE bs.supplier_id = s.supplier_id AND bs.barang_id = '" + barangCombobox.SelectedValue.ToString() + "'";
            DataTable suppDt = new DataTable();
            suppDt = sqlFunc.selectQuery(sqlQuery);
            supplierCombobox.DisplayMember = "Nama Supplier";
            supplierCombobox.ValueMember = "ID Supplier";
            supplierCombobox.DataSource = suppDt;
            subTotalCalculate();
        }
        //Jumlah onChange mengubah Total
        private void jumlahNumeric_ValueChanged(object sender, EventArgs e)
        {
            subTotalCalculate();
            
        }

        //Supplier Combobox onChange
        private void supplierCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subTotalCalculate();
            JumlahNumericChangeMaxValue();
        }
        
        //Form CLosed Event
        void formClosed(object sender, FormClosingEventArgs e)
        {
            if(status == false)
            {
                clearDataforRenewal();
            }
        }

        /*
         ///////////////////////
         Procedure and Functions
         ///////////////////////
         */

        private void JumlahNumericChangeMaxValue()
        {
            string barangID = barangCombobox.SelectedValue.ToString();
            string supplierID = supplierCombobox.SelectedValue.ToString();
            string sqlQuery = "SELECT bs.barang_supplier_id `ID`, bs.jumlah_barang `Jumlah` FROM ud_sinar_mas.barang_supplier bs WHERE bs.barang_id = '" + barangID + "' AND bs.supplier_id = '" + supplierID + "'";
            DataTable idDt = sqlFunc.selectQuery(sqlQuery);
            int stockSekarang = Convert.ToInt32(idDt.Rows[0]["Jumlah"]);
            jumlahNumeric.Maximum = stockSekarang;
            jumlahNumeric.Value = 0;

        }

        private void StockReduction()
        {
            string barangID = barangCombobox.SelectedValue.ToString();
            string supplierID = supplierCombobox.SelectedValue.ToString();
            string sqlQuery = "SELECT bs.barang_supplier_id `ID`, bs.jumlah_barang `Jumlah` FROM ud_sinar_mas.barang_supplier bs WHERE bs.barang_id = '" + barangID + "' AND bs.supplier_id = '" + supplierID + "'";
            DataTable idDt = sqlFunc.selectQuery(sqlQuery);
            string barangsupplierID = idDt.Rows[0]["ID"].ToString();           
            int stockKurangi = Convert.ToInt32(jumlahNumeric.Value);

            barangsupplierIdPublic[counter] = barangsupplierID;
            ammountToReduce[counter] = stockKurangi;

            counter++;
        }

        private void barangComboboxFill()
        {
            //Fill Barang Combobox
            string sqlQuery = "SELECT b.nama_barang `Nama Barang`, b.barang_id `ID Barang` FROM ud_sinar_mas.barang b";
            DataTable barangDt = new DataTable();
            barangDt = sqlFunc.selectQuery(sqlQuery);
            barangCombobox.DisplayMember = "Nama Barang";
            barangCombobox.ValueMember = "ID Barang";
            barangCombobox.DataSource = barangDt;            
        }

        //Total Label Changes
        private void subTotalCalculate()
        {            
            int totalHarga = countSubtotal();
            totalLabel.Text = totalHarga.ToString();
        }

        //Subtotal Count
        private int countSubtotal()
        {
            int subTotal;
            string sqlQuery;
            sqlQuery = "SELECT bs.harga_jual `Harga Jual` FROM ud_sinar_mas.barang_supplier bs WHERE bs.barang_id = '" + barangCombobox.SelectedValue.ToString() + "' AND bs.supplier_id = '" + supplierCombobox.SelectedValue.ToString() + "'";
            DataTable totalDt = new DataTable();
            totalDt = sqlFunc.selectQuery(sqlQuery);
            subTotal = Convert.ToInt32(totalDt.Rows[0]["Harga Jual"]) * Convert.ToInt32(jumlahNumeric.Value);
            return subTotal;
        }

        private void refreshSemuaPesanan()
        {
            string sqlQuery = "SELECT b.nama_barang `Nama Barang`, s.nama_supplier `Nama Supplier`, pbs.jumlah_pemesanan `Jumlah Pemesanan`, pbs.sub_total `Sub Total` FROM ud_sinar_mas.penjualan_barang_supplier pbs, ud_sinar_mas.barang_supplier bs, ud_sinar_mas.barang b, ud_sinar_mas.supplier s WHERE bs.barang_supplier_id = pbs.barang_supplier_id AND pbs.penjualan_id = '" + newPenjualanID + "' AND bs.barang_id = b.barang_id AND bs.supplier_id = s.supplier_id;";
            DataTable dtCurrPesanan = new DataTable();
            dtCurrPesanan = sqlFunc.selectQuery(sqlQuery);
            subnotaDataGridView.DataSource = null;
            subnotaDataGridView.DataSource = dtCurrPesanan;
        }
        private void refreshRiwayatTransaksiPenjualan()
        {
            allNotaDataGridView.DataSource = null;
            string sqlQuery = "SELECT cs.nama_customer `Nama Customer`, tp.grand_total `Total`, tp.tanggal_penjualan `Tanggal Penjualan`, pb.metode_pembayaran `Metode Pembayaran`, tp.total_bayar `Sudah di Bayar`, tp.tanggal_jatuh_tempo `Tanggal Jatuh Tempo`, IF(tp.`status` = 0, 'Belum Lunas', 'Lunas') `Status Pembayaran` FROM ud_sinar_mas.transaksi_penjualan tp, ud_sinar_mas.customer cs, ud_sinar_mas.pembayaran pb WHERE tp.customer_id = cs.customer_id AND pb.pembayaran_id = tp.pembayaran_id";
            DataTable riwayatTransaksiPenjualan = sqlFunc.selectQuery(sqlQuery);
            allNotaDataGridView.DataSource = riwayatTransaksiPenjualan;
        }
        private bool cekContentCompletion()
        {
            bool clearanceCheck = true;
            if(Convert.ToInt32(totalLabel.Text) == 0)
            {
                clearanceCheck = false;
            }

            return clearanceCheck;            
        }
      
        private void cancelButton_Click(object sender, EventArgs e)
        {
            clearDataforRenewal();

            //Refresh Screen
            clearItems();

            //Refresh Semua Pesanan
            refreshSemuaPesanan();
        }

        private void clearDataforRenewal()
        {
            string sqlQuery = "DELETE FROM ud_sinar_mas.transaksi_penjualan WHERE penjualan_id = '" + newPenjualanID + "'";
            sqlFunc.deleteQuery(sqlQuery);            

            sqlQuery = "DELETE FROM ud_sinar_mas.penjualan_barang_supplier WHERE penjualan_id = '" + newPenjualanID + "'";
            sqlFunc.deleteQuery(sqlQuery);            

            sqlQuery = "ALTER TABLE ud_sinar_mas.transaksi_penjualan AUTO_INCREMENT = " + numberID + "";
            sqlFunc.runFunctions(sqlQuery);            
        }

        private void selesaiButton_Click(object sender, EventArgs e)
        {
            PopupTransaksiPenjualan ptp = new PopupTransaksiPenjualan();
            ptp.penjualanID = newPenjualanID;
            ptp.formPenjualan = this;
            ptp.ShowDialog();           
        }

        private void clearItems()
        {
            //Barang and Supplier Ngikut
            barangComboboxFill();

            //Jumlah and Subtotal
            jumlahNumeric.Value = 0;
            
        }
    }
}
