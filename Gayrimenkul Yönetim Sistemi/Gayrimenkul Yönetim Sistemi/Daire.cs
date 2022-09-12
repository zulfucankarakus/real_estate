using System;
using System.Collections.Generic;
using System.Text;

namespace Konut_Satış_Yönetimi
{
    class Daire
    {
        public int  DaireNo { get; set; }
        public float Metrekare { get; set; }
        public string OdaSayısı { get; set; }
        public float Fiyatı { get; set; }
        public DAIRE_TIPI DaireTipi { get; set; }
        public DAIRE_DURUM DaireDurum { get; set; }
        public DateTime YapılışTarihi { get; set; }
        public Adres Adresi;
        public Daire(int no, float Mk,string Od,float Fy,DAIRE_TIPI Dt,DateTime Yt)
        {
         this.DaireNo = no;
         this.Metrekare = Mk;
         this.OdaSayısı = Od;
         this.Fiyatı = Fy;
         this.DaireTipi = Dt;
         this.YapılışTarihi = Yt;
         this.Adresi = new Adres();
        }
    }

    public enum DAIRE_TIPI
    {
        Empty,
        Kiralik,
        Satılık,
    }

    public enum DAIRE_DURUM
    {
        Empty,
        Satıldı,
        Kiralandı,
        Satılmadı,
        Kiralanmadı,
    }


}
