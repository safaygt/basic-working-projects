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

namespace birimDönüştürme
{


    public partial class birimDönüştürme : Form
    {

        double metre, inch, foot, yarda, kara_mili;
        double kgf,kw, kcal, PS;

        private void birimDönüştürme_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Birim dönüştürme programına hoşgeldiniz.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.None);
            ;        }

        private void comboBirinciUzunluk_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {

            

           
            
        }

        private void btn_basincHesapla_Click(object sender, EventArgs e)
        {


           

        }

        private void btn_uzunlukHesapla_Click(object sender, EventArgs e)
        {
            string secilenUzunluk = comboBirinciUzunluk.SelectedItem.ToString();
            string secilenUzunlukİki = comboİkinciUzunluk.SelectedItem.ToString();


            if (secilenUzunluk == "metre")
            {
                if (secilenUzunlukİki == "metre")
                {

                    textBox1.Text = "metre";
                    textBox2.Text = "metre";

                    txt_ikinciUzunluk.Text = txt_birinciUzunluk.Text;

                }
                else if (secilenUzunlukİki == "inch")
                {
                    textBox1.Text = "metre";
                    textBox2.Text = "inch";

                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 39.3701;
                    txt_ikinciUzunluk.Text = sonuc.ToString();

                }
                else if (secilenUzunlukİki == "feet")
                {
                    textBox1.Text = "metre";
                    textBox2.Text = "feet";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 3.28084;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "yarda")
                {
                    textBox1.Text = "metre";
                    textBox2.Text = "yarda";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1.09361;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "kara mili")
                {
                    textBox1.Text = "metre";
                    textBox2.Text = "kara mili";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 0.00062137;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }

            }
            else if (secilenUzunluk == "inch")
            {
                if (secilenUzunlukİki == "metre")
                {
                    textBox1.Text = "inch";
                    textBox2.Text = "metre";

                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1 / 39.3701;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "inch")
                {
                    textBox1.Text = "inch";
                    textBox2.Text = "inch";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "feet")
                {
                    textBox1.Text = "inch";
                    textBox2.Text = "feet";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1 / 12;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "yarda")
                {
                    textBox1.Text = "inch";
                    textBox2.Text = "yarda";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1 / 36;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "kara mili")
                {
                    textBox1.Text = "inch";
                    textBox2.Text = "kara mili";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 0.00001578282;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
            }
            else if (secilenUzunluk == "feet")
            {
                if (secilenUzunlukİki == "metre")
                {
                    textBox1.Text = "feet";
                    textBox2.Text = "metre";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 0.3048;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "inch")
                {
                    textBox1.Text = "feet";
                    textBox2.Text = "inch";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 12;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "feet")
                {
                    textBox1.Text = "feet";
                    textBox2.Text = "feet";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1;
                    txt_ikinciUzunluk.Text = sonuc.ToString();

                }

                else if (secilenUzunlukİki == "yarda")
                {
                    textBox1.Text = "feet";
                    textBox2.Text = "yarda";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1 / 3;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "kara mili")
                {
                    textBox1.Text = "feet";
                    textBox2.Text = "kara mili";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1 / 5280;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }


            }
            else if (secilenUzunluk == "yarda")
            {
                if (secilenUzunlukİki == "metre")
                {
                    textBox1.Text = "yarda";
                    textBox2.Text = "metre";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 0.9144;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "inch")
                {
                    textBox1.Text = "yarda";
                    textBox2.Text = "inch";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 36;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "feet")
                {
                    textBox1.Text = "yarda";
                    textBox2.Text = "feet";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 3;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "yarda")
                {
                    textBox1.Text = "yarda";
                    textBox2.Text = "yarda";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "kara mili")
                {

                    textBox1.Text = "yarda";
                    textBox2.Text = "kara mili";
                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 0.000568181818;
                    txt_ikinciUzunluk.Text = sonuc.ToString();

                }

            }
            else if (secilenUzunluk == "kara mili")
            {
                if (secilenUzunlukİki == "metre")
                {
                    textBox1.Text = "kara mili";
                    textBox2.Text = "metre";

                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1609;
                    txt_ikinciUzunluk.Text = sonuc.ToString();


                }
                else if (secilenUzunlukİki == "inch")
                {
                    textBox1.Text = "kara mili";
                    textBox2.Text = "inch";

                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 63360;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "feet")
                {
                    textBox1.Text = "kara mili";
                    textBox2.Text = "feet";

                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 5280;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "yarda")
                {
                    textBox1.Text = "kara mili";
                    textBox2.Text = "yarda";

                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1760;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
                else if (secilenUzunlukİki == "kara mili")
                {
                    textBox1.Text = "kara mili";
                    textBox2.Text = "kara mili";

                    double sonuc = Convert.ToDouble(txt_birinciUzunluk.Text) * 1;
                    txt_ikinciUzunluk.Text = sonuc.ToString();
                }
            }


        }

        private void btn_gucHesapla_Click_1(object sender, EventArgs e)
        {
            string birinciGuc = combo_guc1.SelectedItem.ToString();
            string ikinciGuc = combo_guc2.SelectedItem.ToString();

            if (birinciGuc == "kgf.m/s")
            {
                if (ikinciGuc == "kgf.m/s")
                {
                    textBox4.Text = "kgf";
                    textBox3.Text = "kgf";


                    double sonuc = Convert.ToDouble(txt_powerOne.Text)*1;
                    txt_powerTwo.Text = sonuc.ToString();


                }
                else if (ikinciGuc == "Kw")
                {
                    textBox4.Text = "kgf";
                    textBox3.Text = "Kw";

                    double sonuc = Convert.ToDouble(txt_powerOne.Text) * 0.0098;

                    txt_powerTwo.Text = sonuc.ToString();
                }
                else if (ikinciGuc == "Kcal/s")
                {
                    textBox4.Text = "kgf";
                    textBox3.Text = "Kcal";

                    double sonuc = Convert.ToDouble(txt_powerOne.Text) * 0.00234;

                    txt_powerTwo.Text = sonuc.ToString();
                }
                else if (ikinciGuc == "PS")
                {
                    textBox4.Text = "kgf";
                    textBox3.Text = "PS";

                    double sonuc = Convert.ToDouble(txt_powerOne.Text) * 0.0133;

                    txt_powerTwo.Text = sonuc.ToString();
                }
            }


        }

        private void btn_basincHesapla_Click_1(object sender, EventArgs e)
        {
            string birinciBasinc = comboBasinc1.SelectedItem.ToString();
            string ikinciBasinc = comboBasinc2.SelectedItem.ToString();

            if(birinciBasinc == "atm")
            {
                if (ikinciBasinc == "atm")
                {
                    textBox6.Text = "atm";
                    textBox5.Text = "atm";

                    double sonuc = Convert.ToDouble(txt_basinc1.Text) * 1;
                    txt_basinc2.Text = sonuc.ToString();

                }
                else if (ikinciBasinc == "psi")
                {
                    textBox6.Text = "atm";
                    textBox5.Text = "psi";

                    double sonuc = Convert.ToDouble(txt_basinc1.Text) * 14.65;

                    txt_basinc2.Text = sonuc.ToString();
                }
                else if (ikinciBasinc == "bar")
                {
                    textBox6.Text = "atm";
                    textBox5.Text = "bar";

                    double sonuc = Convert.ToDouble(txt_basinc1.Text) * 1.01;

                    txt_basinc2.Text = sonuc.ToString();
                }
            }



        }

        private void comboİkinciUzunluk_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_gucHesapla_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public birimDönüştürme()
        {
            InitializeComponent();
        }

        private void lbl_birinciUzunluk_Click(object sender, EventArgs e)
        {
            
            
        }
        
        private void lbl_ikinciUzunluk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
