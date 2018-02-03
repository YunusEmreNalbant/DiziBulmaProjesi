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
    public partial class FrmFriendsTest : Form
    {
        public FrmFriendsTest()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;

            label7.Text = BtnB.Text;
            if (label2.Text == label7.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                BtnB.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                BtnB.BackColor = Color.Red;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;

            label7.Text = BtnC.Text;
            if (label2.Text == label7.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                BtnC.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                BtnC.BackColor = Color.Red;
            }
        }

        private void FrmFriendsTest_Load(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;

            richTextBox1.Text = " Sonraki Butonuna tıklayarak testi başlatabilirsin.";
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;

            label7.Text = BtnD.Text;
            if (label2.Text == label7.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                BtnD.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                BtnD.BackColor = Color.Red;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            button5.Enabled = true;
            label7.Text = BtnA.Text;
            if(label2.Text==label7.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                BtnA.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                BtnA.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            button5.Enabled = false;
            BtnA.BackColor = Color.White;
            BtnB.BackColor = Color.White;
            BtnC.BackColor = Color.White;
            BtnD.BackColor = Color.White;
            soruno++;
            LblSoruno.Text = soruno.ToString();

            if(soruno==1)
            {
                richTextBox1.Text = " Joey'in kaç kızkardeşi vardı hatırlıyor musun?";
                BtnA.Text = "5";
                BtnB.Text = "6";
                BtnC.Text = "7";
                BtnD.Text = "8";
                label2.Text = "7";
            }
            if(soruno==2)
            {
                richTextBox1.Text = " Mr Heckles'ın çalındığını iddia ettiği enstrümanı hatırlıyor musun peki?";

                BtnA.Text = "Flüt";
                BtnB.Text = "Piyano";
                BtnC.Text = "Obua";
                BtnD.Text = "Keman";
                label2.Text = "Obua";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = " Dizinin girişindeki şemsiyeler ne renkti?";
                BtnA.Text = "Kırmızı, mavi ve sarı";
                BtnB.Text = "Siyah ve beyaz";
                BtnC.Text = "Kırmızı, yeşil ve sarı";
                BtnD.Text = "Kırmızı, beyaz ve mavi";
                label2.Text = "Kırmızı,mavi ve sarı";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Chandler'ın Janice'a Yemen'de mektup atması için verdiği adres?";
                BtnA.Text = "6 Yemen Caddesi, Yemen";
                BtnB.Text = "7 Yemen Caddesi, Yemen";
                BtnC.Text = "14 Yemen Caddesi, Yemen";
                BtnD.Text = "15 Yemen Caddesi, Yemen";
                label2.Text = "15 Yemen Caddesi, Yemen";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Rachel'ın Ross'a yazdığı mektup arkalı önlü kaç sayfaydı?";
                BtnA.Text = "23";
                BtnB.Text = "15";
                BtnC.Text = "16";
                BtnD.Text = "18";
                label2.Text = "18";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "  1/16 Portekizli olduğunu idda eden karakter kimdi?";
                BtnA.Text = "Phoebe";
                BtnB.Text = "Ross";
                BtnC.Text = "Joey";
                BtnD.Text = "Chandler";
                label2.Text = "Joey";


                
            }
            if(soruno==7)
            {
                MessageBox.Show("Test bitti");
                button5.Enabled = false;
                if(dogru >=4)
                {
                    MessageBox.Show("Gerçek bir Friends hayranısınız !");

                }
                else
                {
                    MessageBox.Show("Friends izlediğine emin misin?");
                }

            }

        }



    }
}
