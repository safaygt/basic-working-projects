
namespace resmiTatil
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBayramlar = new System.Windows.Forms.ComboBox();
            this.monthTatil = new System.Windows.Forms.MonthCalendar();
            this.list_resmiTatilGünleri = new System.Windows.Forms.ListBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resmi Tatiller";
            // 
            // comboBayramlar
            // 
            this.comboBayramlar.FormattingEnabled = true;
            this.comboBayramlar.Items.AddRange(new object[] {
            "Ramazan Bayramı",
            "Kurban Bayramı",
            "23 Nisan Bayramı",
            "19 Mayıs Bayramı",
            "29 Ekim Bayramı",
            "30 Ağustos Bayramı"});
            this.comboBayramlar.Location = new System.Drawing.Point(52, 79);
            this.comboBayramlar.Name = "comboBayramlar";
            this.comboBayramlar.Size = new System.Drawing.Size(121, 24);
            this.comboBayramlar.TabIndex = 1;
            // 
            // monthTatil
            // 
            this.monthTatil.Location = new System.Drawing.Point(18, 137);
            this.monthTatil.Name = "monthTatil";
            this.monthTatil.TabIndex = 2;
            // 
            // list_resmiTatilGünleri
            // 
            this.list_resmiTatilGünleri.FormattingEnabled = true;
            this.list_resmiTatilGünleri.ItemHeight = 16;
            this.list_resmiTatilGünleri.Location = new System.Drawing.Point(498, 92);
            this.list_resmiTatilGünleri.Name = "list_resmiTatilGünleri";
            this.list_resmiTatilGünleri.Size = new System.Drawing.Size(354, 276);
            this.list_resmiTatilGünleri.TabIndex = 3;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(368, 148);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(87, 34);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(368, 224);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(87, 38);
            this.btn_cikar.TabIndex = 5;
            this.btn_cikar.Text = "Çıkar";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(368, 298);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(87, 34);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(470, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resmi Tatil Günleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.list_resmiTatilGünleri);
            this.Controls.Add(this.monthTatil);
            this.Controls.Add(this.comboBayramlar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Resmi Tatil Günleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBayramlar;
        private System.Windows.Forms.MonthCalendar monthTatil;
        private System.Windows.Forms.ListBox list_resmiTatilGünleri;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label2;
    }
}

