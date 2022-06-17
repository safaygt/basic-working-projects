//SAFA YİĞİT
//Bilişim Sistemleri Mühendisliği 1. Sınıf
//B201200001




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renkAyarlama
{
    public partial class renkAyarla : Form
    {
        public renkAyarla()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            renk_ayarla();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            renk_ayarla();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            renk_ayarla();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            renk_ayarla();
        }

        private void hScrollBar5_Scroll(object sender, ScrollEventArgs e)
            
        {
            renk_ayarla();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            renk_ayarla();
        }
        public void renk_ayarla()
        {
            Color renk = Color.FromArgb(hScrollBar5.Value,hScrollBar3.Value,hScrollBar1.Value);

            lbl_yazi.ForeColor = renk;

            Color rank = Color.FromArgb(vScrollBar2.Value, vScrollBar3.Value, vScrollBar1.Value);

            panel1.BackColor = rank;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
