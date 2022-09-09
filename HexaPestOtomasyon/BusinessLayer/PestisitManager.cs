using DataAccessLayer;
using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PestisitManager
    {
        Repository<Pestisit> pestisitRepo = new Repository<Pestisit>();
        public List<Pestisit> GetAll()
        {
            return pestisitRepo.List();
        }
        public bool pestisitEkle(Pestisit p)
        {
            return pestisitRepo.Insert(p);
        }
        public bool silPestisit(int p)
        {
            Pestisit per = pestisitRepo.Find(x => x.ID == p);
            per.aktif = false;
            pestisitRepo.Update(per);
            return true;
        }
        public int pestisitSayi(Pestisit p)
        {
            int sayi = pestisitRepo.Count(p);
            return sayi;
        }

    }
}
