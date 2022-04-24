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

namespace GaziProje
{
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }

        private void sifremiunuttum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();

            SmtpClient istemci = new SmtpClient();

            istemci.Credentials = new System.Net.NetworkCredential("", ""); //ilk tırnak mail adresi ikinci tırnak şifresi // bu mailden mesaj yollanıyor

            istemci.Port = 587;
            istemci.Host = "smtp.live.com"; //burası değişebilir
            istemci.EnableSsl = true;

            mesajım.To.Add(textBox1.Text);
            mesajım.From = new MailAddress(""); //buraya mail adresi yazılacak.
            mesajım.Subject = "Şifre Sıfırlama";
            mesajım.Body = ""; //Buraya sıfırlama linki veya kullanıcının şifresi girilmesi gerek. Onu da data baseden çekmek lazım xD

            istemci.Send(mesajım);

            MessageBox.Show("Şifreniz Mailinize Ulaştırılmıştır.");

            girisyap yeni = new girisyap();
            yeni.Show();
            this.Hide();
        }
    }
}
