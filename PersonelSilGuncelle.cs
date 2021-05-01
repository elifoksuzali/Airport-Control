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
    public partial class PersonelSilGuncelle : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=ELIF;Initial Catalog=Project;Integrated Security = True");

        public PersonelSilGuncelle()
        {
            InitializeComponent();
        }
        DataTable PersonelSilGuncelleDtable = new DataTable();


        private void PersonelSilGuncelle_Load(object sender, EventArgs e)
        {
            try { 
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


            string ekleSorguMudurListele = "SELECT * FROM PERSONEL";
            SqlCommand sqlKomutMudurListele = new SqlCommand(ekleSorguMudurListele, baglan);
            baglan.Open();
            SqlDataReader veriOku = sqlKomutMudurListele.ExecuteReader();
            veriOku.Read();
            PersonelSilGuncelleDtable.Columns.Add("SSK", typeof(int));
            PersonelSilGuncelleDtable.Columns.Add("Ad", typeof(string));
            PersonelSilGuncelleDtable.Columns.Add("Soyad", typeof(string));
            PersonelSilGuncelleDtable.Columns.Add("Yas", typeof(int));
            PersonelSilGuncelleDtable.Columns.Add("Maas", typeof(int));
            PersonelSilGuncelleDtable.Columns.Add("Telefon", typeof(int));
            PersonelSilGuncelleDtable.Columns.Add("Adres", typeof(string));
            PersonelSilGuncelleDtable.Columns.Add("Cinsiyet", typeof(char));
            PersonelSilGuncelleDtable.Columns.Add("BNo", typeof(int));
            PersonelSilGuncelleDtable.Columns.Add("KurumKodu", typeof(int));
            personelGDGV.DataSource = PersonelSilGuncelleDtable;
            while (veriOku.Read())
            {
                PersonelSilGuncelleDtable.Rows.Add(veriOku["SSK"], veriOku["Ad"], veriOku["Soyad"], veriOku["Yas"], veriOku["Maas"], veriOku["Telefon"], veriOku["Adres"], veriOku["Cinsiyet"], veriOku["BNo"],veriOku["KurumKodu"]);
                personelGDGV.DataSource = PersonelSilGuncelleDtable;
            }
            personelGDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            veriOku.Close();
            baglan.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}

        private void Listele(string SQL)
        {
            DataTable data = new DataTable("PERSONEL");
            SqlDataAdapter adapter = new SqlDataAdapter(SQL, baglan);
            adapter.Fill(data);
            personelGDGV.DataSource = data;
        }
        private void PersonelGuncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlBolum = "Update PERSONEL SET BNo=" + teknikerBolNumCbx.SelectedValue + ",KurumKodu=" + teknikerKurumKodCbx.SelectedValue + " WHERE SSK=" + Convert.ToInt32(teknikerSSKNotxt.Text); ;
                SqlCommand sqlBolumOlustur = new SqlCommand(sqlBolum, baglan);
                baglan.Open();
                sqlBolumOlustur.ExecuteNonQuery();
                baglan.Close();

                baglan.Open();
                SqlCommand sqlKomutPersonelGuncelleGuncelle = new SqlCommand("PersonelGuncelleme", baglan);
                sqlKomutPersonelGuncelleGuncelle.CommandType = CommandType.StoredProcedure;

                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("SSK", Convert.ToInt32( teknikerSSKNotxt.Text));
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("Ad", teknikerAdtxt.Text);
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("Soyad", teknikerSoyadtxt.Text);
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("Yas", Convert.ToInt32 (teknikerYastxt.Text));
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("Maas", Convert.ToInt32( teknikerMaastxt.Text));
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("Telefon", Convert.ToInt32( teknikerTeltxt.Text));
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("Adres", teknikerAdrestxt.Text);
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("Cinsiyet", teknikerCinsiyettxt.Text);
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("BNo", Convert.ToInt32(teknikerBolNumCbx.SelectedValue));
                sqlKomutPersonelGuncelleGuncelle.Parameters.AddWithValue("KurumKodu", Convert.ToInt32(teknikerKurumKodCbx.SelectedValue));                
                sqlKomutPersonelGuncelleGuncelle.ExecuteNonQuery();
                baglan.Close();

                Listele("SELECT * FROM PERSONEL");
                MessageBox.Show("Güncelleme Tamamlandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void PersonelSilbtn_Click(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();
                SqlCommand sqlKomutPersoneliSil = new SqlCommand("sPersonelSil", baglan);
                sqlKomutPersoneliSil.CommandType = CommandType.StoredProcedure;

                sqlKomutPersoneliSil.Parameters.AddWithValue("SSK", personelGDGV.CurrentRow.Cells[0].Value);


                sqlKomutPersoneliSil.ExecuteNonQuery();
                baglan.Close();
                Listele("SELECT * FROM PERSONEL");
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void personelGDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                teknikerSSKNotxt.Text = personelGDGV.CurrentRow.Cells["SSK"].Value.ToString();
                teknikerAdtxt.Text = personelGDGV.CurrentRow.Cells["Ad"].Value.ToString();
                teknikerSoyadtxt.Text = personelGDGV.CurrentRow.Cells["Soyad"].Value.ToString();
                teknikerYastxt.Text = personelGDGV.CurrentRow.Cells["Yas"].Value.ToString();
                teknikerMaastxt.Text = personelGDGV.CurrentRow.Cells["Maas"].Value.ToString();
                teknikerTeltxt.Text = personelGDGV.CurrentRow.Cells["Telefon"].Value.ToString();
                teknikerAdrestxt.Text = personelGDGV.CurrentRow.Cells["Adres"].Value.ToString();
                teknikerCinsiyettxt.Text = personelGDGV.CurrentRow.Cells["Cinsiyet"].Value.ToString();
                teknikerBolNumCbx.Text = personelGDGV.CurrentRow.Cells["BNo"].Value.ToString();
                teknikerKurumKodCbx.Text = personelGDGV.CurrentRow.Cells["KurumKodu"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teknikerBolNumCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (teknikerBolNumCbx.SelectedIndex != -1)
            {
                SqlDataAdapter bolumSecme = new SqlDataAdapter("SELECT * FROM DEPARTMANT WHERE BNo = " + teknikerBolNumCbx.SelectedValue, baglan);
                DataTable departmanttablosundan = new DataTable();
                bolumSecme.Fill(departmanttablosundan);
                teknikerBolNumCbx.ValueMember = "BNo";
                teknikerBolNumCbx.DisplayMember = "BNo_ADI";
                teknikerBolNumCbx.DataSource = departmanttablosundan;
            }
        }

        private void teknikerKurumKodCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (teknikerKurumKodCbx.SelectedIndex != -1)
            {
                SqlDataAdapter KurumSecme = new SqlDataAdapter("SELECT * FROM KURUM WHERE KurumKodu = " + teknikerKurumKodCbx.SelectedValue, baglan);
                DataTable KurumSecmetablosundan = new DataTable();
                KurumSecme.Fill(KurumSecmetablosundan);
                teknikerBolNumCbx.ValueMember = "KurumKodu";
                teknikerBolNumCbx.DisplayMember = "Ad";
                teknikerBolNumCbx.DataSource = KurumSecmetablosundan;
            }
        }
    }
}
