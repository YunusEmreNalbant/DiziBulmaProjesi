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
    public partial class FrmSeninicin : Form
    {
        public FrmSeninicin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmFriendsTest frm10 = new FrmFriendsTest();
            frm10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPbTest frm3 = new FrmPbTest();
            frm3.Show();

        }
    }
}
