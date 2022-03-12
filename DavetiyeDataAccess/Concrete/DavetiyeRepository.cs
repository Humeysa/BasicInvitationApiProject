using DavetiyeDataAccess.Abstract;
using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeDataAccess.Concrete
{
    public class DavetiyeRepository : IDavetiyeRepository
    {
        public Davetiye CreateDavetiye(Davetiye davetiye)
        {
            using (var db = new DavetiyeDbContext())
            {
                db.Davetiye.Add(davetiye);
                db.SaveChanges();
                return davetiye;
            }
        }

        public List<Davetiye> GetDavetiyes()
        {
            using (var db = new DavetiyeDbContext())
            {
                return db.Davetiye.ToList();
            }
        }

        public List<Davetiye> Katilmadurumu(bool durum)
        {
            using (var db = new DavetiyeDbContext())
            {
               return db.Davetiye.Where(x => x.KatilmaDurumu == durum).ToList();
                
            }
            
        }
    }
}