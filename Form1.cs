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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowStudents();
        }

        private void ShowStudents()
        {
            var students = 3;
            zahtjevi.DataSource = students;

            zahtjevi.Columns["ID Zahtjeva"].DisplayIndex = 0;
            zahtjevi.Columns["Naziv podnositelja"].DisplayIndex = 1;
            zahtjevi.Columns["Način financiranja"].DisplayIndex = 2;
            zahtjevi.Columns["Potvrda dekana"].DisplayIndex = 3;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
