using System;

namespace Konut_Satış_Yönetimi
{
    class araçgereç
    {
        public static string IlkHarfBuyut(string veri)
        {
            if (veri.Length != 0)
            {
                veri = veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();

            }
            return veri;
        }
        public static int SayiAl(string mesaj)
        {
            int a;
            while (true)
            {
                Console.Write(mesaj);
                if (!int.TryParse(Console.ReadLine(), out a) || a < 0)
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                else
                    break;
            }
            return a;
        }
       
        public static DateTime TarihAl(string mesaj)
        {
            DateTime a;
            while (true)
            {
                Console.Write(mesaj);
                if (!DateTime.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                else
                    break;
            }
            return a;
        }
        public static CINSIYET CinsiyetBul(string veri)
        {
            CINSIYET cinsiyet = CINSIYET.Empty;
            if (veri.ToUpper() == "K")
            {
                cinsiyet = CINSIYET.Kadın;
            }
            else if (veri.ToUpper() == "E")
            {
                cinsiyet = CINSIYET.Erkek;
            }
            return cinsiyet;
        }

        public static string SecimAl()
        {
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            string seçim = Console.ReadLine().ToLower();
            Console.WriteLine();
            return seçim;
        }
        public static string StringMi(string mesaj)
        {
           
            string metin = "";
            bool değer = true;
            while (değer)
            {
                int uzunluk = 1;
                Console.Write(mesaj);
                metin = araçgereç.IlkHarfBuyut(Console.ReadLine());
                if (metin.Length != 0)
                {
                    string str2 = "1234567890!^+-*/?*.,#%&:;()={}[]-_\"<>'\\~@|";
                    foreach (char A in metin)
                    {
                        if (str2.Contains(A))
                        {
                            Console.WriteLine("Hatalı işlem tekrar girin.");
                            break;
                        }
                        if (metin.Length == uzunluk)
                        {
                            değer = false;
                            break;
                        }
                        ++uzunluk;
                    }
                }
                else
                {
                    break;
                }
            }
            return metin;
        }
        public static DAIRE_TIPI TipBul(string veri)
        {
            DAIRE_TIPI tip = DAIRE_TIPI.Empty;
            if (veri.ToUpper() == "K")
            {
                tip = DAIRE_TIPI.Kiralik;
            }
            else if (veri.ToUpper() == "S")
            {
                tip = DAIRE_TIPI.Satılık;
            }
            return tip;
        }
        
    }


}


