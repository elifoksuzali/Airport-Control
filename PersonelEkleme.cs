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
    public partial class PersonelEkleme : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=ELIF;Initial Catalog=Project;Integrated Security = True");
        SqlCommand sqlKomut;
        public PersonelEkleme()
        {
            InitializeComponent();
        }

        private void PersonelEkleme_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter sqlKomutDepartmant = new SqlDataAdapter("select * from DEPARTMANT", baglan);
            DataTable departman = new DataTable();
            sqlKomutDepartmant.Fill(departman);
            teknikerBolNumCbx.ValueMember = "BNo";
            teknikerBolNumCbx.DisplayMember = "BNo_ADI";
            teknikerBolNumCbx.DataSource = departman;
            baglan.Close();

            baglan.Open();
            SqlDataAdapter sqlKomutKurum = new SqlDataAdapter("select * from KURUM", baglan);
            DataTable kurum = new DataTable();
            sqlKomutKurum.Fill(kurum);
            teknikerKurumKodCbx.ValueMember = "KurumKodu";
            teknikerKurumKodCbx.DisplayMember = "Ad";
            teknikerKurumKodCbx.DataSource = kurum;
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ekleSorgu = "INSERT INTO PERSONEL(SSK,Ad,Soyad,Yas,Maas,Telefon,Adres,Cinsiyet,BNo,KurumKodu) VALUES(@SSK,@Ad,@Soyad,@Yas,@Maas,@Telefon,@Adres,@Cinsiyet,@BNo,@KurumKodu)";
            sqlKomut = new SqlCommand(ekleSorgu, baglan);

            sqlKomut.Parameters.Add("@SSK", SqlDbType.Int);
            sqlKomut.Parameters.Add("@Ad", SqlDbType.VarChar);
            sqlKomut.Parameters.Add("@Soyad", SqlDbType.VarChar);
            sqlKomut.Parameters.Add("@Yas", SqlDbType.Int);
            sqlKomut.Parameters.Add("@Maas", SqlDbType.Int);
            sqlKomut.Parameters.Add("@Telefon", SqlDbType.Int);
            sqlKomut.Parameters.Add("@Adres", SqlDbType.VarChar);
            sqlKomut.Parameters.Add("@Cinsiyet", SqlDbType.Char);
            sqlKomut.Parameters.Add("@BNo", SqlDbType.Int);
            sqlKomut.Parameters.Add("@KurumKodu", SqlDbType.Int);

            sqlKomut.Parameters["@SSK"].Value = teknikerSSKNotxt.Text;
            sqlKomut.Parameters["@Ad"].Value = teknikerAdtxt.Text;
            sqlKomut.Parameters["@Soyad"].Value = teknikerSoyadtxt.Text;
            sqlKomut.Parameters["@Yas"].Value = teknikerYastxt.Text;
            sqlKomut.Parameters["@Maas"].Value = teknikerMaastxt.Text;
            sqlKomut.Parameters["@Telefon"].Value = teknikerTeltxt.Text;
            sqlKomut.Parameters["@Adres"].Value = teknikerAdrestxt.Text;
            sqlKomut.Parameters["@Cinsiyet"].Value = teknikerCinsiyettxt.Text;
            sqlKomut.Parameters["@BNo"].Value = Convert.ToInt32(teknikerBolNumCbx.SelectedValue);
            sqlKomut.Parameters["@KurumKodu"].Value = Convert.ToInt32(teknikerKurumKodCbx.SelectedValue);


            baglan.Open();
            sqlKomut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Eklendi");

        }

        private void teknikerBolNumCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
