using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziBulmaProjesi
{
    public partial class FrmPbTest : Form
    {
        public FrmPbTest()
        {
            InitializeComponent();
        }
        int sorunumber = 0, dogrunumber = 0, yanlisnumber = 0;

        private void FrmPbTest_Load(object sender, EventArgs e)
        {

        }

        private void BtnBB_Click(object sender, EventArgs e)
        {
            BtnAA.Enabled = false;
            BtnBB.Enabled = false;
            BtnCC.Enabled = false;
            BtnDD.Enabled = false;
            BtnSonraki.Enabled = true;
            lbl3.Text = BtnBB.Text;
            if (lbl2.Text == lbl3.Text)
            {
                dogrunumber++;
                LblDogru2.Text = dogrunumber++.ToString();
                BtnBB.BackColor = Color.Green;
            }
            else
            {
                yanlisnumber++;
                LblYanlis2.Text = yanlisnumber.ToString();
                BtnBB.BackColor = Color.Red;
            }
        }

        private void BtnCC_Click(object sender, EventArgs e)
        {
            BtnAA.Enabled = false;
            BtnBB.Enabled = false;
            BtnCC.Enabled = false;
            BtnDD.Enabled = false;
            BtnSonraki.Enabled = true;
            lbl3.Text = BtnCC.Text;
            if (lbl2.Text == lbl3.Text)
            {
                dogrunumber++;
                LblDogru2.Text = dogrunumber++.ToString();
                BtnCC.BackColor = Color.Green;
            }
            else
            {
                yanlisnumber++;
                LblYanlis2.Text = yanlisnumber.ToString();
                BtnCC.BackColor = Color.Red;
            }
        }

        private void BtnDD_Click(object sender, EventArgs e)
        {
            BtnAA.Enabled = false;
            BtnBB.Enabled = false;
            BtnCC.Enabled = false;
            BtnDD.Enabled = false;
            BtnSonraki.Enabled = true;
            lbl3.Text = BtnDD.Text;
            if (lbl2.Text == lbl3.Text)
            {
                dogrunumber++;
                LblDogru2.Text = dogrunumber++.ToString();
                BtnDD.BackColor = Color.Green;
            }
            else
            {
                yanlisnumber++;
                LblYanlis2.Text = yanlisnumber.ToString();
                BtnDD.BackColor = Color.Red;
            }
        }

        private void BtnAA_Click(object sender, EventArgs e)
        {
            BtnAA.Enabled = false;
            BtnBB.Enabled = false;
            BtnCC.Enabled = false;
            BtnDD.Enabled = false;
            BtnSonraki.Enabled = true;
            lbl3.Text = BtnAA.Text;
            if (lbl2.Text == lbl3.Text)
            {
                dogrunumber++;
                LblDogru2.Text = dogrunumber++.ToString();
                BtnAA.BackColor = Color.Green;
            }
            else
            {
                yanlisnumber++;
                LblYanlis2.Text = yanlisnumber.ToString();
                BtnAA.BackColor = Color.Red;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnAA.Enabled = true;
            BtnBB.Enabled = true;
            BtnCC.Enabled = true;
            BtnDD.Enabled = true;
            BtnSonraki.Enabled = false;
            BtnAA.BackColor = Color.White;
            BtnBB.BackColor = Color.White;
            BtnCC.BackColor = Color.White;
            BtnDD.BackColor = Color.White;
            sorunumber++;
            lblsoruno.Text = sorunumber.ToString();


            if (sorunumber == 1)
            {
                richTextBox2.Text = "Michael hangi nedenle hapisaneye girdi?";
                BtnAA.Text = "Abburuzi ile konuşmak icin";
                BtnBB.Text = "Banka soyduğu icin ";
                BtnCC.Text = "Para için";
                BtnDD.Text = "Kardesi icin";
                lbl2.Text = "Kardesi icin";
            }
            if (sorunumber == 2)
            {
                richTextBox2.Text = "Michael in mesleği neydi ?";

                BtnAA.Text = "Doktor"   ;
                BtnBB.Text = "Kimyager";
                BtnCC.Text = "Insaat muhendisi";
                BtnDD.Text = "Yazilimci";
                lbl2.Text = "Insaat muhendisi";
            }
            if (sorunumber == 3)
            {
                richTextBox2.Text = " Dizi ilk ne zaman yayinlandi ?";
                BtnAA.Text = "29 Ağustos 2005";
                BtnBB.Text = "14 Nisan 2009";
                BtnCC.Text = "21 Eylül 2007";
                BtnDD.Text = "5 Subat 2004";
                lbl2.Text = "29 Ağustos 2005";
            }

            if (sorunumber == 4)
            {
                richTextBox2.Text = "1.sezondaki hapishanenin adı ?";
                BtnAA.Text = "Fuchu Hapishanes";
                BtnBB.Text = " La Sante Hapishanesi";
                BtnCC.Text = "Alcatraz Federal Hapishanesin";
                BtnDD.Text = "Fox River Eyalet Hapishanesi";
                lbl2.Text = "Fox River Eyalet Hapishanesi";
            }

            if (sorunumber == 5)
            {
                richTextBox2.Text = "Michael, Sara 'nın doğum gününde onun masasına ne bıraktı?";
                BtnAA.Text = "Origami turna ";
                BtnBB.Text = "Origami kalp";
                BtnCC.Text = "Origami gemi";
                BtnDD.Text = "Kagit kugu";
                lbl2.Text = "Kagit kugu";

                MessageBox.Show("Test bitti");
                BtnSonraki.Enabled = false;
                if (dogrunumber >= 3)
                {
                    MessageBox.Show("Gerçek bir Prison Break hayranısınız !");

                }
                else
                {
                    MessageBox.Show("Prison Break izlediğine emin misin?");
                }
                BtnAA.Enabled = false;
                BtnBB.Enabled = false;
                BtnCC.Enabled = false;
                BtnDD.Enabled = false;
            }
        }


        }
    }
