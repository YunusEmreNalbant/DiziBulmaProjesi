using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace DiziBulmaProjesi
{
    public partial class FrmOneriler : Form
    {
        public FrmOneriler()
        {
            InitializeComponent();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("diziotagprojesi@hotmail.com", "diziotag123");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(textBox1.Text);
            mesaj.From = new MailAddress("diziotagprojesi@hotmail.com");
            mesaj.Subject = textBox2.Text;
            mesaj.Body = textBox3.Text;
            istemci.Send(mesaj);
            MessageBox.Show("Mesajınız gönderildi ! Öneriniz için teşekkür ederiz.");
        }
    }
}
