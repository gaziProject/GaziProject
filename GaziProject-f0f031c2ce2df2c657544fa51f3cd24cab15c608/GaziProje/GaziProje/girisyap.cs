using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace GaziProje
{
    public partial class girisyap : Form
    {
        public girisyap()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\yibif\\OneDrive\\Masaüstü\\github gazi\\GaziProject-f0f031c2ce2df2c657544fa51f3cd24cab15c608\\Giriş Kaydol veritabanı.mdb");
        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool isthere;
        private void button1_Click_1(object sender, EventArgs e)
        {
            string kullanici_ad = textBox1.Text;
            string sifre = textBox2.Text;

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Kayitol");
            komut.Connection = baglanti;
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (kullanici_ad == oku["Kullanici Adi"].ToString().TrimEnd() && sifre == oku["Sifre"].ToString().TrimEnd())
                {
                    isthere = true;
                    break;
                }
                else
                {
                    isthere = false;
                }


            }

            if (isthere)
            {
                MessageBox.Show("Başarıyla giriş yaptınız !", "Program");
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(" giriş yapamadınız !", "Program");
            }

            baglanti.Close();
        }

        private void girisyap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran yeni = new AnaEkran();
            yeni.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiunuttum yeni1 = new sifremiunuttum();
            yeni1.Show();
            this.Hide();
        }
    }
}
