using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class ServisYapilan
    {
        [Key]
        public int ID { get; set; }

        public int servisID { get; set; }
        public virtual ServisRaporu ServisRaporu { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(75)]
        [Required]
        public string servisBilgileri { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string diger { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(70)]
        [Required]
        public string hedef { get; set; }
        [Required]
        public DateTime baslangic { get; set; }
        [Required]
        public DateTime bitis { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        [Required]
        public string aktivite { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        [Required]
        public string uygunsuzluk { get; set; }
        public ICollection<OneriGorseli> oneriGorselis { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        public string oneri { get; set; }
    }
}
