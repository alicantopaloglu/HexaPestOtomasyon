using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public  class Context: DbContext
    {
        public DbSet<BiyosidalUrunler> BiyosidalUrunlers { get; set; }
        public DbSet<Ekipman> Ekipmans { get; set; }
        public DbSet<Hasere> Haseres { get; set; }
        public DbSet<HasereAlt> HasereAlts { get; set; }
        public DbSet<HasereKontrol> HasereKontrols { get; set; }
        public DbSet<Istasyon> Istasyons { get; set; }
        public DbSet<IstasyonAlt> IstasyonAlts { get; set; }
        public DbSet<KemirgenKontrol> KemirgenKontrols { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<OneriGorseli> OneriGorselis { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Pestisit> Pestisits { get; set; }
        public DbSet<Proje> Projes { get; set; }
        public DbSet<ServisRaporu> ServisRaporus { get; set; }
        public DbSet<ServisUygulayan> ServisUygulayans { get; set; }
        public DbSet<ServisUygulayicilar> ServisUygulayicilars { get; set; }
        public DbSet<ServisYapilan> ServisYapilans { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<Ilce> Ilces { get; set; }

    }
}
