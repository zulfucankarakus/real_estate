using System;
using System.Collections.Generic;

namespace Konut_Satış_Yönetimi
{
    class Program
    {
        static Emlakçı emlakçı = new Emlakçı();



        static void Main(string[] args)
        {
            SahteVeriEKleMusteri();
            SahteVeriEKleDaire();
            AnaEkran();
        }
        static void SahteVeriEKleMusteri()
        {
            emlakçı.Musteriler = new List<Musteri>();
            Musteri musteri1 = new Musteri(55, "ahmet", "topdaş", CINSIYET.Erkek, 10000, "istanbul");
            musteri1.MusteriDurum = Musteri_DURUM.Arıyor;
            emlakçı.Musteriler.Add(musteri1);
            musteri1.Adresi.Il = "konya";
            musteri1.Adresi.Ilce = "karatay";
            musteri1.Adresi.Mahalle = "sedirler";

           
            Musteri musteri2 = new Musteri(56, "Naz", "Şimşek", CINSIYET.Erkek, 1000000, "istanbul");
            musteri2.MusteriDurum = Musteri_DURUM.Arıyor;
            emlakçı.Musteriler.Add(musteri2);
            musteri2.Adresi.Il = "Ankara";
            musteri2.Adresi.Ilce = "Çankaya";
            musteri2.Adresi.Mahalle = "Zambak";

            
            Musteri musteri3 = new Musteri(88, "Çiçek", "Yüzbaş", CINSIYET.Erkek, 100000, "istanbul");
            musteri3.MusteriDurum = Musteri_DURUM.Aramıyor;
            emlakçı.Musteriler.Add(musteri3);
            musteri3.Adresi.Il = "İzmir";
            musteri3.Adresi.Ilce = "Alsancak";
            musteri3.Adresi.Mahalle = "Lale";

            
            Musteri musteri4 = new Musteri(77, "Yağmur", "Aktürk", CINSIYET.Erkek, 40000, "istanbul");
            musteri4.MusteriDurum = Musteri_DURUM.Aramıyor;
            emlakçı.Musteriler.Add(musteri4);
            musteri4.Adresi.Il = "İstanbul";
            musteri4.Adresi.Ilce = "Kadıköy";
            musteri4.Adresi.Mahalle = "Papatya";

            Musteri musteri5 = new Musteri(77, "Yağmur", "Aktürk", CINSIYET.Erkek, 500000, "istanbul");
            musteri5.MusteriDurum = Musteri_DURUM.Aramıyor;
            emlakçı.Musteriler.Add(musteri5);
            musteri5.Adresi.Il = "İstanbul";
            musteri5.Adresi.Ilce = "Kartal";
            musteri5.Adresi.Mahalle = "Akıllılar";

            Musteri musteri6 = new Musteri(77, "Yağmur", "Aktürk", CINSIYET.Erkek, 600000, "istanbul");
            musteri6.MusteriDurum = Musteri_DURUM.Arıyor;
            emlakçı.Musteriler.Add(musteri6);
            musteri6.Adresi.Il = "İstanbul";
            musteri6.Adresi.Ilce = "Kartal";
            musteri6.Adresi.Mahalle = "Kozalak";

        }
        static void SahteVeriEKleDaire()
        {
            emlakçı.Daireler = new List<Daire>();
            Daire Daire1 = new Daire(55, 250, "3+1",1200, DAIRE_TIPI.Kiralik, DateTime.Parse("20.03.2005"));
            Daire1.Adresi.Il = "İstanbul";
            Daire1.DaireDurum = DAIRE_DURUM.Kiralanmadı;
            emlakçı.Daireler.Add(Daire1);

            Daire Daire2 = new Daire(54, 150, "2+1", 1600, DAIRE_TIPI.Kiralik, DateTime.Parse("15.01.2004"));
            Daire2.Adresi.Il = "Ankara";
            Daire2.DaireDurum = DAIRE_DURUM.Kiralanmadı;
            emlakçı.Daireler.Add(Daire2);

            Daire Daire3 = new Daire(12, 125, "8+1", 800000, DAIRE_TIPI.Satılık, DateTime.Parse("14.07.1999"));
            Daire3.Adresi.Il = "Ankara";
            Daire3.DaireDurum = DAIRE_DURUM.Satılmadı;
            emlakçı.Daireler.Add(Daire3);

            Daire Daire4 = new Daire(23, 100, "5+1", 400000, DAIRE_TIPI.Satılık, DateTime.Parse("04.08.2018"));
            Daire4.Adresi.Il = "İzmir";
            Daire4.DaireDurum = DAIRE_DURUM.Satılmadı;
            emlakçı.Daireler.Add(Daire4);

             Daire Daire5 = new Daire(18, 100, "2+1", 2000, DAIRE_TIPI.Kiralik, DateTime.Parse("04.08.2014"));
            Daire5.Adresi.Il = "İzmir";
            Daire5.DaireDurum = DAIRE_DURUM.Kiralanmadı;
            emlakçı.Daireler.Add(Daire5);

             Daire Daire6 = new Daire(15, 100, "5+2", 400000, DAIRE_TIPI.Satılık, DateTime.Parse("04.08.2017"));
            Daire6.Adresi.Il = "Konya";
            Daire6.DaireDurum = DAIRE_DURUM.Satıldı;
            emlakçı.Daireler.Add(Daire6);

            Daire Daire7 = new Daire(99, 100, "1+0", 1000, DAIRE_TIPI.Kiralik, DateTime.Parse("04.08.2021"));
            Daire7.Adresi.Il = "Elazığ";
            Daire7.DaireDurum = DAIRE_DURUM.Kiralandı;
            emlakçı.Daireler.Add(Daire7);

             Daire Daire8 = new Daire(77, 100, "2+2", 100000, DAIRE_TIPI.Satılık, DateTime.Parse("04.08.1995"));
            Daire8.Adresi.Il = "Elazığ";
            Daire8.DaireDurum = DAIRE_DURUM.Satılmadı;
            emlakçı.Daireler.Add(Daire8);

             Daire Daire9 = new Daire(01, 100, "1+1", 300000, DAIRE_TIPI.Satılık, DateTime.Parse("04.08.2000"));
            Daire9.Adresi.Il = "Aydın";
            Daire9.DaireDurum = DAIRE_DURUM.Satıldı;
            emlakçı.Daireler.Add(Daire9);

        }

