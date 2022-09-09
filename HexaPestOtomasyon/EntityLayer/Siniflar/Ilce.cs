using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Ilce
    {
        [Key]
        public int ID { get; set; }
        public int sehirID { get; set; }
        public virtual Sehir Sehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ilceAdi { get; set; }

    }
}
