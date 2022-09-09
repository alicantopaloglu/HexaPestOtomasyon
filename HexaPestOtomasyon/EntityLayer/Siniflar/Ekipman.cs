using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Ekipman
    {
        //Envanter 

        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(75)]
        [Required]
        public string ekipmanAdi { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        [Required]
        public string ekipmanTuru { get; set; } //hedef zararlı türü
        public bool aktif { get; set; }


        

    }
}
