using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Siniflar;
using DataAccessLayer;

namespace BusinessLayer
{
    public class MusteriManager
    {
        Repository<Musteri> musteriRepo = new Repository<Musteri>();

        public List<Musteri> GetAll()
        {
            return musteriRepo.List();
        }
        public bool musteriEkle(Musteri m)
        {
            return musteriRepo.Insert(m);
        }
        public bool musteriSil(int id)
        {
            Musteri m = musteriRepo.Find(x => x.ID == id);
            m.aktif = false;
            musteriRepo.Update(m);
            return true;

        }
        
    }
}
