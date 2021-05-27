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
    public partial class FormPembelian : Form
    {
        //Get Functions
        private SqlFunction sqlFunc;
        public string sqlQuery;
        public string numberID, newPembelianID;
        public bool status = false;        
        public FormPembelian()
        {
            InitializeComponent();
            FormClosing += FormClosed;
        }

        public void FormPembelian_Load(object sender, EventArgs e)
        {
            //OnLoad Event, TODO's:

            //Fill Declare variables used for Query Function, Function 
            string connString = "datasource=localhost;port=3306;username=root;password=";
            sqlFunc = new SqlFunction(connString);

            //Fill Combobox Barang
            sqlQuery = "SELECT barang_id `ID`, nama_barang `Nama` FROM ud_sinar_mas.barang";
            DataTable barangDt = sqlFunc.selectQuery(sqlQuery);
            barangCombobox.DataSource = barangDt;
            barangCombobox.DisplayMember = "Nama";
            barangCombobox.ValueMember = "ID";
            SupplierSuggestion();

            //Fill Riwayat Transaksi Pembelian
            refreshTransaksiPembelian();

            //Create Pembelian ID
            sqlQuery = "INSERT INTO ud_sinar_mas.transaksi_pembelian(tanggal_pembelian) VALUES (NOW())";
            sqlFunc.insertQuery(sqlQuery);

            sqlQuery = "SELECT MAX(auto_num) `MAX` FROM ud_sinar_mas.transaksi_pembelian";
            DataTable maxID = new DataTable();
            maxID = sqlFunc.selectQuery(sqlQuery);
            numberID = maxID.Rows[0]["MAX"].ToString();
            newPembelianID = "Y" + numberID;

            //Fill Semua Pesanan
            refreshSubnota();

        }


        private void barangCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //OnSelectedIndexChanged, TODO's:

            //Fill Supplier based on Barang
            //Fill AutoComplete Customer Name
            SupplierSuggestion();
            

        }

        private void jumlahNumeric_ValueChanged(object sender, EventArgs e)
        {
            //OnValueChanged, TODO's:

            //Change Total based on Barang and Supplier multiplied by Jumlah
            SubtotalCalculate();

        }

        private void perubahanhargaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //OnCheckedChanged, TODO's:

            //Enable and Disable Event
            if(perubahanhargaCheckbox.Checked == true)
            {
                CheckedBoxEventEnabler();
            }
            else
            {
                CheckedBoxEventDisabler();
            }

            //Calculate Total Based on Harga Baru or Harga Lama by CheckedChanged
            SubtotalCalculate();

        }

        private void hargabaruNumeric_ValueChanged(object sender, EventArgs e)
        {
            //OnValueChanged, TODO's:

            //Calculate total Based on Jumlah multiplied by Harga Baru
            SubtotalCalculate();

        }

        private void masukkandataButton_Click(object sender, EventArgs e)
        {
            //OnClick Insert Button, TODO's:
            SubtotalCalculate();
            //Validate Data, Complete or Incomplete
            bool dataClearance = DataValidation();

            //Separation using IF on Validation
            if(dataClearance == true)
            {
                //Get All Needed Datas for Pembelian_Barang_Supplier
                string pembelianId, barangId, supplierId, barangsupplierId, jumlahPembelian, subtotalPembelian;
                
                //Pembelian ID
                pembelianId = newPembelianID;

                //Barang ID
                barangId = barangCombobox.SelectedValue.ToString();
                
                //Supplier ID
                sqlQuery = "SELECT supplier_id `ID` FROM ud_sinar_mas.supplier WHERE nama_supplier = '"+ supplierTextbox.Text +"'";
                DataTable supplierDt = sqlFunc.selectQuery(sqlQuery);
                
                //Jumlah Pembelian
                jumlahPembelian = jumlahNumeric.Value.ToString();
                
                if(supplierDt.Rows.Count == 0)
                {
                    string namaSupplier, alamatSupplier, teleponSupplier;
                    namaSupplier = supplierTextbox.Text;
                    alamatSupplier = alamatTextbox.Text;
                    teleponSupplier = nomorteleponTextbox.Text;

                    //Insert New Supplier
                    sqlQuery = "INSERT INTO ud_sinar_mas.supplier(`nama_supplier`, `alamat`, `no_telepon`) VALUES ('"+ namaSupplier +"', '"+ alamatSupplier +"', '"+ teleponSupplier +"')";
                    sqlFunc.insertQuery(sqlQuery);                    

                    //Get ID New Supplier
                    sqlQuery = "SELECT MAX(auto_num) `Nomor ID` FROM ud_sinar_mas.supplier";
                    DataTable supplierIdDt = sqlFunc.selectQuery(sqlQuery);
                    supplierId = "S" + supplierIdDt.Rows[0]["Nomor ID"].ToString();

                    //Set for new Barang_Supplier 
                    sqlQuery = "CALL ud_sinar_mas.InsertBarangSupplier('"+ barangId +"', '"+ supplierId +"', '"+ hargaperliterNumeric.Value.ToString() +"', '"+ jumlahPembelian +"')";
                    sqlFunc.runFunctions(sqlQuery);
                }
                else
                {
                    //Get ID Old Supplier
                    supplierId = supplierDt.Rows[0]["ID"].ToString();

                    //Check if Supplier Price Change
                    if(perubahanhargaCheckbox.Checked == true)
                    {
                        sqlQuery = "UPDATE ud_sinar_mas.barang_supplier SET harga_beli = '"+ hargabaruNumeric.Value.ToString() +"', harga_jual = '"+ (hargabaruNumeric.Value + (hargabaruNumeric.Value * 2/100)).ToString() +"' WHERE barang_id = '"+ barangId +"' AND supplier_id = '"+ supplierId +"'";
                        sqlFunc.updateQuery(sqlQuery);
                    }

                    //Change Stock
                    sqlQuery = "SELECT jumlah_barang `Jumlah` FROM ud_sinar_mas.barang_supplier WHERE barang_id = '"+ barangId +"' AND supplier_id = '"+ supplierId +"'";
                    DataTable stockDt = sqlFunc.selectQuery(sqlQuery);
                    string endStock = (Convert.ToInt32(stockDt.Rows[0]["Jumlah"].ToString()) + Convert.ToInt32(jumlahNumeric.Value)).ToString();
                    sqlQuery = "UPDATE ud_sinar_mas.barang_supplier SET jumlah_barang = '"+ endStock +"' WHERE barang_id = '"+ barangId +"' AND supplier_id = '"+ supplierId +"'";
                    sqlFunc.updateQuery(sqlQuery);
                }
                //Barang Supplier
                sqlQuery = "SELECT barang_supplier_id `ID` FROM ud_sinar_mas.barang_supplier WHERE barang_id = '"+ barangId +"' AND supplier_id = '"+ supplierId +"'";
                DataTable barangsupplierDt = sqlFunc.selectQuery(sqlQuery);
                barangsupplierId = barangsupplierDt.Rows[0]["ID"].ToString();


                //Subtotal
                subtotalPembelian = totalLabel.Text;

                //Insert into Pembelian_Barang_Supplier
                sqlQuery = "CALL ud_sinar_mas.InsertPembelianBarangSupplier('"+ pembelianId +"', '"+ barangsupplierId +"', '"+ jumlahPembelian +"', '"+ subtotalPembelian +"')";
                sqlFunc.runFunctions(sqlQuery);

                

                //Refresh Semua Pesanan
                refreshSubnota();

                //Refresh Barang Combobox
                barangCombobox_SelectedIndexChanged(sender, e);

                //Clear Items
                ClearItems();
            }
            else
            {
                MessageBox.Show("Data kurang lengkap!");
            }
        }
        private void supplierTextbox_TextChanged(object sender, EventArgs e)
        {
            //OnTextChanged TextBox, TODO's:

            //Check if Exist, then Fill Textbox and Numeric
            sqlQuery = "SELECT alamat `Alamat`, no_telepon `Telepon`, supplier_id `ID` FROM ud_sinar_mas.supplier WHERE UPPER(nama_supplier) = UPPER('" + supplierTextbox.Text + "')";
            DataTable supplierinfoDt = sqlFunc.selectQuery(sqlQuery);

            if (supplierinfoDt.Rows.Count > 0)
            {
                //Exist
                string alamatSupplier = supplierinfoDt.Rows[0]["Alamat"].ToString();
                string nomorteleponSupplier = supplierinfoDt.Rows[0]["Telepon"].ToString();

                string supplierId = supplierinfoDt.Rows[0]["ID"].ToString();
                string barangId = barangCombobox.SelectedValue.ToString();
                sqlQuery = "SELECT harga_beli `Harga` FROM ud_sinar_mas.barang_supplier bs WHERE bs.supplier_id = '" + supplierId + "' AND bs.barang_id = '" + barangId + "'";
                DataTable hargajualDt = sqlFunc.selectQuery(sqlQuery);
                string hargaJual = hargajualDt.Rows[0]["Harga"].ToString();

                //Fill Objects
                alamatTextbox.Text = alamatSupplier;
                nomorteleponTextbox.Text = nomorteleponSupplier;
                hargaperliterNumeric.Value = Convert.ToInt32(hargaJual);

                //Disable Objects
                alamatTextbox.Enabled = false;
                nomorteleponTextbox.Enabled = false;
                hargaperliterNumeric.Enabled = false;

                perubahanhargaCheckbox.Checked = false;
                perubahanhargaCheckbox.Enabled = true;
            }
            else
            {
                //Not Exist

                //Empty Objects
                alamatTextbox.Text = "";
                nomorteleponTextbox.Text = "";
                hargaperliterNumeric.Value = 0;

                //Enable Objects
                alamatTextbox.Enabled = true;
                nomorteleponTextbox.Enabled = true;
                hargaperliterNumeric.Enabled = true;

                perubahanhargaCheckbox.Checked = false;
                perubahanhargaCheckbox.Enabled = false;
            }
        }
        private void hargaperliterNumeric_ValueChanged(object sender, EventArgs e)
        {
            //OnChanged Harga per Liter, TODO's:

            //Calculate Total
            SubtotalCalculate();
        }
        private void selesaiButton_Click(object sender, EventArgs e)
        {
            //OnClick Selesai Button, TODO's

            //Do Update to Transaksi_Pembelian with Values of Grand_Total, Pembayaran_ID
            //Get Grand_Total
            sqlQuery = "SELECT SUM(sub_total) `Grand Total` FROM ud_sinar_mas.pembelian_barang_supplier WHERE pembelian_id = '"+ newPembelianID +"'";
            DataTable grandtotalDt = sqlFunc.selectQuery(sqlQuery);
            string grandtotalPembelian = grandtotalDt.Rows[0]["Grand Total"].ToString();

            //Update
            sqlQuery = "CALL ud_sinar_mas.UpdateTransaksiPembelianNonTanggal('"+ newPembelianID +"', '"+ grandtotalPembelian +"')";
            sqlFunc.runFunctions(sqlQuery);

            //Open Popup Form, Send Data
            PopupTransaksiPembelian popupTb = new PopupTransaksiPembelian();

            popupTb.fb = this;
            popupTb.ShowDialog();

        }

        void FormClosed(object sender, FormClosingEventArgs e)
        {
            if(status == false)
            {
                clearDataforRenewal();
            }
        }

        //Notes : CellClick to be able to DELETE : Semua Pesanan, Riwayat Semua (NOTE : TRANSAKSI PENJUALAN INCOMPLETE), Pengurangan stock di penjualan


        /*
        ////////////////////////
        Functions and Procedures
        ////////////////////////     
        */
        private void refreshTransaksiPembelian()
        {
            sqlQuery = "SELECT tanggal_pembelian `Tanggal Pembelian`, tanggal_jatuh_tempo `Tanggal Jatuh Tempo`, grand_total `Total`, total_bayar `Sudah Terbayar`, IF(`status` = 1, 'Lunas', 'Belum Lunas') `Status Pembayaran` FROM ud_sinar_mas.transaksi_pembelian";
            DataTable riwayattransaksiDt = sqlFunc.selectQuery(sqlQuery);

            sqlQuery = "SELECT pembelian_id `ID` FROM ud_sinar_mas.transaksi_pembelian";
            allnotaDgv.DataSource = null;
            allnotaDgv.DataSource = riwayattransaksiDt;
        }
        private void refreshSubnota()
        {
            sqlQuery = "SELECT b.nama_barang `Nama Barang`, s.nama_supplier `Nama Supplier`, pbs.jumlah_pembelian `Jumlah Pemesanan`, pbs.sub_total `Sub Total` FROM ud_sinar_mas.pembelian_barang_supplier pbs, ud_sinar_mas.barang_supplier bs, ud_sinar_mas.barang b, ud_sinar_mas.supplier s WHERE bs.barang_supplier_id = pbs.barang_supplier_id AND pbs.pembelian_id = '" + newPembelianID + "' AND bs.barang_id = b.barang_id AND bs.supplier_id = s.supplier_id;";
            DataTable dtCurrPesanan = new DataTable();
            dtCurrPesanan = sqlFunc.selectQuery(sqlQuery);
            subnotaDgv.DataSource = null;
            subnotaDgv.DataSource = dtCurrPesanan;
        }



        private void SubtotalCalculate()
        {
            try
            {
                //Count Subtotal 
                //Check Checkbox Perubahan Harga Per Liter Checked or Not
                string hargaAkhir;
                if (perubahanhargaCheckbox.Checked == true)
                {
                    //Count by Harga Baru
                    hargaAkhir = (hargabaruNumeric.Value * jumlahNumeric.Value).ToString();
                }
                else
                {
                    //Count by Harga Lama
                    hargaAkhir = (hargaperliterNumeric.Value * jumlahNumeric.Value).ToString();
                }
                totalLabel.Text = hargaAkhir;
            }
            catch (Exception ex)
            {

            }
        }

        private bool DataValidation()
        {
            bool dataClearance = true;            

            //Alamat
            if (alamatTextbox.Text == "")
            {
                dataClearance = false;
            }
            //Nomor Telepon
            if (nomorteleponTextbox.Text == "")
            {
                dataClearance = false;
            }
            //Harga
            if (perubahanhargaCheckbox.Checked == true)
            {
                //Checked, use : Harga Baru
                if (hargabaruNumeric.Value == 0)
                {
                    dataClearance = false;
                }
            }
            else
            {
                //Unchecked, use : Harga Lama
                if (hargaperliterNumeric.Value == 0)
                {
                    dataClearance = false;
                }
            }
            //Jumlah
            if (jumlahNumeric.Value == 0)
            {
                dataClearance = false;
            }
            return dataClearance;
        }
        private void CheckedBoxEventEnabler()
        {
            hargabaruNumeric.Visible = true;
            hargabaruLabel.Visible = true;            
        }

        

        private void CheckedBoxEventDisabler()
        {
            hargabaruNumeric.Visible = false;
            hargabaruLabel.Visible = false;
        }

        private void clearDataforRenewal()
        {
            string sqlQuery = "DELETE FROM ud_sinar_mas.transaksi_pembelian WHERE pembelian_id = '" + newPembelianID+ "'";
            sqlFunc.deleteQuery(sqlQuery);

            sqlQuery = "DELETE FROM ud_sinar_mas.pembelian_barang_supplier WHERE pembelian_id = '" + newPembelianID + "'";
            sqlFunc.deleteQuery(sqlQuery);

            sqlQuery = "ALTER TABLE ud_sinar_mas.transaksi_pembelian AUTO_INCREMENT = " + numberID + "";
            sqlFunc.runFunctions(sqlQuery);
        }
        private void SupplierSuggestion()
        {
            sqlQuery = "SELECT s.nama_supplier `Nama Supplier` FROM ud_sinar_mas.supplier s, ud_sinar_mas.barang_supplier bs WHERE bs.supplier_id = s.supplier_id AND bs.barang_id = '" + barangCombobox.SelectedValue.ToString() + "'";
            DataTable supplierDt = new DataTable();
            supplierDt = sqlFunc.selectQuery(sqlQuery);

            AutoCompleteStringCollection supplierCollectionString = new AutoCompleteStringCollection();
            for (int i = 0; i < supplierDt.Rows.Count; i++)
            {
                supplierCollectionString.Add(supplierDt.Rows[i]["Nama Supplier"].ToString());
            }

            //AutoSuggest
            supplierTextbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            supplierTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            supplierTextbox.AutoCompleteCustomSource = supplierCollectionString;
        }

        private void batalButton_Click(object sender, EventArgs e)
        {
            //Clear Data from Database
            clearDataforRenewal();

            //Refresh Subnota
            refreshSubnota();

            //Refresh Objects
            ClearItems();
        }

        

        private void ClearItems()
        {
            supplierTextbox.Text = "";
            perubahanhargaCheckbox.Checked = false;
            hargabaruNumeric.Value = 0;
            totalLabel.Text = "0";
            jumlahNumeric.Value = 0;
        }
    }




}
