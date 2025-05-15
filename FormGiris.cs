using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelYonetimi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
            this.AcceptButton = btnGiris; // Enter tuşuna basıldığında btnGiris butonuna tıklanmış gibi davranır
            
        }
        private void Temizle()
        {
            tbKullanici.Text = "";
            tbSifre.Text = "";
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = tbKullanici.Text.Trim();
            string sifre = tbSifre.Text.Trim();

            if (kullanici == "edanurrkbt" && sifre == "eda")
            {
                FormPersonel formPersonel = new FormPersonel();
                formPersonel.Show();
                this.Hide();
            }

            else if (string.IsNullOrEmpty(tbKullanici.Text) || string.IsNullOrEmpty(tbSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz!");
                Temizle();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Temizle();
            }
        }

    }
}