        static void Menu()
        {
            Console.WriteLine("------Gayrimenkul Yönetim Sistemi---- -");
            Console.WriteLine("1 - Daire Ekle");
            Console.WriteLine("2 - Müşteri Ekle");
            Console.WriteLine("3 - Müşteri Sil(Eğer müşteri daire kiralamış veya satın almış ise silinmemeli)");
            Console.WriteLine("4 - Bütün Müşterileri Listele");
            Console.WriteLine("5 - Bütün Daireleri Listele");
            Console.WriteLine("6 - Kiralık Daireleri Listele");
            Console.WriteLine("7 - Satılık Daireleri Listele");
            Console.WriteLine("8 - Dairenin Bilgilerini Görüntüle");
            Console.WriteLine("9 - Fiyat Aralığına Göre Daireleri Listele");
            Console.WriteLine("10 - Şu Tarihten Sonra Yapılan Daireleri Listele");
            Console.WriteLine("11 - Adrese Göre Daireleri Listele");
            Console.WriteLine("12 - En Pahalı ve Satılık 5 Daireyi Listele");
            Console.WriteLine("13 - En Pahalı ve Kiralık 5 Daireyi Listele");
            Console.WriteLine("14 - En Ucuz ve Satılık 3 Daireyi Listele");
            Console.WriteLine("15 - En Ucuz ve Kiralık 3 Daireyi Listele");
            Console.WriteLine("16 - Kiralanan Son Daireyi Gör");
            Console.WriteLine("17 - Satılan Son Daireyi Gör");
            Console.WriteLine("18 - Daire Güncelle");
            Console.WriteLine("19 - Müşteri Güncelle)");
            Console.WriteLine("20 - Daire Sil(Eğer daire kiralık veya satılık ise silinmemeli)");
            Console.WriteLine();
            Console.WriteLine("Çıkış yapmak için “çıkış” yazıp “enter”a basın.   ");

        }
        static void AnaEkran()
        {
            while (true)
            {
                string secim1 = araçgereç.SecimAl();
                switch (secim1)
                {
                    case "1":
                        //1-Daire Ekle
                        break;
                    case "2":
                        //2-Müşteri Ekle
                        break;
                    case "3":
                        //3-Müşteri Sil(Eğer müşteri daire kiralamış veya satın almış ise silinmemeli)
                        break;
                    case "4":
                        emlakçı.VeriListele("4");
                        break;
                    case "5":
                        emlakçı.VeriListele("5");
                        break;
                    case "6":
                        emlakçı.VeriListele("6");
                        break;
                    case "7":
                        emlakçı.VeriListele("7");
                        break;
                    case "8":
                        emlakçı.VeriListele("8");
                        break;
                    case "9":
                        emlakçı.VeriListele("9");
                        break;
                    case "10":
                        emlakçı.VeriListele("10");
                        break;
                    case "11":
                        emlakçı.VeriListele("11");
                        break;
                    case "12":
                        emlakçı.VeriListele("12");
                        break;
                    case "13":
                        emlakçı.VeriListele("13");
                        break;
                    case "14":
                        emlakçı.VeriListele("14");
                        break;
                    case "15":
                        emlakçı.VeriListele("15");
                        break;
                    case "16":
                        emlakçı.VeriListele("16");
                        break;
                    case "17":
                        emlakçı.VeriListele("17");
                        break;
                    case "18":
                        //18-Daire Güncelle
                        break;
                    case "19":
                        //19-Müşteri Güncelle
                        break;
                    case "20":
                        //20-Daire Sil(Eğer daire kiralık veya satılık ise silinmemeli)
                        break;


                    case "cikis":
                    case "çıkış":
                        Environment.Exit(0);
                        break;
                    case "liste":
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Hatalı işlem gerçekleştirildi. Tekrar deneyin.");
                        break;
                }
                emlakçı.MenuDon();

            }

        }
        static void DaireEkle()
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

            Daire a = new Daire(no, NetÖlçüm, DaireOdaSayısı, fiyat, tip, Ytarihi);
            emlakçı.Daireler.Add(a);
        }

    }
}
