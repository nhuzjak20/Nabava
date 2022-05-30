using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nabava.Liste;
using Nabava.Podaci;

namespace Nabava
{
    public partial class PrikazZahtjeva : Form
    {
        public PrikazZahtjeva()
        {
            InitializeComponent();
        }
        private void PrikazZahtjeva_Load(object sender, EventArgs e)
        {
        
        }

        private void ZahtjeviLoad()
        {
            
        }

        private void PrikazZahtjeva_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'huzjaknikola_bazaDataSet.zahtjevi' table. You can move, or remove it, as needed.
            this.zahtjeviTableAdapter.Fill(this.huzjaknikola_bazaDataSet.zahtjevi);

        }

        private void DodajZahtjevGumb_Click(object sender, EventArgs e)
        {
            dodavanje_zahtjeva fm = new dodavanje_zahtjeva();
            fm.ShowDialog();
        }
    }
}
