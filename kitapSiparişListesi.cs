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

namespace kitapSiparişListesi
{
    public partial class kitapSipariş : Form
    {

        public kitapSipariş()
        {
            InitializeComponent();
        }

        private void btn_sipariş_Click(object sender, EventArgs e)
        {
            list_siparişListe.Items.Clear();

            foreach (string eleman in checked_kitapListe.CheckedItems)
            {
                list_siparişListe.Items.Add(eleman);
            }


        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

}