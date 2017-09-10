using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // "Ortopedi", "Kardiyoloji", "Göz", "Rehabilitasyon"

        List<Doktor> doktorlar = new List<Doktor>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Doktor doktor1 = new Doktor("Cabir Hanbeyoğlu", "Göz");
            Doktor doktor2 = new Doktor("Ali Çetiner", "Ortopedi");
            Doktor doktor3 = new Doktor("Mete Akdemir", "Kardiyoloji");
            Doktor doktor4 = new Doktor("Gizem Lermi", "Rehabilitasyon");
            Doktor doktor5 = new Doktor("Onur Şişoğlu", "Göz");
            doktorlar.Add(doktor1);
            doktorlar.Add(doktor2);
            doktorlar.Add(doktor3);
            doktorlar.Add(doktor4);
            doktorlar.Add(doktor5);

            //  List<string> Branslar = doktorlar.Select(x => x.Brans).Distinct().ToList();




        }

        private void cb_Brans_Secimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Brans_Secimi.SelectedIndex == -1)
            {
                return;
            }
            cb_Doktor_Secimi.Items.Clear();
            List<Doktor> branslidoktor = doktorlar.Where(x => x.Brans == cb_Brans_Secimi.SelectedItem.ToString()).ToList();
            foreach (var item in branslidoktor)
            {
                cb_Doktor_Secimi.Items.Add(item);
            }

        }

        List<Randevu> Randevular = new List<Randevu>();

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (btn_Ekle.Text == "Ekle")
            {
                Hasta yeniHasta = new Hasta();
                yeniHasta.KimlikNo = txt_KimlikNo.Text;
                yeniHasta.AdSoyad = txt_AdSoyad.Text;
                yeniHasta.DogumTarihi = dt_DogumTarihi.Value;
                yeniHasta.Cinsiyet = checkB_Erkek.Checked ? 'E' : 'K';

                Randevu yeniRandevu = new Randevu();
                yeniRandevu.HastaBilgileri = yeniHasta;
                yeniRandevu.DoktorBilgileri = (Doktor)cb_Doktor_Secimi.SelectedItem;
                yeniRandevu.RandevuTarihi = dt_Randevu_Tarihi.Value;
                yeniRandevu.RandevuSaati = cb_Saat.SelectedItem.ToString() + ":" + cb_Dakika.SelectedItem.ToString();

                Randevular.Add(yeniRandevu);

                lb_Hastalar.Items.Clear();
                foreach (var item in Randevular)
                {
                    lb_Hastalar.Items.Add(item);
                }

                Temizle();

                lbl_Hasta_Sayisi.Text = "Toplam {" + Randevular.Count + "} Hasta";

                List<Randevu> BugunkuRandevular = Randevular.Where(x => x.RandevuTarihi.ToShortDateString() == DateTime.Today.ToShortDateString()).ToList();

                dataGridView1.DataSource = null;
                int i = 0;

                var liste = (from a in BugunkuRandevular
                             select new
                             {
                                 HastaAdi = a.HastaBilgileri.AdSoyad,
                                 a.HastaBilgileri.Cinsiyet,
                                 DoktorAdi = a.DoktorBilgileri.AdSoyad,
                                 a.DoktorBilgileri.Brans,
                                 Tarih = a.RandevuTarihi.ToShortDateString()
                             });
                dataGridView1.DataSource = liste.ToList();
            }
            else
            {
                Randevu seciliRandevu = Randevular[lb_Hastalar.SelectedIndex];
                seciliRandevu.HastaBilgileri.KimlikNo = txt_KimlikNo.Text;
                seciliRandevu.HastaBilgileri.AdSoyad = txt_AdSoyad.Text;
                seciliRandevu.HastaBilgileri.Cinsiyet = checkB_Erkek.Checked ? 'E' : 'K';
                seciliRandevu.HastaBilgileri.DogumTarihi = dt_DogumTarihi.Value;

                seciliRandevu.DoktorBilgileri = (Doktor)cb_Doktor_Secimi.SelectedItem;
                seciliRandevu.RandevuTarihi = dt_Randevu_Tarihi.Value;
                seciliRandevu.RandevuSaati = cb_Saat.SelectedItem.ToString() + ":" + cb_Dakika.SelectedItem.ToString();

                lb_Hastalar.Items.Clear();
                foreach (var item in Randevular)
                {
                    lb_Hastalar.Items.Add(item);
                }

                Temizle();

                btn_Ekle.Text = "Ekle";

            }



        }

        void Temizle()
        {
            checkB_Erkek.Checked = false;
            txt_AdSoyad.Clear();
            txt_KimlikNo.Clear();
            dt_DogumTarihi.Value = DateTime.Now;
            dt_Randevu_Tarihi.Value = DateTime.Now;
            cb_Brans_Secimi.SelectedIndex = -1;
            cb_Doktor_Secimi.SelectedIndex = -1;
            cb_Saat.SelectedIndex = -1;
            cb_Dakika.SelectedIndex = -1;

        }

        private void lb_Hastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Randevu seciliRandevu = (Randevu)lb_Hastalar.SelectedItem;

            txt_KimlikNo.Text = seciliRandevu.HastaBilgileri.KimlikNo;
            txt_AdSoyad.Text = seciliRandevu.HastaBilgileri.AdSoyad;
            dt_DogumTarihi.Value = seciliRandevu.HastaBilgileri.DogumTarihi;
            cb_Brans_Secimi.SelectedItem = seciliRandevu.DoktorBilgileri.Brans;
            cb_Doktor_Secimi.SelectedItem = seciliRandevu.DoktorBilgileri;
            dt_Randevu_Tarihi.Value = seciliRandevu.RandevuTarihi;
            cb_Saat.SelectedItem = seciliRandevu.RandevuSaati.Split(':')[0];
            cb_Dakika.SelectedItem = seciliRandevu.RandevuSaati.Split(':')[1];
            checkB_Erkek.Checked = seciliRandevu.HastaBilgileri.Cinsiyet == 'E' ? true : false;

            btn_Ekle.Text = "Güncelle";
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Randevular.RemoveAt(lb_Hastalar.SelectedIndex);

            lb_Hastalar.Items.Clear();
            foreach (var item in Randevular)
            {
                lb_Hastalar.Items.Add(item);
            }

            Temizle();

            lbl_Hasta_Sayisi.Text = "Toplam {" + Randevular.Count + "} Hasta";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}