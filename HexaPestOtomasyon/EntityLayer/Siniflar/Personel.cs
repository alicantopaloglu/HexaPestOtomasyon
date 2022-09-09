using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class Personel
    {


        [Key]
        public int ID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        [Required]
        public string personelTip { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        [Required]
        public string adi { get; set; }

        
        public bool aktif { get; set; }
        


    }
}
