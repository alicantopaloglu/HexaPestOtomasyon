using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class BiyosidalUrunler
    {
        [Key]
        public int ID { get; set; }

        public int servisID { get; set; }
        public virtual ServisRaporu ServisRaporu { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required]
        public string pestisit { get; set; }
        public virtual Pestisit Pestisit { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        [Required]
        public string birim { get; set; }
        [Required]
        public int miktar { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required]
        public string uygulamaSekli { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string diger { get; set; }
    }
}
