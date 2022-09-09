using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class ServisUygulayicilar
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int personelID { get; set; }

        public int servisID { get; set; }
        public virtual ServisUygulayan servisUygulayan { get; set; }

    }
}
