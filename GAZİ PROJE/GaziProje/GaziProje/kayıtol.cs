using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaziProje
{
    public partial class kayıtol : Form
    {
        public kayıtol()
        {
            InitializeComponent();
        }

        private void kayıtol_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Bu özellikler değişicek

            
            if (comboBox5.Text == "Forvet")
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Bitiriciliğim İyi");
                checkedListBox1.Items.Add("Şutum Öldürücü");
                checkedListBox1.Items.Add("Gol Sezilerim Kuvvetli");
                checkedListBox1.Items.Add("Kafa Vuruşlarım Darbeli");
                checkedListBox1.Items.Add("Götüm Taş Gibi");
            }
            if (comboBox5.Text == "Orta Saha")
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Bitiriciliğim İyi");
                checkedListBox1.Items.Add("Şutum Öldürücü");
                checkedListBox1.Items.Add("Gol Sezilerim Kuvvetli");
                checkedListBox1.Items.Add("Kafa Vuruşlarım Darbeli");
                checkedListBox1.Items.Add("Götüm Taş Gibi");
            }
            if (comboBox5.Text == "Defans")
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Bitiriciliğim İyi");
                checkedListBox1.Items.Add("Şutum Öldürücü");
                checkedListBox1.Items.Add("Gol Sezilerim Kuvvetli");
                checkedListBox1.Items.Add("Kafa Vuruşlarım Darbeli");
                checkedListBox1.Items.Add("Götüm Taş Gibi");
            }
            if (comboBox5.Text == "Kaleci")
            {
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.Add("Bitiriciliğim İyi");
                checkedListBox1.Items.Add("Şutum Öldürücü");
                checkedListBox1.Items.Add("Gol Sezilerim Kuvvetli");
                checkedListBox1.Items.Add("Kafa Vuruşlarım Darbeli");
                checkedListBox1.Items.Add("Götüm Taş Gibi");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Burası Temizleme bölümü tek tek text boxlar temizlenicek

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // required field özelliği eklenmesi lazım  
            MessageBox.Show("Kayıdınız Başarıyla Gerçekleşmiştir!!");

            AnaEkran yeni = new AnaEkran();
            yeni.Show();
            this.Hide();
        }
    }
}
