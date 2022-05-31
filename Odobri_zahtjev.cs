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
using Nabava.Podaci;

namespace Nabava
{
    public partial class Odobri_zahtjev : Form
    {
        public Odobri_zahtjev()
        {
            InitializeComponent();
        }
        public promjena_zahtjeva prom;
        private void promjeni_odobrenje_gmb_Click(object sender, EventArgs e)
        {
            /*DB.SetConfiguration("huzjaknikola_baza", "huzjaknikola_baza", "nikola55");
            var trazeni_id = 3;
            DB.OpenConnection();
            
            var podaci = DB.GetDataReader("SELECT * FROM dbo.zahtjevi where id = " + trazeni_id);
            int OdabraniId = int.Parse(podaci["id"].ToString());
            int Potvrda = int.Parse(podaci["dekan_potvrda"].ToString());
            if(Potvrda == 1)
            {
                DB.ExecuteCommand("UPDATE dbo.zahtjevi SET dekan_potvrda = 0 where id ="+trazeni_id);
            } else
            {
                DB.ExecuteCommand("UPDATE dbo.zahtjevi SET dekan_potvrda = 1 where id =" + trazeni_id);
            }*/
            decimal spremi = odaberi_id_num.Value;
            //prom.id = Convert.ToInt32(odaberi_id_num.Value);
            //prom.stanje = int.Parse(comboBox1.Text.ToString());
            DB.SetConfiguration("huzjaknikola_baza", "huzjaknikola_baza", "nikola55");
            DB.OpenConnection();
            DB.ExecuteCommand("UPDATE dbo.zahtjevi SET dekan_potvrda=" + int.Parse(comboBox1.Text.ToString()) +" WHERE id="+ Convert.ToInt32(odaberi_id_num.Value) + ";");
            DB.CloseConnection();
            Lista_zahtjeva fr = new Lista_zahtjeva();
            Hide();
            fr.ShowDialog();
            Close();
        }
    }
}
