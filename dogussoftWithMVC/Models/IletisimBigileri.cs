using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dogussoftWithMVC.Models
{
    public class IletisimBigileri
    {

        public int Id { get; set; }
        public String adi { get; set; }
        public String soyadi { get; set; }
        public String Email { get; set; }
        public String SirketBilgileri { get; set; }
        public String adres { get; set; }

        public String Tel { get; set; }
        public String mesaj_icerigi { get; set; }

        public bool cevapVerildi { get; set; }
        public DateTime TalepTarihi { get; set; }
        public DateTime CevapTarihi { get; set; }
        public bool goruldu { get; set; }
        public String cevapNotu { get; set; }



    }
}