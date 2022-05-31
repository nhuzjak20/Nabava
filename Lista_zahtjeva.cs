using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using System.Data.SqlClient;

namespace Nabava
{
    public partial class Lista_zahtjeva : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=3sql11.freesqldatabase.com,3306; Initial Catalog=nhuzjak20_DB; User=nhuzjak20; Password=C!79Do+");
        SqlConnection conn = new SqlConnection(@"Data Source=sql.bsite.net\MSSQL2016; Initial Catalog=huzjaknikola_baza; User=huzjaknikola_baza; Password=nikola55");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        public Lista_zahtjeva()
        {
            InitializeComponent();
            DisplayValue();
        }

        public void DisplayValue()
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.zahtjevi", conn);
            dt = new DataTable();
            adapter.Fill(dt);   
            dataGridView1.DataSource = dt; 
            conn.Close();
        }
        private void Lista_zahtjeva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'podaci_za_faks.zahtjevi' table. You can move, or remove it, as needed.
            this.zahtjeviTableAdapter3.Fill(this.podaci_za_faks.zahtjevi);
        }

        private void podnesi_zahtjev_gmb_Click(object sender, EventArgs e)
        {
            dodavanje_zahtjeva fm = new dodavanje_zahtjeva();
            fm.ShowDialog();
        }

        private void osvjezi_gmb_Click(object sender, EventArgs e)
        {
            this.zahtjeviTableAdapter3.Fill(this.podaci_za_faks.zahtjevi);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pretrazi_ime_Click(object sender, EventArgs e)
        {
            //string pretraga = pretrazi_ime.Text;
            DB.SetConfiguration(@"sql.bsite.net\MSSQL2016", "huzjaknikola_baza", "nikola55");
            DB.OpenConnection();
            //string sequel_upit = "SELECT FROM dbo.zahtjevi WHERE naziv_podnositelja='" + pretraga + "';";
            //var podaci = new SqlDataAdapter(sequel_upit);
            var dt = new DataTable();
           
        }
    }
}
