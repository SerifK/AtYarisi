using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int girilenTutar=0;
        int kazanılanTutar=0;
        int bahisOynananAt=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false;
            btnTekrar.Enabled = false;
            btnBastanBasla.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

            pbxAt1.Left += rnd.Next(5, 15);
            pbxAt2.Left += rnd.Next(5, 15);
            pbxAt3.Left += rnd.Next(5, 15);

            int birinciAtGenislik = pbxAt1.Width;
            int ikinciAtGenislik = pbxAt2.Width;
            int ucuncuAtGenislik = pbxAt3.Width;

            int BitisCizgisi = lblBitis.Left;

            if (pbxAt1.Left > pbxAt2.Left && pbxAt1.Left > pbxAt3.Left)
            {
                lblBilgi.Text = "1 Numaralı At Önde Gidiyor";
            }
            else if (pbxAt2.Left > pbxAt1.Left && pbxAt2.Left > pbxAt3.Left)
            {
                lblBilgi.Text = "2 Numaralı At Öne Geçti";
            }
            else
            {
                lblBilgi.Text = "3 Numaralı At Durdurulamıyor";
            }

            if(pbxAt1.Left + birinciAtGenislik >= BitisCizgisi)
            {
                timer1.Enabled = false;
                lblBilgi.Text = "1 Numaralı At Yarışı Kazandı";          
                if (bahisOynananAt == 1)
                {
                    lblMiktar.Text = (Convert.ToInt32(lblMiktar.Text) + kazanılanTutar).ToString();
                    lblDurum.Text = "Kazandınız";
                    btnTekrar.Enabled = true;
                }
                else
                {
                    lblDurum.Text = "Kaybettiniz";
                    btnTekrar.Enabled = true;
                    if (Convert.ToInt32(lblMiktar.Text) == 0)
                    {
                        MessageBox.Show("Ne Yazıkki Paranız Bitti :( \nBaştan Başlayınız :)");
                        btnBahis.Enabled = false;
                        btnTekrar.Enabled = false;
                        btnBastanBasla.Enabled = true;
                    }


                }
                
            }
            if(pbxAt2.Left + ikinciAtGenislik >= BitisCizgisi)
            {
                timer1.Enabled = false;
                lblBilgi.Text = "2 Numaralı At Yarışı Kazandı";
                if (bahisOynananAt == 2)
                {
                    lblMiktar.Text = (Convert.ToInt32(lblMiktar.Text) + kazanılanTutar).ToString();
                    lblDurum.Text = "Kazandınız";
                    btnTekrar.Enabled = true;
                }
                else
                {
                    lblDurum.Text = "Kaybettiniz";
                    btnTekrar.Enabled = true;
                    if (Convert.ToInt32(lblMiktar.Text) == 0)
                    {
                        MessageBox.Show("Ne Yazıkki Paranız Bitti :( \nBaştan Başlayınız :)");
                        btnBahis.Enabled = false;
                        btnTekrar.Enabled = false;
                        btnBastanBasla.Enabled = true;
                    }
                }
            }
            if(pbxAt3.Left + ucuncuAtGenislik >= BitisCizgisi)
            {
                timer1.Enabled = false;
                lblBilgi.Text = "3 Numaralı At Yarışı Kazandı";
                if (bahisOynananAt == 3)
                {
                    lblMiktar.Text = (Convert.ToInt32(lblMiktar.Text) + kazanılanTutar).ToString();
                    lblDurum.Text = "Kazandınız";
                    btnTekrar.Enabled = true;
                }
                else
                {
                    lblDurum.Text = "Kaybettiniz";
                    btnTekrar.Enabled = true;
                    if (Convert.ToInt32(lblMiktar.Text) == 0)
                    {
                        MessageBox.Show("Ne Yazıkki Paranız Bitti :( \nBaştan Başlayınız :)");
                        btnBahis.Enabled = false;
                        btnTekrar.Enabled = false;
                        btnBastanBasla.Enabled = true;
                    }
                }
            }

            
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnBaslat.Enabled = false;
        }

        private void btnBahis_Click(object sender, EventArgs e)
        {
           
            girilenTutar = Convert.ToInt32(tbxBahis.Text);
            kazanılanTutar = girilenTutar * 2;
            bahisOynananAt = Convert.ToInt32(tbxAt.Text);
            
            if(girilenTutar > Convert.ToInt32(lblMiktar.Text) || bahisOynananAt > 3)
            {
                MessageBox.Show("Para miktarınızı aşamazsınız veya olmayan at numarasını giremezsiniz");
            }
            else
            {
                lblMiktar.Text = (Convert.ToInt32(lblMiktar.Text) - girilenTutar).ToString();
                btnBahis.Enabled = false;
                btnBaslat.Enabled = true;
            }

        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            pbxAt1.Left = 2;
            pbxAt2.Left = 2;
            pbxAt3.Left = 2;
            btnBahis.Enabled = true;
            lblDurum.Text = "";
            lblBilgi.Text = "";
            tbxAt.Text = "";
            tbxBahis.Text = "";
            btnTekrar.Enabled = false;

        }

        private void btnBastanBasla_Click(object sender, EventArgs e)
        {
            lblMiktar.Text = (Convert.ToInt32(lblMiktar.Text) + 100).ToString();
            pbxAt1.Left = 2;
            pbxAt2.Left = 2;
            pbxAt3.Left = 2;
            lblDurum.Text = "";
            lblBilgi.Text = "";
            tbxAt.Text = "";
            tbxBahis.Text = "";
            btnBahis.Enabled = true;
            btnBastanBasla.Enabled = false;
        }
    }
}
