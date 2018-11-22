
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace dogussoftWithMVC.Models
{
    public class DBaseContext : DbContext
    {
        public DBaseContext()
            :base("DogusDB") // oluşacak veritabanına verilen isim bu olacak
        {
           
        }

        public DbSet<demoBilgiler> demoBilgilers { get; set; }

        public DbSet<IletisimBigileri> IletisimBilgileris { get; set; }

        public DbSet<User> Users { get; set; }
    }
    
}