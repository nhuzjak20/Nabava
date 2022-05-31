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

namespace Nabava
{
    public partial class dodavanje_zahtjeva : Form
    {
        public dodavanje_zahtjeva()
        {
            InitializeComponent();
        }

        private void podnesi_Click(object sender, EventArgs e)
        {
            if(razlog_zahtjev_box.Text == "" || način_financiranja_box.Text == "" || naziv_podnositelja_box.Text == "")
            {
                MessageBox.Show("Unesi sve podatke", "Greška", MessageBoxButtons.OK);
            }
            DB.SetConfiguration("huzjaknikola_baza", "huzjaknikola_baza", "nikola55");
            DB.OpenConnection();
            string upit = $"INSERT INTO dbo.zahtjevi(naziv_podnositelja, nacin_financiranja, razlog, dekan_potvrda) VALUES ('" + naziv_podnositelja_box.Text + "', '" + način_financiranja_box.Text + "', '" + razlog_zahtjev_box + "' , 1);";
            DB.ExecuteCommand(upit);
            DB.CloseConnection();
            MessageBox.Show("Obavijest", "Podaci su uneseni", MessageBoxButtons.OK);
            
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
