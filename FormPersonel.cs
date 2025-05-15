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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
            this.AcceptButton = btnKisiAra; // Enter tuşuna basıldığında btnKisiAra butonuna tıklanmış gibi davranır
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            FormDuzenle formDuzenle = new FormDuzenle();
            formDuzenle.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.Show();
            this.Hide();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDataSet.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.personelDataSet.Personel);

        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            FormDepartman formDepartman = new FormDepartman();
            formDepartman.Show();
            this.Hide();
        }

        private void btnKisiAra_Click(object sender, EventArgs e)
        {
            string aranan = tbAra.Text.Trim();

            if (string.IsNullOrWhiteSpace(aranan))
            {
                MessageBox.Show("Lütfen aramak istediğiniz ismi, soyismi veya pozisyonu giriniz.");
                tbAra.Focus(); // TextBox'a odaklanır
                return;
            }

            string connectionString = "Data Source=EDANUR;Initial Catalog=Personel;Integrated Security=True;";

            string query = @"
        SELECT * FROM Personel
        WHERE PersonelIsim LIKE @arama
           OR PersonelSoyisim LIKE @arama
           OR PersonelPozisyon LIKE @arama";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@arama", "%" + aranan + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
        }

    }
}
