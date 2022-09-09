using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class HasereAlt
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string altBolge { get; set; }
        [Required]
        public string ekipman { get; set; }
        [Required]
        public int ekipmanAdet { get; set; }
        public bool aktif { get; set; }

        public int hasereID { get; set; }
        public virtual Hasere Hasere { get; set; }
    }
}
