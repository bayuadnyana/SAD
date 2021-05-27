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
    public partial class PopupTransaksiPembelian : Form
    {
        public FormPembelian formPembelian;
        private string sqlQuery;
        private SqlFunction sqlFunc;
        public FormPembelian fb;
        public PopupTransaksiPembelian()
        {
            InitializeComponent();
        }

        private void PopupTransaksiPembelian_Load(object sender, EventArgs e)
        {
            //OnLoad Form, TODO's:

            //At Load, Fill Functions
            string connectionString = "datasource=localhost;port=3306;username=root;password=";
            sqlFunc = new SqlFunction(connectionString);

            //Set Tanggal Jatuh Tempo Mindate
            SetMinimumDateValue();
        }
        
        private void pengirimanDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SetMinimumDateValue();
        }

        private void selesaiButton_Click(object sender, EventArgs e)
        {
            //OnClick Selesai Button, TODO's:

            //Get Data: Tanggal Pengiriman, Tanggal Jatuh Tempo, Id
            string pembelianId = fb.newPembelianID;
            string tanggalPengiriman = pengirimanDateTimePicker.Value.ToString("yyyy-MM-dd");
            string tanggalJatuhTempo = jatuhtempoDateTimePicker.Value.ToString("yyyy-MM-dd");


            //Update Table
            sqlQuery = "CALL ud_sinar_mas.UpdateTransaksiPembelianTanggalOnly('"+ pembelianId +"', '"+ tanggalPengiriman +"', '"+ tanggalJatuhTempo +"')";
            sqlFunc.runFunctions(sqlQuery);

            //Close Form, Refresh Before
            fb.FormPembelian_Load(sender, e);
            this.Close();
        }

        private void SetMinimumDateValue()
        {
            //Set Jatuh Tempo Mindate
            jatuhtempoDateTimePicker.MinDate = pengirimanDateTimePicker.Value;
        }

    }
}
