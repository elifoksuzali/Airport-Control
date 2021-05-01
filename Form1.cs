using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPortProject
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=ELIF;Initial Catalog=Project;Integrated Security = True");
        SqlCommand sqlKomut;
        public Form1()
        {
            InitializeComponent();
        }

        private void muyaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

    private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelSilGuncelle PersonelSilGuncelle = new PersonelSilGuncelle();
            this.Visible = false;
            PersonelSilGuncelle.ShowDialog();
            this.Close();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkleme PersonelEkleme = new PersonelEkleme();
            this.Visible = false;
            PersonelEkleme.ShowDialog();
            this.Close();
        }

        private void personelİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void muyaneRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
