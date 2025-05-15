using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelYonetimi
{
    public partial class FormDuzenle : Form
    {
        public FormDuzenle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=Personel;Integrated Security=True;\r\n");
        void temizle()
        {
            tbID.Text = "";
            tbIsım.Text = "";
            tbSoyisim.Text = "";
            tbPozisyon.Text = "";
            cbDepartman.Text = "";
            tbMaas.Text = "";
            datetpDogumTarihi.Text = "";
            tbIsım.Focus();
        }
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FormPersonel formPersonel = new FormPersonel();
            formPersonel.Show();
            this.Hide();
        }

        private void FormDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSet3.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter2.Fill(this.personelDataSet3.Departman);
            // TODO: Bu kod satırı 'personelDataSet2.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter1.Fill(this.personelDataSet2.Departman);
            // TODO: Bu kod satırı 'personelDataSetDepartmanAdi.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.personelDataSetDepartmanAdi.Departman);
            // TODO: Bu kod satırı 'personelDataSet.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.personelDataSet.Personel);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIsım.Text) || string.IsNullOrWhiteSpace(tbSoyisim.Text))
            {
                MessageBox.Show("Ad ve soyad boş geçilemez");
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelIsim, PersonelSoyisim, PersonelPozisyon, PersonelDogumTarihi, PersonelMaas, DepartmanID) values (@p1, @p2, @p3, @p4, @p5, @p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", tbIsım.Text);
            komut.Parameters.AddWithValue("@p2", tbSoyisim.Text); 
            komut.Parameters.AddWithValue("@p3", tbPozisyon.Text);
            komut.Parameters.AddWithValue("@p4", SqlDbType.Date).Value = datetpDogumTarihi.Value.Date;
            komut.Parameters.AddWithValue("@p5", tbMaas.Text);       
            komut.Parameters.AddWithValue("@p6", Convert.ToInt32(cbDepartman.SelectedValue));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel eklendi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand(@"UPDATE Personel SET 
             PersonelIsim = @p1,
             PersonelSoyisim = @p2,
             PersonelPozisyon = @p3,
             PersonelDogumTarihi = @p4,
             PersonelMaas = @p5,
             DepartmanID = @p6
             WHERE PersonelID = @p7", baglanti);
            
            guncelle.Parameters.AddWithValue("@p1", tbIsım.Text);
            guncelle.Parameters.AddWithValue("@p2", tbSoyisim.Text);
            guncelle.Parameters.AddWithValue("@p3", tbPozisyon.Text);
            guncelle.Parameters.AddWithValue("@p4", datetpDogumTarihi.Value.Date);
            guncelle.Parameters.AddWithValue("@p5", Convert.ToDecimal(tbMaas.Text));
            guncelle.Parameters.AddWithValue("@p6", Convert.ToInt32(cbDepartman.SelectedValue));
            guncelle.Parameters.AddWithValue("@p7", Convert.ToInt32(tbID.Text)); // ID lazim WHERE için
                
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Güncellendi!");
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.personelTableAdapter.Fill(this.personelDataSet.Personel);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From Personel Where PersonelID=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", tbID.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi Silindi!");
        }

        private void dataGridViewPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridViewPersoneller.SelectedCells[0].RowIndex;
            tbID.Text = dataGridViewPersoneller.Rows[secim].Cells[0].Value.ToString();
            tbIsım.Text = dataGridViewPersoneller.Rows[secim].Cells[1].Value.ToString();
            tbSoyisim.Text = dataGridViewPersoneller.Rows[secim].Cells[2].Value.ToString();
            tbMaas.Text = dataGridViewPersoneller.Rows[secim].Cells[3].Value.ToString();
            cbDepartman.SelectedItem = dataGridViewPersoneller.Rows[secim].Cells[4].Value.ToString();
            tbPozisyon.Text = dataGridViewPersoneller.Rows[secim].Cells[5].Value.ToString();
            datetpDogumTarihi.Value = Convert.ToDateTime(dataGridViewPersoneller.Rows[secim].Cells[6].Value);
           
            object gelenTarih = dataGridViewPersoneller.Rows[secim].Cells[4].Value;

            

        }

    }
}
