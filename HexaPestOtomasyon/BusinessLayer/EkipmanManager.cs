using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer.Siniflar;

namespace BusinessLayer
{
    public class EkipmanManager
    {
        Repository<Ekipman> ekipmanRepo = new Repository<Ekipman>();
        public List<Ekipman> GetAll()
        {
            return ekipmanRepo.List();
        }
        public bool ekipmanEkle(Ekipman p)
        {
            return ekipmanRepo.Insert(p);
        }
        public bool silEkipman(int p)
        {
            Ekipman per = ekipmanRepo.Find(x => x.ID == p);
            per.aktif = false;
            ekipmanRepo.Update(per);
            return true;
        }
        public bool ekipmanSil(int p)
        {
            if (p != 0)
            {
                Ekipman ekip = ekipmanRepo.Find(x => x.ID == p);
                return ekipmanRepo.Delete(ekip);


            }
            else
            {
                return false;
            }
        }
        public int ekipmanSayi(Ekipman p)
        {
            int sayi = ekipmanRepo.Count(p);
            return sayi;
        }
    }
}
