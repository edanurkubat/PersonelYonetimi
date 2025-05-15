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

namespace PersonelYonetimi
{
    public partial class FormDepartman : Form
    {
        public FormDepartman()
        {
            InitializeComponent();
        }

        private void FormDepartman_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSetDepartman.Departman' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmanTableAdapter.Fill(this.personelDataSetDepartman.Departman);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.Show();
            this.Hide();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FormPersonel formPersonel = new FormPersonel();
            formPersonel.Show();
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EDANUR;Initial Catalog=Personel;Integrated Security=True;\r\n");
        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDepartmanAdi.Text))
            {
                MessageBox.Show("Departman adı boş geçilemez");
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Departman (DepartmanAdi) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", tbDepartmanAdi.Text);
            

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Departman eklendi!");
            this.departmanTableAdapter.Fill(this.personelDataSetDepartman.Departman);

        }

        private void btnDepartmanGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand(@"UPDATE Departman SET 
            DepartmanAdi = @p1
            WHERE DepartmanID = @p2", baglanti);

            guncelle.Parameters.AddWithValue("@p1", tbDepartmanAdi.Text);
            guncelle.Parameters.AddWithValue("@p2", Convert.ToInt32(tbDepartmanID.Text)); // ID lazim WHERE için

            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Departman Güncellendi!");
            this.departmanTableAdapter.Fill(this.personelDataSetDepartman.Departman);
        }

        private void dataGridViewPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridViewDepartman.SelectedCells[0].RowIndex;
            tbDepartmanID.Text = dataGridViewDepartman.Rows[secim].Cells[0].Value.ToString();
            tbDepartmanAdi.Text = dataGridViewDepartman.Rows[secim].Cells[1].Value.ToString();
        }
    }
}
