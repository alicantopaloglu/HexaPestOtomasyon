using DataAccessLayer;
using EntityLayer.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonelManager
    {
        Repository<Personel> personelRepo = new Repository<Personel>();

        public List<Personel> GetAll()
        {
            return personelRepo.List();
        }
        public bool addPersonel(Personel p)
        {
            return personelRepo.Insert(p);
        }
        public bool deletePersonel(int p)
        {
            if (p != 0)
            {
                Personel per = personelRepo.Find(x => x.ID == p);
                return per.aktif = false;
                
                
            }
            else
            {
                return false;
            }
        }
        public bool silPersonel(int p)
        {
            Personel per = personelRepo.Find(x => x.ID == p);
            per.aktif = false;
            personelRepo.Update(per);
            return true;
        }
        public bool updatePersonel(Personel p)
        {
            if(p.adi=="" || p.personelTip == "")
            {
                return false;
            }
            Personel per = personelRepo.Find(x => x.ID == p.ID);
            per.adi = p.adi;
            per.personelTip = p.personelTip;
            return true;
        }
        
    }
}
