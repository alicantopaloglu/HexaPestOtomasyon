using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class ServisRaporu
    {
        [Key]
        public int ID { get; set; }

        public int musteriID { get; set; }
        public virtual Musteri Musteri { get; set; }


        public int personelID { get; set; }

        public int projeID { get; set; }
        public virtual Proje proje { get; set; }

        [Required]
        public DateTime tarih { get; set; }

        public ICollection<ServisUygulayan> servisUygulayans { get; set; }
        public ICollection<BiyosidalUrunler> biyosidalUrunlers { get; set; }
        public ICollection<ServisYapilan> servisYapilans { get; set; }
        public ICollection<KemirgenKontrol> kemirgenKontrols { get; set; }
        public ICollection<HasereKontrol> hasereKontrols { get; set; }
    }
}
