using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class ServisUygulayan
    {
        [Key]
        public int ID { get; set; }

        public int servisID { get; set; }
        public virtual ServisRaporu ServisRaporu { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        [Required]
        public string firma { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        [Required]
        public string adres { get; set; }
        [Required]
        public int personelID { get; set; }
        [Required]
        public int ekipSorumlusu { get; set; }
        public ICollection<ServisUygulayicilar> servisUygulayicilars { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(25)]
        [Required]
        public string telefon { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required]
        public string mTarihSayi { get; set; }
        public ICollection<BiyosidalUrunler> biyosidalUrunlers { get; set; }

    }
}
