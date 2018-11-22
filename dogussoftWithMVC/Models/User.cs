using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dogussoftWithMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public String  kullanici_adi { get; set; }
        public String sifre { get; set; }
        public bool durum { get; set; }
        public int seviye { get; set; }
    }
}