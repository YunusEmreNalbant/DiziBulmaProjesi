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
    public partial class FrmDuvarKagidi : Form
    {
        public FrmDuvarKagidi()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "breakingbad.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "breakingbad";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox2.Image.Save(kaydet.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "bigbang.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "bigbang";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox1.Image.Save(kaydet.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "breakingbad2.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "breakingbad2";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox3.Image.Save(kaydet.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "breakingbad4.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "breakingbad4";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox4.Image.Save(kaydet.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "chuck.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "chuck";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox5.Image.Save(kaydet.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "chuck2.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "chuck2";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox6.Image.Save(kaydet.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "dexter.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "dexter";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox7.Image.Save(kaydet.FileName);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "doctorwho.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "doctorwho";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox8.Image.Save(kaydet.FileName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "friends.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "friends";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox16.Image.Save(kaydet.FileName);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "friends2.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "friends2";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox15.Image.Save(kaydet.FileName);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "fringe.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "fringe";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox14.Image.Save(kaydet.FileName);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "fringe2.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "fringe2";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox13.Image.Save(kaydet.FileName);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "fringe3.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "fringe3";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox12.Image.Save(kaydet.FileName);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "fringe4.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "fringe4";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox11.Image.Save(kaydet.FileName);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "got.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "got";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox10.Image.Save(kaydet.FileName);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "lost.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "lost";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox9.Image.Save(kaydet.FileName);
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "lost2.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "lost2";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox24.Image.Save(kaydet.FileName);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "pb.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "pb";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox23.Image.Save(kaydet.FileName);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "shameless.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "shameless";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox22.Image.Save(kaydet.FileName);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "sherlock.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "sherlock";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox21.Image.Save(kaydet.FileName);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "theflash.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "theflash";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox20.Image.Save(kaydet.FileName);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "twd.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "twd";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox19.Image.Save(kaydet.FileName);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "twd2.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "twd2";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox18.Image.Save(kaydet.FileName);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "twd3.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "twd3";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox17.Image.Save(kaydet.FileName);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "vikings.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "vikings";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox32.Image.Save(kaydet.FileName);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "vikings2.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "vikings2";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox31.Image.Save(kaydet.FileName);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "vikings3.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "vikings3";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox30.Image.Save(kaydet.FileName);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "11.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "112263a";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox29.Image.Save(kaydet.FileName);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "22.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "112263b";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox28.Image.Save(kaydet.FileName);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "63.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "112263c";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox27.Image.Save(kaydet.FileName);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "pb2.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "pb";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox26.Image.Save(kaydet.FileName);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Filter = "pb3.jpg(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            kaydet.Title = "Kayıt";
            kaydet.FileName = "pbb";
            DialogResult sonuç = kaydet.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pictureBox25.Image.Save(kaydet.FileName);
            }
        }
    }
 }
    
    
    

