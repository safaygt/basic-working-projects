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

namespace resmiTatil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string secilenBayram = comboBayramlar.SelectedItem.ToString();
            string baslangicGun = monthTatil.SelectionStart.ToShortDateString();
            string sonGun = monthTatil.SelectionEnd.ToShortDateString();



            list_resmiTatilGünleri.Items.Add(secilenBayram+ "-->"+ baslangicGun +"-"+sonGun);

            

        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            string silinecekGun = list_resmiTatilGünleri.SelectedItem.ToString();
            list_resmiTatilGünleri.Items.Remove(silinecekGun);
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
