
namespace GaziProje
{
    partial class AnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.AraBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AraBtn
            // 
            this.AraBtn.BackColor = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.AraBtn, "AraBtn");
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.UseVisualStyleBackColor = false;
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // AnaEkran
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.AraBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AraBtn;
    }
}

