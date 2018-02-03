namespace DiziBulmaProjesi
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.diziBulmamdaYardımcıOlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seninicinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.önerilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diziBulmamdaYardımcıOlToolStripMenuItem,
            this.ıToolStripMenuItem,
            this.seninicinToolStripMenuItem,
            this.önerilerToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // diziBulmamdaYardımcıOlToolStripMenuItem
            // 
            this.diziBulmamdaYardımcıOlToolStripMenuItem.Name = "diziBulmamdaYardımcıOlToolStripMenuItem";
            this.diziBulmamdaYardımcıOlToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.diziBulmamdaYardımcıOlToolStripMenuItem.Text = "Dizi Bul";
            this.diziBulmamdaYardımcıOlToolStripMenuItem.Click += new System.EventHandler(this.diziBulmamdaYardımcıOlToolStripMenuItem_Click);
            // 
            // ıToolStripMenuItem
            // 
            this.ıToolStripMenuItem.Name = "ıToolStripMenuItem";
            this.ıToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.ıToolStripMenuItem.Text = "IMDb Puanları";
            this.ıToolStripMenuItem.Click += new System.EventHandler(this.ıToolStripMenuItem_Click);
            // 
            // seninicinToolStripMenuItem
            // 
            this.seninicinToolStripMenuItem.Name = "seninicinToolStripMenuItem";
            this.seninicinToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.seninicinToolStripMenuItem.Text = "Senin İçin";
            this.seninicinToolStripMenuItem.Click += new System.EventHandler(this.profilimToolStripMenuItem_Click);
            // 
            // önerilerToolStripMenuItem
            // 
            this.önerilerToolStripMenuItem.Name = "önerilerToolStripMenuItem";
            this.önerilerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.önerilerToolStripMenuItem.Text = "Duvar Kağıtları";
            this.önerilerToolStripMenuItem.Click += new System.EventHandler(this.önerilerToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.çıkışToolStripMenuItem.Text = "Öneriler";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            this.çıkışToolStripMenuItem1.Click += new System.EventHandler(this.çıkışToolStripMenuItem1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1147, 611);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 635);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaSayfa";
            this.Text = "FrmAnaSayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem diziBulmamdaYardımcıOlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seninicinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem önerilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}