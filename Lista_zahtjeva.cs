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
using System.Configuration;

namespace Nabava
{
    public partial class Lista_zahtjeva : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=3sql11.freesqldatabase.com,3306; Initial Catalog=nhuzjak20_DB; User=nhuzjak20; Password=C!79Do+");
        SqlConnection conn = new SqlConnection(@"Data Source=sql.bsite.net\MSSQL2016; Initial Catalog=huzjaknikola_baza; User=huzjaknikola_baza; Password=nikola55");
        SqlCommand cmd;
        //DataTable dt;
        SqlDataAdapter adapter;
        public Lista_zahtjeva()
        {
            InitializeComponent();
            Stvori_tablicu();
            DisplayValue();
        }


        private void Stvori_tablicu()
        {
            
        }
        public void DisplayValue()
        {
            conn.Open();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.zahtjevi", conn);
            dt = new DataTable();
            adapter.Fill(dt);   
            dataGridView1.DataSource = dt; 
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttoncollumn = new DataGridViewButtonColumn();    
            /*dataGridView1.Columns.Insert(5, buttoncollumn);
            buttoncollumn.HeaderText = "Obriši zahtjeve";
            buttoncollumn.Text = "Obriši";
            buttoncollumn.UseColumnTextForButtonValue = true;*/
            
            conn.Close();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchData(box_text_upis.Text);
        }
        public void SearchData(string search)
        {
            /*conn.Open();
            string query = "SELECT * FROM dbo.zahtjevi WHERE id = '%"+ search +"%';";
            adapter = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;*/
        }
        DataTable dt = new DataTable("Zahtjevi");
        private void Lista_zahtjeva_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttoncollumn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Insert(5, buttoncollumn);
            buttoncollumn.HeaderText = "Obriši zahtjeve";
            buttoncollumn.Text = "Obriši";
            buttoncollumn.UseColumnTextForButtonValue = true;
            // TODO: This line of code loads data into the 'podaci_za_faks.zahtjevi' table. You can move, or remove it, as needed.
            //this.zahtjeviTableAdapter3.Fill(this.podaci_za_faks.zahtjevi);
            /* try
             {
                 using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                 {
                     if(cn.State == ConnectionState.Closed) cn.Open();
                     using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.zahtjevi", cn))
                     {
                         DataTable dt = new DataTable("Zahtjevi");
                         da.Fill(dt);
                         dataGridView1.DataSource = dt;

                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
             }*/
        }

        private void podnesi_zahtjev_gmb_Click(object sender, EventArgs e)
        {
            
            dodavanje_zahtjeva fm = new dodavanje_zahtjeva();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void osvjezi_gmb_Click(object sender, EventArgs e)
        {
            DisplayValue();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pretrazi_ime_Click(object sender, EventArgs e)
        {
            //string pretraga = pretrazi_ime.Text;
            //DB.SetConfiguration(@"sql.bsite.net\MSSQL2016", "huzjaknikola_baza", "nikola55");
            //DB.OpenConnection();
            //string sequel_upit = "SELECT FROM dbo.zahtjevi WHERE naziv_podnositelja='" + pretraga + "';";
            //var podaci = new SqlDataAdapter(sequel_upit);
            //var dt = new DataTable();
           
        }

        private void box_text_upis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("naziv_podnositelja like '%{0}%'", box_text_upis.Text);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Želiš li obrisati zahtjev?", row.Cells["id"].Value), "Potvrdi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=sql.bsite.net\MSSQL2016; Initial Catalog=huzjaknikola_baza; User=huzjaknikola_baza; Password=nikola55"))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.zahtjevi WHERE id=@id", con1))
                        {
                            cmd.Parameters.AddWithValue("id", row.Cells["id"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }
                    }
                    DisplayValue();
                }
            }
        }

        private void promjeni_stanje_gmb_Click(object sender, EventArgs e)
        {

            // SqlConnection con = new SqlConnection(@"Data Source=sql.bsite.net\MSSQL2016; Initial Catalog=huzjaknikola_baza; User=huzjaknikola_baza; Password=nikola55");
            //SqlDataAdapter adpt = new SqlDataAdapter("SELECT dekan_potvrda FROM dbo.zahtjevi", con)
            Odobri_zahtjev fr = new Odobri_zahtjev();
            Hide();
            fr.ShowDialog();
            Close();
        }
    }
}
