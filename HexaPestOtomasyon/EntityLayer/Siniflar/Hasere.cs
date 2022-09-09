using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Hasere
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        [Required]
        public string anaBolge { get; set; }
        public ICollection<HasereAlt> hasereAlts { get; set; }
        public bool aktif { get; set; }

        public int projeID { get; set; }
        public virtual Proje Proje { get; set; }

        public ICollection<HasereKontrol> hasereKontrols { get; set; }
    }
}
