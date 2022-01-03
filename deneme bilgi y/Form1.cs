using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_bilgi_y
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, doğru = 0, yanlış = 0;

        private void btnsonra_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnsonra.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblsoru.Text = soruno.ToString();
            if(soruno==1)
            {
                richTextBox1.Text = "Cumhuriyet hangi yılda ilan edilmiştir?";
                btna.Text= "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";

            }
            if(soruno==2)
            {
                richTextBox1.Text = "Hangisi Ege bölgemizde bulunan bir il değildir?";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Manisa";
                label4.Text = "Balıkesir";

            }
            if(soruno==3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                btna.Text = "Sait Faik";
                btnb.Text = "Cemal Süreyya";
                btnc.Text = "Atilla İlhan";
                btnd.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
              
            }
            if(soruno==4)
            {
                richTextBox1.Text = "İstiklal Marşı şairimiz kimdir?";
                btna.Text="Atilla İlhan";
                btnb.Text = "Mehmet Akif Ersoy";
                btnc.Text="Reşat Nuri Güntekin";
                btnd.Text = "Recaizade Mahmut Ekrem";
                label4.Text = "Mehmet Akif Ersoy";
                
            }
            if(soruno==5)
            {
                richTextBox1.Text = "Kadınlara şeçme ve seçilme hakkı hangi tarihte verilmiştir?";
                btna.Text = "23 Nisan 1920";
                btnb.Text = "5 Aralık 1934";
                btnc.Text = "19 Mayıs 1923";
                btnd.Text = "25 Kasım 1934";
                label4.Text = "5 Aralık 1934";
            }
            if(soruno==6)
            {
                richTextBox1.Text = "Kocaeli ilimiz hangi bölgemizdedir?";
                btna.Text = "Ege";
                btnb.Text = "Marmara";
                btnc.Text = "Karadeniz";
                btnd.Text = "Doğu Anadolu";
                label4.Text = "Marmara";
                
                 }
            if(soruno==7)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi Barış Mançoya ait değildir?";
                btna.Text = "Arkadaşım Eşşek";
                btnb.Text = "Sarı Çizmeli Mehmet Ağa";
                btnc.Text = "Kurşuni Renkler";
                btnd.Text = "Gülpembe";
                label4.Text = "Kurşuni Renkler";
            }
            if(soruno ==8)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi dönence adıdır?";
                btna.Text = "Sincap";
                btnb.Text = "Yengeç";
                btnc.Text = "Balık";
                btnd.Text = "Boğa";
                label4.Text = "Yengeç";
            }
            if(soruno==9)
            {
                richTextBox1.Text = "Atatürk'ün nüfusa kayıtlı olduğu il hangisidir?";
                btna.Text = "Ankara";
                btnb.Text = "İzmir";
                btnc.Text = "İstanbul";
                btnd.Text = "Gaziantep";
                label4.Text = "Gaziantep";
            }
            if(soruno==10)
            {
                richTextBox1.Text = "Araba Sevdası hangi yazarımıza aittir?";
                btna.Text = "Mehmet Rauf";
                btnb.Text = "Reşat Nuri";
                btnc.Text = "Recaizade Mahmut Ekrem";
                btnd.Text = "Atilla İlhan";
                label4.Text = "Recaizade Mahmut Ekrem";
                btnsonra.Text = "Sonuçlar...";
            }
            if(soruno==11)
            {

                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonra.Enabled = false;
                MessageBox.Show("Doğru: " + doğru + "\n" + "Yanlış: " + yanlış);
            }

        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonra.Enabled = true;
            label5.Text = btna.Text;
            if(label4.Text==label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonra.Enabled = true;
            label5.Text = btnb.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonra.Enabled = true;
            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnsonra.Enabled = true;
            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lbldoğru.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                lblyanlış.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
