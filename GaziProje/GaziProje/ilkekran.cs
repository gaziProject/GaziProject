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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girisyap yeni = new girisyap();
            yeni.Show();
            this.Hide();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            // şampiyonlar ligi müziği eklenecek
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtol obj = new kayıtol();
            obj.Show();
            this.Hide();
        }
    }
}
