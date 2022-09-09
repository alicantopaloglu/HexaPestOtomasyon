using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Pestisit
    {
        //Envanter 

        [Key]
        public int ID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        [Required]
        public string ticariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(70)]
        [Required]
        public string aktifMadde { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(70)]
        [Required]
        public string antidot { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Required]
        public DateTime ruhsatTarihi { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        [Required]
        public string ruhsatSuresi { get; set; }

        [Required]
        public int sayi { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        [Required]
        public string birim { get; set; }
        [Required]
        public int miktar { get; set; }

        public bool aktif { get; set; }

        public ICollection<BiyosidalUrunler> biyosidalUrunlers { get; set; }

    }
}
