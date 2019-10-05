using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void EkranHazırla()
        {
            mskdtxtBaşlangıç.Focus();
            lstViewTekSayılar.Clear();
            lstViewÇiftSayılar.Clear();
            lstViewAsalSayılar.Clear();
            lstViewArmstrongSayıları.Clear();
        }

        public Boolean ArmstrongSayısıKontrol(int sayi)
        {
            int r, a, toplam = 0;
            while (sayi > 1)
            {
                a = sayi;
                while (a > 0)
                {
                    r = a % 10;
                    a = a / 10;
                    toplam += r * r * r;
                }
            }
            if (toplam == sayi)
                return true;
            else
                return false;
        }
        
        string ListeleTekSayılar(int sayi1, int sayi2)
        {
            LogYazTekSayılar("Tek Sayılar:");
            string tekSayılar = "";
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                    continue;
                else
                    tekSayılar += " " + i;
            }
            return tekSayılar;
        }

        string ListeleÇiftSayılar(int sayi1, int sayi2)
        {
            LogYazÇiftSayılar("Çift Sayılar:");
            string çiftSayılar = "";
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                    çiftSayılar += " " + i;
                else
                    continue;
            }
            return çiftSayılar;
        }
        
        string ListeleAsalSayılar(int sayi1, int sayi2)
        {
            LogYazAsalSayılar("Asal Sayılar:");
            string asalSayılar = "";
            for (int i = sayi1; i <= sayi2; i++)
            {
                int kontrol = 0;
                if (i > 2)
                {
                    for (int a = 2; a < i; a++)
                    {
                        if (i % a == 0)
                            kontrol = 1;
                        break;
                    }
                    if (kontrol == 1)
                        continue;
                    else
                        asalSayılar += " " + i;
                }
                else
                    asalSayılar += " " + i;
            }
            return asalSayılar;
        }
        
         string ListeleArmstrongSayıları(int sayi1, int sayi2)
        {
            LogYazArmstrongSayıları("Armstrong Sayıları:");
            string armstrongSayılar = "";
            for(int i = sayi1; i <= sayi2; i++)
            {
                if (ArmstrongSayısıKontrol(i))
                {
                    armstrongSayılar += " "+ i;
                }
                else
                    continue;
            }
            return armstrongSayılar;
        }

        public int ToplaTekSayılar(int sayi1, int sayi2)
        {
            LogYazTekSayılar("Tek Sayıların Toplamı:");
            int ToplamTekSayılar = 0;
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                    continue;
                else
                    ToplamTekSayılar += i;
            }
            return ToplamTekSayılar;
        }
        
        public int ToplaÇiftSayılar(int sayi1, int sayi2)
        {
            LogYazÇiftSayılar("Çift Sayıların Toplamı:");
            int ToplamÇiftSayılar = 0;
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                    ToplamÇiftSayılar += i;
                else
                    continue;
            }
            return ToplamÇiftSayılar;
        }

        public int ToplaAsalSayılar(int sayi1,int sayi2)
        {
            LogYazAsalSayılar("Asal Sayıların Toplamı:");
            int ToplamAsalSayılar = 0;
            for (int i = sayi1; i <= sayi2; i++)
            {
                int kontrol = 0;
                if (i > 2)
                {
                    for (int a = 2; a < i; a++)
                    {
                        if (i % a == 0)
                            kontrol = 1;
                        break;
                    }
                    if (kontrol == 1)
                        continue;
                    else
                        ToplamAsalSayılar += i;
                }
                else
                    ToplamAsalSayılar += i;
            }
            return ToplamAsalSayılar;
        }

        public int ToplaArmstrongSayıları(int sayi1,int sayi2)
        {
            LogYazArmstrongSayıları("Armstrong Sayıların Toplamı:");
            int ToplamArmstrongSayılar = 0;
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (ArmstrongSayısıKontrol(i))
                    ToplamArmstrongSayılar += i;
                else
                    continue;
            }
            return ToplamArmstrongSayılar;
        }

        public int ÇarpTekSayılar(int sayi1, int sayi2)
        {
            LogYazTekSayılar("Tek Sayıların Çarpımı:");
            int ÇarpımTekSayılar = 1;
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                    continue;
                else
                    ÇarpımTekSayılar *= i;
            }
            return ÇarpımTekSayılar;
        }

        public int ÇarpÇiftSayılar(int sayi1, int sayi2)
        {
            LogYazÇiftSayılar("Çift Sayıların Çarpımı:");
            int ÇarpımÇiftSayılar = 1 ;
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i % 2 == 0)
                    ÇarpımÇiftSayılar *= i;
                else
                    continue;
            }
            return ÇarpımÇiftSayılar;
        }

        public int ÇarpAsalSayılar(int sayi1,int sayi2)
        {
            LogYazAsalSayılar("Asal Sayıların Çarpımı:");
            int ÇarpımAsalSayılar = 1;
            for (int i = sayi1; i <= sayi2; i++)
            {
                int kontrol = 0;
                if (i > 2)
                {
                    for (int a = 2; a < i; a++)
                    {
                        if (i % a == 0)
                            kontrol = 1;
                        break;
                    }
                    if (kontrol == 1)
                        continue;
                    else
                        ÇarpımAsalSayılar *= i;
                }
                else
                    ÇarpımAsalSayılar *= i;
            }
            return ÇarpımAsalSayılar;
        }

        public int ÇarpArmstrongSayılar(int sayi1, int sayi2)
        {
            LogYazArmstrongSayıları("Armstrong Sayıların Çarpımı:");
            int ÇarpımArmstrongSayılar = 1;
            for (int i = sayi1; i <= sayi2; i++)
            {
                if (ArmstrongSayısıKontrol(i))
                    ÇarpımArmstrongSayılar *= i;
                else
                    continue;
            }
            return ÇarpımArmstrongSayılar;
        }

        void LogYazTekSayılar(string mesaj)
        {
            lstViewTekSayılar.Items.Add(mesaj);
        }
        
        void LogYazÇiftSayılar(string mesaj)
        {
            lstViewÇiftSayılar.Items.Add(mesaj);
        }
        
        void LogYazAsalSayılar(string mesaj)
        {
            lstViewAsalSayılar.Items.Add(mesaj);
        }

        void LogYazArmstrongSayıları(string mesaj)
        {
            lstViewArmstrongSayıları.Items.Add(mesaj);
        }

        private void GörüntüleTekSayılar(int sayi1,int sayi2)
        {
            LogYazTekSayılar(Convert.ToString(ListeleTekSayılar(sayi1, sayi2)));
            LogYazTekSayılar(Convert.ToString(ToplaTekSayılar(sayi1, sayi2)));
            LogYazTekSayılar(Convert.ToString(ÇarpTekSayılar(sayi1, sayi2)));
        }

        private void GörüntüleÇiftSayılar(int sayi1, int sayi2)
        {
            LogYazÇiftSayılar(Convert.ToString(ListeleÇiftSayılar(sayi1, sayi2)));
            LogYazÇiftSayılar(Convert.ToString(ToplaÇiftSayılar(sayi1, sayi2)));
            LogYazÇiftSayılar(Convert.ToString(ÇarpÇiftSayılar(sayi1, sayi2)));
        }

        private void GörüntüleAsalSayılar(int sayi1, int sayi2)
        {
            LogYazAsalSayılar(Convert.ToString(ListeleAsalSayılar(sayi1, sayi2)));
            LogYazAsalSayılar(Convert.ToString(ToplaAsalSayılar(sayi1, sayi2)));
            LogYazAsalSayılar(Convert.ToString(ÇarpAsalSayılar(sayi1, sayi2)));
        }

        private void GörüntüleArmstrongSayıları(int sayi1, int sayi2)
        {
            LogYazArmstrongSayıları(Convert.ToString(ListeleArmstrongSayıları(sayi1, sayi2)));
            LogYazArmstrongSayıları(Convert.ToString(ToplaArmstrongSayıları(sayi1, sayi2)));
            LogYazArmstrongSayıları(Convert.ToString(ÇarpArmstrongSayılar(sayi1, sayi2)));
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int başlangıç = Convert.ToInt32(mskdtxtBaşlangıç.Text);
            int bitiş = Convert.ToInt32(mskdtxtBitiş.Text);

            if (başlangıç > bitiş)
            {
                MessageBox.Show("Lütfen bitiş sayısını başlangıç sayısından büyük giriniz!");
            }

            else if(başlangıç == bitiş)
            {
                MessageBox.Show("Lütfen birbirinden farklı sayılar giriniz!");
            }
            
            else if (tbİşlemler.SelectedIndex == 0)
            {
                EkranHazırla();
                GörüntüleTekSayılar(başlangıç, bitiş);
                
            }
            else if(tbİşlemler.SelectedIndex == 1)
            {
                EkranHazırla();
                GörüntüleÇiftSayılar(başlangıç, bitiş);
                
            }
            else if (tbİşlemler.SelectedIndex == 2)
            {
                EkranHazırla();
                GörüntüleAsalSayılar(başlangıç, bitiş);
                
            }
            else if (tbİşlemler.SelectedIndex == 3)
            {
                EkranHazırla();
                GörüntüleArmstrongSayıları(başlangıç, bitiş);
                
            }
            
        }

       

        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranHazırla();
            ntfyBildirim.ShowBalloonTip(5000);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (tbİşlemler.SelectedIndex == 0)
            {
                tbİşlemler.SelectedIndex = 0;

            }
            else
            {
                tbİşlemler.SelectedIndex -= 1;
            }
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            if (tbİşlemler.SelectedIndex == 3)
            {
                tbİşlemler.SelectedIndex = 3;

            }
            else
            {
                tbİşlemler.SelectedIndex += 1;
            }
        }
    }
}
