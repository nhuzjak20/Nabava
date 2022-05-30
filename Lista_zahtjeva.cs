using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nabava
{
    public partial class Lista_zahtjeva : Form
    {
        public Lista_zahtjeva()
        {
            InitializeComponent();
        }

        private void Lista_zahtjeva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'huzjaknikola_bazaDataSet1.zahtjevi' table. You can move, or remove it, as needed.
            this.zahtjeviTableAdapter1.Fill(this.huzjaknikola_bazaDataSet1.zahtjevi);
            // TODO: This line of code loads data into the 'huzjaknikola_bazaDataSet.zahtjevi' table. You can move, or remove it, as needed.
           // this.zahtjeviTableAdapter.Fill(this.huzjaknikola_bazaDataSet.zahtjevi);

        }

        private void podnesi_zahtjev_gmb_Click(object sender, EventArgs e)
        {
            dodavanje_zahtjeva fm = new dodavanje_zahtjeva();
            fm.ShowDialog();
        }
    }
}
