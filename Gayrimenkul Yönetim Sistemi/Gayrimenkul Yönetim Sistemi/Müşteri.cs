namespace Konut_Satış_Yönetimi
{
    class Musteri
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public int No;
        public float Butcesi { get; set; }
        public string ArananSehir { get; set; }
        public Musteri_DURUM MusteriDurum { get; set; }

        public Adres Adresi;
        public Musteri(int no, string ad, string soyad, CINSIYET cinsiyet, float butce, string arananSehir)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Cinsiyet = cinsiyet;
            this.Adresi = new Adres();
            this.Butcesi = butce;
            this.ArananSehir = arananSehir;
            this.No = no;
        }


    }
}
public enum CINSIYET
{
    Empty,
    Kadın,
    Erkek
}
public enum Musteri_DURUM
{
    Empty,
    Arıyor,
    Aramıyor
}

