
namespace GaziProje
{
    partial class Arama
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SahaNoTextBox = new System.Windows.Forms.TextBox();
            this.AraButton = new System.Windows.Forms.Button();
            this.SıralaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DegerlendirmeBtn = new System.Windows.Forms.Button();
            this.FiyatsiralaBtn = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(62, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(846, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Halısaha Adı";
            this.columnHeader2.Width = 232;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İlçe";
            this.columnHeader3.Width = 256;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Halısaha No:";
            // 
            // SahaNoTextBox
            // 
            this.SahaNoTextBox.Location = new System.Drawing.Point(211, 47);
            this.SahaNoTextBox.Multiline = true;
            this.SahaNoTextBox.Name = "SahaNoTextBox";
            this.SahaNoTextBox.Size = new System.Drawing.Size(122, 25);
            this.SahaNoTextBox.TabIndex = 2;
            // 
            // AraButton
            // 
            this.AraButton.Location = new System.Drawing.Point(376, 48);
            this.AraButton.Name = "AraButton";
            this.AraButton.Size = new System.Drawing.Size(86, 24);
            this.AraButton.TabIndex = 3;
            this.AraButton.Text = "Ara";
            this.AraButton.UseVisualStyleBackColor = true;
            // 
            // SıralaBtn
            // 
            this.SıralaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SıralaBtn.Location = new System.Drawing.Point(996, 47);
            this.SıralaBtn.Name = "SıralaBtn";
            this.SıralaBtn.Size = new System.Drawing.Size(164, 47);
            this.SıralaBtn.TabIndex = 4;
            this.SıralaBtn.Text = "Tüm sahalaarı sırala";
            this.SıralaBtn.UseVisualStyleBackColor = true;
            this.SıralaBtn.Click += new System.EventHandler(this.SıralaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(914, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlçe seçiniz";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1076, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(914, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fiyat Aralığı Giriniz";
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(1112, 402);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(40, 22);
            this.minTextBox.TabIndex = 8;
            this.minTextBox.Text = "min";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(1183, 402);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(40, 22);
            this.maxTextBox.TabIndex = 9;
            this.maxTextBox.Text = "max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1158, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DegerlendirmeBtn
            // 
            this.DegerlendirmeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DegerlendirmeBtn.Location = new System.Drawing.Point(996, 136);
            this.DegerlendirmeBtn.Name = "DegerlendirmeBtn";
            this.DegerlendirmeBtn.Size = new System.Drawing.Size(164, 47);
            this.DegerlendirmeBtn.TabIndex = 11;
            this.DegerlendirmeBtn.Text = "Değerlendirmeye göre sırala";
            this.DegerlendirmeBtn.UseVisualStyleBackColor = true;
            // 
            // FiyatsiralaBtn
            // 
            this.FiyatsiralaBtn.Location = new System.Drawing.Point(1093, 439);
            this.FiyatsiralaBtn.Name = "FiyatsiralaBtn";
            this.FiyatsiralaBtn.Size = new System.Drawing.Size(130, 24);
            this.FiyatsiralaBtn.TabIndex = 12;
            this.FiyatsiralaBtn.Text = "Sırala";
            this.FiyatsiralaBtn.UseVisualStyleBackColor = true;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Değerlendirme";
            this.columnHeader5.Width = 124;
            // 
            // Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1267, 686);
            this.Controls.Add(this.FiyatsiralaBtn);
            this.Controls.Add(this.DegerlendirmeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SıralaBtn);
            this.Controls.Add(this.AraButton);
            this.Controls.Add(this.SahaNoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama";
            this.Load += new System.EventHandler(this.Arama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SahaNoTextBox;
        private System.Windows.Forms.Button AraButton;
        private System.Windows.Forms.Button SıralaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DegerlendirmeBtn;
        private System.Windows.Forms.Button FiyatsiralaBtn;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}