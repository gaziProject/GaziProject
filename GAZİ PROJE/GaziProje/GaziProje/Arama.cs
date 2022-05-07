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
//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\6ncaf\OneDrive\Masaüstü\git\GaziProject\Halısaha.mdb
namespace GaziProje
{
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \\Users\\6ncaf\\OneDrive\\Masaüstü\\git\\GAZİ PROJE\\Halısaha.mdb");
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void goruntule()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From Ana");
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Kimlik"].ToString();
                ekle.SubItems.Add( oku["HalısahaAdı"].ToString());
                ekle.SubItems.Add(oku["Ilce"].ToString());
                ekle.SubItems.Add(oku["Fiyat"].ToString());
                ekle.SubItems.Add(oku["Degerlendirme"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void Arama_Load(object sender, EventArgs e)
        {

        }

        private void SıralaBtn_Click(object sender, EventArgs e)
        {
            goruntule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezervasyon_Görüntüleme rezervasyon_Görüntüleme = new Rezervasyon_Görüntüleme();
            rezervasyon_Görüntüleme.Show();
            Hide();                                 
                
        }
    }
}
