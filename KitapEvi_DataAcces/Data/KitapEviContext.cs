using KitapEvi_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi_DataAcces.Data
{
    public class KitapEviContext : DbContext
    {
        public KitapEviContext(DbContextOptions<KitapEviContext> options): base (options)
        {

        }
        public DbSet<Tur> Turler { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Yayinevi> YayinEvleri { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        
        public DbSet<KitapİYazarlar> KitapYazarlar { get; set; }   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //iki özelliğide birincil anahtar yapmak için kullandık.

            //fluent api ile configirasyon işlemi yapmam gerek. Composite Key oluşturmak için

            modelBuilder.Entity<KitapİYazarlar>().HasKey(x => new { x.YazarID, x.KitapID });
        }

        public DbSet<KitapDetay> KitapDetaylar { get; set; }



    }
}
