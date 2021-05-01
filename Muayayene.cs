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
    public partial class Muayayene : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=ELIF;Initial Catalog=Project;Integrated Security = True");
        SqlCommand sqlKomut;
        public Muayayene()
        {
            InitializeComponent();
        }

        private void Muayayene_Load(object sender, EventArgs e)
        {

        }

        private void butonEkle_Click(object sender, EventArgs e)
        {

            string ekleSorgu = "INSERT INTO MUAYENE(MuayeneNo,MuayeneTipi,Firma,Puan) VALUES(@MuayeneNo,@MuayeneTipi,@Firma,@Puan)";
            sqlKomut = new SqlCommand(ekleSorgu, baglan);

            sqlKomut.Parameters.Add("@MuayeneNo", SqlDbType.Int);
            sqlKomut.Parameters.Add("@MuayeneTipi", SqlDbType.VarChar);
            sqlKomut.Parameters.Add("@Firma", SqlDbType.VarChar);
            sqlKomut.Parameters.Add("@Puan", SqlDbType.Int);
            

            sqlKomut.Parameters["@MuayeneNo"].Value = muayeneText.Text;
            sqlKomut.Parameters["@MuayeneTipi"].Value = muayeneTipitext.Text;
            sqlKomut.Parameters["@Firma"].Value = firmaText.Text;
            sqlKomut.Parameters["@Puan"].Value = puanText.Text;



            baglan.Open();
            sqlKomut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Eklendi");

        }
    }
}
