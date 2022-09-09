using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class KemirgenKontrol
    {
        [Key]
        public int ID { get; set; }

        public int servisID { get; set; }
        public virtual ServisRaporu ServisRaporu { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(200)]
        [Required]
        public string anaBolge { get; set; }
        public virtual Istasyon Istasyon { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Required]
        public string durumu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(70)]
        [Required]
        public string kapanNo { get; set; }
    }
}
