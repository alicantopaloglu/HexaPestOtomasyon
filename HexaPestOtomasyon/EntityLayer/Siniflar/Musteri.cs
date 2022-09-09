using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Musteri
    {
        //Yetkili ve kullanıcı bilgileri

        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required]
        public string adi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        [Required]
        public string mail { get; set; }
        [Required]
        public int sifre { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        [Required]
        public string sabitTel { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        [Required]
        public string mobilTel { get; set; }
        public bool aktif { get; set; }



        //Hizmet Bölge bilgileri
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        [Required]
        public string firmaAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        [Required]
        public string adres { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        [Required]
        public string sehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        [Required]
        public string ilce { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string sabitTel2 { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(11)]
        public string mobilTel2 { get; set; }
        public bool uyelikDurum { get; set; }
        public int projeSayisi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string uyelikTip { get; set; }

        public ICollection<Proje> Projes { get; set; }
        public ICollection<ServisRaporu> servisRaporus { get; set; }
    }
}
