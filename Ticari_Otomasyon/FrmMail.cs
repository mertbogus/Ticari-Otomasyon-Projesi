using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Ticari_Otomasyon
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            Txtmailadresi.Text = mail;
        }

        private void Btnmailgonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("dream.mrt1@gmail.com", "05432348136");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(Txtmailadresi.Text);
            mesaj.From = new MailAddress("dream.mrt1@gmail.com");
            mesaj.Subject = Txtmailkonu.Text;
            mesaj.Body = Rchmailicerik.Text;
            istemci.Send(mesaj);
            MessageBox.Show("Mail Başarılı Bir Şekilde Gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
