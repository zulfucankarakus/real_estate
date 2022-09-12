using System;
using System.Collections.Generic;
using System.Linq;
namespace Konut_Satış_Yönetimi
{
    class Emlakçı
    {
        public List<Musteri> Musteriler = new List<Musteri>();
        public List<Daire> Daireler = new List<Daire>();

        public void MenuDon()
        {
            Console.WriteLine();
            Console.WriteLine("Menüyü tekrar listelemek için “liste”, Çıkış yapmak için “çıkış” yazıp “enter”a basın.");

        }
        public void DaireEkle()
        {
            Console.WriteLine("1-Daire Ekle ---------------------------------");
            int no = araçgereç.SayiAl("Daire numarası: ");//daire numarası konrol
            DateTime Ytarihi = araçgereç.TarihAl("Dairenin yapılış tarihi: ");
            DAIRE_TIPI tip;
            while (true)
            {
                Console.Write("Daire türü(Satılık(S)/Kiralık(K)):");
                tip = araçgereç.TipBul(Console.ReadLine().ToUpper());
                if (tip == DAIRE_TIPI.Empty)
                {
                    Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                }
                else
                {
                    break;
                }
            }
            float fiyat = araçgereç.SayiAl("Dairenin Fiyatı: ");
            float NetÖlçüm = araçgereç.SayiAl("Dairenin net ölçüsü(m2): ");
            Console.WriteLine("Dairenin oda sayısı:... ");
            string DaireOdaSayısı = Console.ReadLine();
            Console.WriteLine("Daire Adresi:");
            string şehir = araçgereç.StringMi("İl: ");
            Daire a = new Daire(no, NetÖlçüm, DaireOdaSayısı, fiyat, tip, Ytarihi);
            a.Adresi.Il = araçgereç.IlkHarfBuyut(şehir);
            Daireler.Add(a);

        }
        public void MüşteriEkle()
        {
            Console.WriteLine("2-Müşteri Ekle -------------------------------------------------");
            int no = araçgereç.SayiAl("Müşteri numarası: ");
            string ad = araçgereç.StringMi("Müşteri adı: ");
            string soyad = araçgereç.StringMi("Müşteri soyadı: ");
            CINSIYET cins;
            while (true)
            {
                Console.Write("Müşteri cinsiyeti(K/E): ");
                cins = araçgereç.CinsiyetBul(Console.ReadLine().ToUpper());
                if (cins == CINSIYET.Empty)
                {
                    Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyin.");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Müşteri Adresi:");
            string şehir = araçgereç.StringMi("İl: ");
            string semt = araçgereç.StringMi("İlçe: ");
            string mevki = araçgereç.StringMi("Mahalle: ");
            float bütçe = araçgereç.SayiAl("Müşteri bütçesi: ");
            string ArananŞehir = araçgereç.StringMi("Daire aranan şehir:");
            Console.WriteLine("Bilgiler sisteme girilmiştir.");
            Musteri b = new Musteri(no, ad, soyad, cins, bütçe, ArananŞehir);
            b.Adresi.Il = araçgereç.IlkHarfBuyut(şehir);
            b.Adresi.Ilce = araçgereç.IlkHarfBuyut(semt);
            b.Adresi.Mahalle = araçgereç.IlkHarfBuyut(mevki);
            Musteriler.Add(b);

        }
        public void Listele(List<Daire> Liste)
        {
            if (Liste.Count > 0)
            {
                Console.WriteLine("  No".PadRight(8) + "Net Ölçü(m2)".PadRight(21) + "Oda Sayısı".PadRight(24) + "Fiyatı".PadRight(19) + "Türü".PadRight(16) + "Durum".PadRight(14) + "Adres".PadRight(15));
                Console.WriteLine("----".PadRight(7).PadLeft(8) + "------------".PadRight(20) + "------------".PadRight(23) + "----------".PadRight(20) + "-------".PadRight(15) + " --------".PadRight(14) + " --------".PadRight(15));

                foreach (var daire in Liste)
                {

                    Console.WriteLine(daire.DaireNo.ToString().PadRight(10).PadLeft(12) + daire.Metrekare.ToString().PadRight(20) + daire.OdaSayısı.PadRight(22) + daire.Fiyatı.ToString().PadRight(17) + daire.DaireTipi.ToString().PadRight(16) + daire.DaireDurum.ToString().PadRight(14) + daire.Adresi.Il.ToString().PadRight(15));
                }

            }
            else
            {
                Console.WriteLine("Listelenecek daire bulunamadı.");
            }


        }
        public void VeriListele(string secim)
        {
            if (secim == "4")

            {
                Console.WriteLine("4- Bütün Müşterileri Listele -------------------------------");
                Console.WriteLine();
                if (Musteriler.Count > 0)
                {
                    Console.WriteLine("  No".PadRight(11) + "Adı Soyadı".PadRight(21) + "Müşteri Bütçesi".PadRight(25) + "Aranan Şehir".PadRight(20) + " Durum".PadRight(15));
                    Console.WriteLine("----".PadRight(7).PadLeft(8) + "----------------".PadRight(23) + "-----------------".PadRight(25) + "-------------- ".PadRight(21) + "--------".PadRight(15));

                    foreach (var musteri in Musteriler)
                    {
                        Console.WriteLine(musteri.No.ToString().PadRight(7).PadLeft(9) + (musteri.Ad + " " + musteri.Soyad).PadRight(27) + musteri.Butcesi.ToString().PadRight(22) + musteri.ArananSehir.PadRight(20) + musteri.MusteriDurum.ToString());
                    }

                }
                else
                {
                    Console.WriteLine("Listelenecek Müşteri bulunamadı.");
                }
            }
            if (secim == "5")
            {

                Console.WriteLine("5- Bütün Daireleri Listele ----------------------------");
                Console.WriteLine();
                this.Listele(this.Daireler);

            }
            if (secim == "6")
            {
                Console.WriteLine("6-Kiralık Daireleri Listele ---------------------------");
                Console.WriteLine();
                DAIRE_DURUM dd = DAIRE_DURUM.Kiralanmadı;
                this.Listele(Daireler.Where(n => n.DaireDurum == dd).ToList());
            }
            if (secim == "7")
            {
                Console.WriteLine("7-Satılık Daireleri Listele ---------------------------");
                Console.WriteLine();
                DAIRE_DURUM dd = DAIRE_DURUM.Satılmadı;
                this.Listele(Daireler.Where(n => n.DaireDurum == dd).ToList());
            }
            if (secim == "8")
            {
                Console.WriteLine("8-Daire Bilgilerini Görüntüle ------------------------------------");
                int no;
                no = araçgereç.SayiAl("Daire no giriniz: ");
                this.Listele(Daireler.Where(a => a.DaireNo == no).ToList());

            }
            if (secim == "9")
            {

                Console.WriteLine("9-Fiyat Aralığına Göre Daireleri Listele -----------------------------------");
                DAIRE_TIPI tip;
                Console.Write("Daire türü(Satılık(S)/Kiralık(K)):");
                tip = araçgereç.TipBul(Console.ReadLine().ToUpper());
                Console.Write("Minimum fiyat: ");
                int MinFiyat = int.Parse(Console.ReadLine());
                Console.Write("Maksimum fiyat: ");
                int MaxFiyat = int.Parse(Console.ReadLine());
                this.Listele(Daireler.Where(a => a.DaireTipi == tip && a.Fiyatı < MaxFiyat && a.Fiyatı > MinFiyat).ToList());

            }
            if (secim == "10")
            {
                Console.WriteLine("10-Şu Tarihten Sonra Yapılan Daireleri Listele ------------------------------");
                DateTime DaireYapımYılı = araçgereç.TarihAl("Hangi tarihten sonra  yapılan daireleri listelemek istersiniz: ");
                this.Listele(Daireler.Where(a => a.YapılışTarihi > DaireYapımYılı).ToList());
            }
            if (secim == "11")
            {
                Console.WriteLine("11 - Adrese Göre Daireleri Listele--------------------------");
                Console.WriteLine("İl: ");
                string adres = araçgereç.IlkHarfBuyut(Console.ReadLine());
                this.Listele(Daireler.Where(a => a.Adresi.Il.ToString() == adres).ToList());
            }



        }

        public void ArabaKirala(int no,int no2)
        {






            Musteri musteri = this.Musteriler.Where<Musteri>((Func<Musteri, bool>)(a => a.No == no2 && a.MusteriDurum == Musteri_DURUM.Arıyor && a.Butcesi==Daireler.Where<Daire>((Func<Daire, bool>)(b=>b.Fiyatı==a.Butcesi)).FirstOrDefault<Musteri>();
            if (musteri==null)
            {

            }


            Daire Daire = this.Daireler.Where<Daire>((Func<Daire, bool>)(a => a.DaireNo == no && a.DaireDurum == DAIRE_DURUM.Kiralanmadı)).FirstOrDefault<Daire>();
            if (Daire == null)
            {
                return;
            }
            else
            {
                Daire.DaireDurum = DAIRE_DURUM.Kiralandı;
            }

           

        }
















    }
}

