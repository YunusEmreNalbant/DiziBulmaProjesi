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

namespace DiziBulmaProjesi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayitOl frm2 = new FrmKayitOl();
            frm2.Show();

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanicilar Where KullaniciAdi=@p1 and KullaniciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtKullaniciSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                FrmAnaSayfa frm = new FrmAnaSayfa();

                frm.Show();
                this.Hide();


            }

            else 
            {
                MessageBox.Show("Hatalı E-posta veya Şifre !");
            }


            bgl.baglanti().Close();


        }
    }
}
