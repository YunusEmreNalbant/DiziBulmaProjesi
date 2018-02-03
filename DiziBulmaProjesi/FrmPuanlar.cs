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
    public partial class FrmPuanlar : Form
    {
        public FrmPuanlar()
        {
            InitializeComponent();
        }

        private void FrmPuanlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diziOtagProjesiDataSet2.Tbl_Puanlar' table. You can move, or remove it, as needed.
            this.tbl_PuanlarTableAdapter2.Fill(this.diziOtagProjesiDataSet2.Tbl_Puanlar);
            // TODO: This line of code loads data into the 'diziOtagProjesiDataSet1.Tbl_Puanlar' table. You can move, or remove it, as needed.
            this.tbl_PuanlarTableAdapter1.Fill(this.diziOtagProjesiDataSet1.Tbl_Puanlar);
            // TODO: This line of code loads data into the 'diziOtagProjesiDataSet.Tbl_Puanlar' table. You can move, or remove it, as needed.
            this.tbl_PuanlarTableAdapter.Fill(this.diziOtagProjesiDataSet.Tbl_Puanlar);

        }
    }
}
