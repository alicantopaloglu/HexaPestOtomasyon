using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Siniflar
{
    public class OneriGorseli
    {

        [Key]
        public int ID { get; set; }

        public int servisYapilanID { get; set; }
        public virtual ServisYapilan ServisYapilan { get; set; }

        public byte[] gorsel { get; set; }
    }
}
