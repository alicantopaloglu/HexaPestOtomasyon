using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Proje
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        [Required]
        public string projeAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(70)]
        [Required]
        public string musteriAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(70)]
        [Required]
        public string yetkiliAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        [Required]
        public string adres { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        [Required]
        public string sehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required]
        public string ilce { get; set; }
        public byte[] projePlani { get; set; }
        public bool aktif { get; set; }


        [ForeignKey("musteriID")]
        public virtual Musteri Musteri { get; set; }
        public int? musteriID { get; set; }

        public ICollection<Istasyon> Istasyons { get; set; }

        public ICollection<Hasere> Haseres { get; set; }
    }
}
