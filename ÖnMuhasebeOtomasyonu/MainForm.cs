using _BusinessLayer;
using ÖnMuhasebeOtomasyonu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ÖnMuhasebeOtomasyonu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FrmBaslangic frm_baslangic;
        // Ana Formlar
        FrmKasalar frm_kasalar;
        FrmCariKartlar frm_carikartlar;
        FrmStoklar frm_stoklar;
        FrmFaturalar frm_faturalar;
        FrmStokHareketleri frm_stokhareketleri;
        FrmSiparisler frm_siparisler;
        FrmDekontlar frm_dekontlar;
        FrmCekSenetler frm_ceksenetler;
        FrmBankalar frm_bankalar;
        FrmAdresDefterim frm_adresdefterim;
        FrmGorevler frm_gorevler;

        static Creater creater = new Creater();
        db_operation Bill_operation = creater.FactoryMethod(database_PreliminaryAccounting.Bills);


        private void MainForm_Load(object sender, EventArgs e)
        {
            string toolStripItemName = "Kasalar_ana_ToolStripMenuItem";
            //ToolStripItem btn = this.Controls.Find(toolStripItemName, true)[0] as ToolStripItem;

            ana_menuStrip.Cursor = Cursors.Hand;

            frm_baslangic = new FrmBaslangic();
            frm_baslangic.MdiParent = this;
            frm_baslangic.Show();

        }

        private void frm_bellek_temizligi()
        {
            if (frm_baslangic != null) frm_baslangic.Dispose();

            if (frm_kasalar != null) frm_kasalar.Dispose();
            if (frm_carikartlar != null) frm_carikartlar.Dispose();
            if (frm_stoklar != null) frm_stoklar.Dispose();
            if (frm_faturalar != null) frm_faturalar.Dispose();
            if (frm_stokhareketleri != null) frm_stokhareketleri.Dispose();
            if (frm_siparisler != null) frm_siparisler.Dispose();
            if (frm_dekontlar != null) frm_dekontlar.Dispose();
            if (frm_ceksenetler != null) frm_ceksenetler.Dispose();
            if (frm_bankalar != null) frm_bankalar.Dispose();
            if (frm_adresdefterim != null) frm_adresdefterim.Dispose();
            if (frm_gorevler != null) frm_gorevler.Dispose();
        }

        private void tumTablar_ana_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tüm elemanlar pasif olsun
            Color pasif_rgb = new Color();
            pasif_rgb = Color.FromArgb(155, 222, 255);

            foreach (ToolStripItem tum_toolStripItem in ana_menuStrip.Items)
            {
                tum_toolStripItem.BackColor = pasif_rgb;
                tum_toolStripItem.Font = new Font(tum_toolStripItem.Font,FontStyle.Regular);
            }
            ToolStripItem secilen_menu = sender as ToolStripItem;
            Color click_rgb = new Color();
            click_rgb = Color.FromArgb(79, 168, 255);
            string[] SecilenMenu_split = secilen_menu.Name.Split('_');
            string SecilenMenu = SecilenMenu_split[0];
            //seçilen menü tasarımı
            secilen_menu.BackColor = click_rgb;
            secilen_menu.Font = new Font(secilen_menu.Font, FontStyle.Bold);

            frm_bellek_temizligi();
            switch (SecilenMenu)
            {
                case "Kasalar":
                    frm_kasalar = new FrmKasalar();
                    frm_kasalar.MdiParent = this;
                    frm_kasalar.Show();
                    break;
                case "CariKartlar":
                    frm_carikartlar = new FrmCariKartlar();
                    frm_carikartlar.MdiParent = this;
                    frm_carikartlar.Show();
                    break;
                case "Stoklar":
                    frm_stoklar = new FrmStoklar();
                    frm_stoklar.MdiParent = this;
                    frm_stoklar.Show();
                    break;
                case "Faturalar":
                    frm_faturalar = new FrmFaturalar();
                    frm_faturalar.MdiParent = this;
                    frm_faturalar.Show();
                    break;
                case "StokHareketleri":
                    frm_stokhareketleri = new FrmStokHareketleri();
                    frm_stokhareketleri.MdiParent = this;
                    frm_stokhareketleri.Show();
                    break;
                case "Siparisler":
                    frm_siparisler = new FrmSiparisler();
                    frm_siparisler.MdiParent = this;
                    frm_siparisler.Show();
                    break;
                case "Dekontlar":
                    frm_dekontlar = new FrmDekontlar();
                    frm_dekontlar.MdiParent = this;
                    frm_dekontlar.Show();
                    break;
                case "CekSenetler":
                    frm_ceksenetler = new FrmCekSenetler();
                    frm_ceksenetler.MdiParent = this;
                    frm_ceksenetler.Show();
                    break;
                case "Bankalar":
                    frm_bankalar = new FrmBankalar();
                    frm_bankalar.MdiParent = this;
                    frm_bankalar.Show();
                    break;
                case "AdresDefterim":
                    frm_adresdefterim = new FrmAdresDefterim();
                    frm_adresdefterim.MdiParent = this;
                    frm_adresdefterim.Show();
                    break;
                case "Gorevler":
                    frm_gorevler = new FrmGorevler();
                    frm_gorevler.MdiParent = this;
                    frm_gorevler.Show();
                    break;
            }
        }

        private void tum_ana_ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            //Mouse üzerindeykenki tasarınım
            ToolStripItem secilen_menu = sender as ToolStripItem;
            secilen_menu.BackColor = Color.White;
            */
        }

        private void tum_ana_ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            /*
            MessageBox.Show("mouse ayrıldı");
            //Mouse ayrılırkenki tasarım
            Color leave_rgb = new Color();
            leave_rgb = Color.FromArgb(155,222,255);
            ToolStripItem secilen_menu = sender as ToolStripItem;
            secilen_menu.BackColor = leave_rgb;
            */
        }
        //#4FC6FF
        private void Kasalar_ana_ToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            /*
            //Mouse üzerindeykenki tasarınım
            ToolStripItem secilen_menu = sender as ToolStripItem;
            Color move_rgb = new Color();
            move_rgb = Color.FromArgb(223, 244, 255);
            secilen_menu.BackColor = move_rgb;
           */
        }

        private void alışFaturasıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmSatis_AlisFaturasi formAlisFaturasi = new FrmSatis_AlisFaturasi("Alış", true, Bill_operation.TableRowCount());
            formAlisFaturasi.Show();
        }

        private void satışFaturasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSatis_AlisFaturasi formSatisFaturasi = new FrmSatis_AlisFaturasi("Satış", true, Bill_operation.TableRowCount());
            formSatisFaturasi.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kasalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKasaKarti frm_kasakarti = new FrmKasaKarti();
            frm_kasakarti.Show();
        }

        private void cariKartlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCariHesapKarti frm_carihesapkarti = new FrmCariHesapKarti(null,true);
            frm_carihesapkarti.Show();
        }

        private void bankalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBankaKarti frm_bankakarti = new FrmBankaKarti(null,true);
            frm_bankakarti.Show();
        }

        private void stokKartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStokKarti frm_Stokkarti = new FrmStokKarti(null,true);
            frm_Stokkarti.Show();
        }

        private void alışFaturasıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSatis_AlisFaturasi formAlisFaturasi = new FrmSatis_AlisFaturasi("Alış", true, Bill_operation.TableRowCount());
            formAlisFaturasi.Show();
        }

        private void satışFaturasıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSatis_AlisFaturasi formAlisFaturasi = new FrmSatis_AlisFaturasi("Satış", true, Bill_operation.TableRowCount());
            formAlisFaturasi.Show();
        }

        private void gidenHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            asdf gelen_havale = new asdf("Gönderilen");
            gelen_havale.Show();
        }

        private void gelenHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asdf gelen_havale = new asdf("Gelen");
            gelen_havale.Show();
        }

        private void HakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHakkimizda form_hakkimizda = new FrmHakkimizda();
            form_hakkimizda.Show();
        }
    }
  }
