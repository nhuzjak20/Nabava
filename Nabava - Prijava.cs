using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nabava.Podaci;
using Nabava.Liste;
namespace Nabava
{
    public partial class Form1 : Form
    {
        public static List<Radnik> radnik { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BoxKorisnickoIme.Text == "")
            {
                MessageBox.Show("Nije uneseno korisničko ime","Problem" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BoxLozinka.Text == "")
            {
                MessageBox.Show("Nije unesena lozinka","Problem" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                radnik = RadniciRepozitorij.PovuciRadnike();
                foreach(var item in radnik)
                {
                    if(item.KorisnickoIme == BoxKorisnickoIme.Text && item.Lozinka == BoxLozinka.Text)
                    {
                        MessageBox.Show("Radi", "Radi", MessageBoxButtons.OK);
                    }
                    else if(item.KorisnickoIme != BoxKorisnickoIme.Text || item.Lozinka != BoxLozinka.Text)
                    {
                        MessageBox.Show("Krivo uneseni podaci", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
