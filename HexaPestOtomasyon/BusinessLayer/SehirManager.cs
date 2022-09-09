using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

using EntityLayer.Siniflar;
using DataAccessLayer;

namespace BusinessLayer
{

    public class SehirManager
    {
        SehirCascading sc = new SehirCascading();
        Repository<Sehir> sehirRepo = new Repository<Sehir>();
        Context c = new Context();

        public SelectList sehirleriGetir()
        {
            
            return (SelectList)(sc.sehirler = new SelectList(c.Sehirs, "ID", "sehirAdi"));
            
        }
        public SelectList ilceleriGetir()
        {
            return (SelectList)(sc.ilceler = new SelectList(c.Ilces, "ID", "ilceAdi"));
        }
    }
}
