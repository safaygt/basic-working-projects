
namespace kitapSiparişListesi
{
    partial class kitapSipariş
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
            this.label2 = new System.Windows.Forms.Label();
            this.checked_kitapListe = new System.Windows.Forms.CheckedListBox();
            this.list_siparişListe = new System.Windows.Forms.ListView();
            this.btn_sipariş = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KİTAP LİSTESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(479, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "SİPARİŞ LİSTESİ";
            // 
            // checked_kitapListe
            // 
            this.checked_kitapListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checked_kitapListe.FormattingEnabled = true;
            this.checked_kitapListe.Items.AddRange(new object[] {
            "AutoCAD 14\t",
            "AutoCAD 2000",
            "AutoCAD 2002",
            "Visual Basic.Net",
            "Pro/ENGINEER 2001",
            "Catia V5 R9",
            "Visual Basic 6.0",
            "Turbo Pascal 7.0"});
            this.checked_kitapListe.Location = new System.Drawing.Point(159, 93);
            this.checked_kitapListe.Name = "checked_kitapListe";
            this.checked_kitapListe.Size = new System.Drawing.Size(170, 242);
            this.checked_kitapListe.TabIndex = 1;
            // 
            // list_siparişListe
            // 
            this.list_siparişListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_siparişListe.HideSelection = false;
            this.list_siparişListe.Location = new System.Drawing.Point(471, 93);
            this.list_siparişListe.Name = "list_siparişListe";
            this.list_siparişListe.Size = new System.Drawing.Size(187, 242);
            this.list_siparişListe.TabIndex = 2;
            this.list_siparişListe.UseCompatibleStateImageBehavior = false;
            this.list_siparişListe.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btn_sipariş
            // 
            this.btn_sipariş.Location = new System.Drawing.Point(172, 365);
            this.btn_sipariş.Name = "btn_sipariş";
            this.btn_sipariş.Size = new System.Drawing.Size(129, 36);
            this.btn_sipariş.TabIndex = 3;
            this.btn_sipariş.Text = "Sipariş Listesi";
            this.btn_sipariş.UseVisualStyleBackColor = true;
            this.btn_sipariş.Click += new System.EventHandler(this.btn_sipariş_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(498, 366);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(129, 36);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // kitapSipariş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_sipariş);
            this.Controls.Add(this.list_siparişListe);
            this.Controls.Add(this.checked_kitapListe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kitapSipariş";
            this.Text = "Kitap Sipariş Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checked_kitapListe;
        private System.Windows.Forms.ListView list_siparişListe;
        private System.Windows.Forms.Button btn_sipariş;
        private System.Windows.Forms.Button btn_cikis;
    }
}

