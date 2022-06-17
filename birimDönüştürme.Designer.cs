
namespace birimDönüştürme
{
    partial class birimDönüştürme
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_ikinciUzunluk = new System.Windows.Forms.TextBox();
            this.txt_birinciUzunluk = new System.Windows.Forms.TextBox();
            this.comboİkinciUzunluk = new System.Windows.Forms.ComboBox();
            this.comboBirinciUzunluk = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_powerTwo = new System.Windows.Forms.TextBox();
            this.txt_powerOne = new System.Windows.Forms.TextBox();
            this.combo_guc2 = new System.Windows.Forms.ComboBox();
            this.combo_guc1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_basinc2 = new System.Windows.Forms.TextBox();
            this.txt_basinc1 = new System.Windows.Forms.TextBox();
            this.comboBasinc2 = new System.Windows.Forms.ComboBox();
            this.comboBasinc1 = new System.Windows.Forms.ComboBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_uzunlukHesapla = new System.Windows.Forms.Button();
            this.btn_gucHesapla = new System.Windows.Forms.Button();
            this.btn_basincHesapla = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(107, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(525, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_uzunlukHesapla);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.txt_ikinciUzunluk);
            this.tabPage1.Controls.Add(this.txt_birinciUzunluk);
            this.tabPage1.Controls.Add(this.comboİkinciUzunluk);
            this.tabPage1.Controls.Add(this.comboBirinciUzunluk);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uzunluk";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // txt_ikinciUzunluk
            // 
            this.txt_ikinciUzunluk.Location = new System.Drawing.Point(304, 192);
            this.txt_ikinciUzunluk.Name = "txt_ikinciUzunluk";
            this.txt_ikinciUzunluk.Size = new System.Drawing.Size(100, 22);
            this.txt_ikinciUzunluk.TabIndex = 4;
            // 
            // txt_birinciUzunluk
            // 
            this.txt_birinciUzunluk.Location = new System.Drawing.Point(304, 120);
            this.txt_birinciUzunluk.Name = "txt_birinciUzunluk";
            this.txt_birinciUzunluk.Size = new System.Drawing.Size(100, 22);
            this.txt_birinciUzunluk.TabIndex = 3;
            // 
            // comboİkinciUzunluk
            // 
            this.comboİkinciUzunluk.FormattingEnabled = true;
            this.comboİkinciUzunluk.Items.AddRange(new object[] {
            "metre",
            "inch",
            "feet",
            "yarda",
            "kara mili"});
            this.comboİkinciUzunluk.Location = new System.Drawing.Point(304, 57);
            this.comboİkinciUzunluk.Name = "comboİkinciUzunluk";
            this.comboİkinciUzunluk.Size = new System.Drawing.Size(126, 24);
            this.comboİkinciUzunluk.TabIndex = 1;
            this.comboİkinciUzunluk.SelectedIndexChanged += new System.EventHandler(this.comboİkinciUzunluk_SelectedIndexChanged);
            // 
            // comboBirinciUzunluk
            // 
            this.comboBirinciUzunluk.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBirinciUzunluk.FormattingEnabled = true;
            this.comboBirinciUzunluk.Items.AddRange(new object[] {
            "metre",
            "inch",
            "feet",
            "yarda",
            "kara mili"});
            this.comboBirinciUzunluk.Location = new System.Drawing.Point(81, 57);
            this.comboBirinciUzunluk.Name = "comboBirinciUzunluk";
            this.comboBirinciUzunluk.Size = new System.Drawing.Size(126, 24);
            this.comboBirinciUzunluk.TabIndex = 0;
            this.comboBirinciUzunluk.SelectedIndexChanged += new System.EventHandler(this.comboBirinciUzunluk_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_gucHesapla);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.txt_powerTwo);
            this.tabPage2.Controls.Add(this.txt_powerOne);
            this.tabPage2.Controls.Add(this.combo_guc2);
            this.tabPage2.Controls.Add(this.combo_guc1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(517, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Güç";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            // 
            // txt_powerTwo
            // 
            this.txt_powerTwo.Location = new System.Drawing.Point(307, 220);
            this.txt_powerTwo.Name = "txt_powerTwo";
            this.txt_powerTwo.Size = new System.Drawing.Size(100, 22);
            this.txt_powerTwo.TabIndex = 9;
            // 
            // txt_powerOne
            // 
            this.txt_powerOne.Location = new System.Drawing.Point(307, 148);
            this.txt_powerOne.Name = "txt_powerOne";
            this.txt_powerOne.Size = new System.Drawing.Size(100, 22);
            this.txt_powerOne.TabIndex = 8;
            // 
            // combo_guc2
            // 
            this.combo_guc2.FormattingEnabled = true;
            this.combo_guc2.Items.AddRange(new object[] {
            "kgf.m/s",
            "Kw",
            "Kcal/s",
            "PS"});
            this.combo_guc2.Location = new System.Drawing.Point(307, 85);
            this.combo_guc2.Name = "combo_guc2";
            this.combo_guc2.Size = new System.Drawing.Size(126, 24);
            this.combo_guc2.TabIndex = 7;
            // 
            // combo_guc1
            // 
            this.combo_guc1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.combo_guc1.FormattingEnabled = true;
            this.combo_guc1.Items.AddRange(new object[] {
            "kgf.m/s",
            "Kw",
            "Kcal/s",
            "PS"});
            this.combo_guc1.Location = new System.Drawing.Point(84, 85);
            this.combo_guc1.Name = "combo_guc1";
            this.combo_guc1.Size = new System.Drawing.Size(126, 24);
            this.combo_guc1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_basincHesapla);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.txt_basinc2);
            this.tabPage3.Controls.Add(this.txt_basinc1);
            this.tabPage3.Controls.Add(this.comboBasinc2);
            this.tabPage3.Controls.Add(this.comboBasinc1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(517, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Basınç";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(84, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 17;
            // 
            // txt_basinc2
            // 
            this.txt_basinc2.Location = new System.Drawing.Point(307, 220);
            this.txt_basinc2.Name = "txt_basinc2";
            this.txt_basinc2.Size = new System.Drawing.Size(100, 22);
            this.txt_basinc2.TabIndex = 15;
            // 
            // txt_basinc1
            // 
            this.txt_basinc1.Location = new System.Drawing.Point(307, 148);
            this.txt_basinc1.Name = "txt_basinc1";
            this.txt_basinc1.Size = new System.Drawing.Size(100, 22);
            this.txt_basinc1.TabIndex = 14;
            // 
            // comboBasinc2
            // 
            this.comboBasinc2.FormattingEnabled = true;
            this.comboBasinc2.Items.AddRange(new object[] {
            "atm",
            "psi",
            "bar"});
            this.comboBasinc2.Location = new System.Drawing.Point(307, 85);
            this.comboBasinc2.Name = "comboBasinc2";
            this.comboBasinc2.Size = new System.Drawing.Size(126, 24);
            this.comboBasinc2.TabIndex = 13;
            // 
            // comboBasinc1
            // 
            this.comboBasinc1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBasinc1.FormattingEnabled = true;
            this.comboBasinc1.Items.AddRange(new object[] {
            "atm",
            "psi",
            "bar"});
            this.comboBasinc1.Location = new System.Drawing.Point(84, 85);
            this.comboBasinc1.Name = "comboBasinc1";
            this.comboBasinc1.Size = new System.Drawing.Size(126, 24);
            this.comboBasinc1.TabIndex = 12;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(454, 384);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(132, 40);
            this.btn_cikis.TabIndex = 1;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_uzunlukHesapla
            // 
            this.btn_uzunlukHesapla.Location = new System.Drawing.Point(82, 256);
            this.btn_uzunlukHesapla.Name = "btn_uzunlukHesapla";
            this.btn_uzunlukHesapla.Size = new System.Drawing.Size(137, 40);
            this.btn_uzunlukHesapla.TabIndex = 2;
            this.btn_uzunlukHesapla.Text = "Hesapla";
            this.btn_uzunlukHesapla.UseVisualStyleBackColor = true;
            this.btn_uzunlukHesapla.Click += new System.EventHandler(this.btn_uzunlukHesapla_Click);
            // 
            // btn_gucHesapla
            // 
            this.btn_gucHesapla.Location = new System.Drawing.Point(85, 269);
            this.btn_gucHesapla.Name = "btn_gucHesapla";
            this.btn_gucHesapla.Size = new System.Drawing.Size(107, 36);
            this.btn_gucHesapla.TabIndex = 12;
            this.btn_gucHesapla.Text = "Hesapla";
            this.btn_gucHesapla.UseVisualStyleBackColor = true;
            this.btn_gucHesapla.Click += new System.EventHandler(this.btn_gucHesapla_Click_1);
            // 
            // btn_basincHesapla
            // 
            this.btn_basincHesapla.Location = new System.Drawing.Point(86, 270);
            this.btn_basincHesapla.Name = "btn_basincHesapla";
            this.btn_basincHesapla.Size = new System.Drawing.Size(99, 34);
            this.btn_basincHesapla.TabIndex = 18;
            this.btn_basincHesapla.Text = "Hesapla";
            this.btn_basincHesapla.UseVisualStyleBackColor = true;
            this.btn_basincHesapla.Click += new System.EventHandler(this.btn_basincHesapla_Click_1);
            // 
            // birimDönüştürme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.tabControl1);
            this.Name = "birimDönüştürme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.birimDönüştürme_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_ikinciUzunluk;
        private System.Windows.Forms.TextBox txt_birinciUzunluk;
        private System.Windows.Forms.ComboBox comboİkinciUzunluk;
        private System.Windows.Forms.ComboBox comboBirinciUzunluk;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_uzunlukHesapla;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_powerTwo;
        private System.Windows.Forms.TextBox txt_powerOne;
        private System.Windows.Forms.ComboBox combo_guc2;
        private System.Windows.Forms.ComboBox combo_guc1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txt_basinc2;
        private System.Windows.Forms.TextBox txt_basinc1;
        private System.Windows.Forms.ComboBox comboBasinc2;
        private System.Windows.Forms.ComboBox comboBasinc1;
        private System.Windows.Forms.Button btn_gucHesapla;
        private System.Windows.Forms.Button btn_basincHesapla;
    }
}

