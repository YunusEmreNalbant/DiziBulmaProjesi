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
    public partial class FrmAnaSayfa : Form
    {
       

        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            

            webBrowser1.Navigate("https://www.blutv.com.tr/yabanci-diziler");
        }

        private void diziBulmamdaYardımcıOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiziBul frm = new FrmDiziBul();
            
            frm.Show();
        }

        private void ıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPuanlar frm2 = new FrmPuanlar();
            frm2.Show();

        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void profilimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeninicin frm5 = new FrmSeninicin();
            frm5.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOneriler frm9 = new FrmOneriler();
            frm9.Show();

        }

        private void önerilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDuvarKagidi frm8 = new FrmDuvarKagidi();
            frm8.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
