using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EntityLayer.Siniflar
{
    public class SehirCascading
    {
        public IEnumerable<SelectListItem> sehirler { get; set; }
        public IEnumerable<SelectListItem> ilceler { get; set; }
    }
}
