using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required]
        public string isim { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required]
        public string mail { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(16)]
        [Required]
        public string sifre { get; set; }
    }
}
