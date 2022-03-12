using DavetiyeBusiness.Abstract;
using DavetiyeDataAccess.Abstract;
using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeBusiness.Concrete
{
    public class DavetiyeManager : IDavetiyeService
    {
        private IDavetiyeRepository rep;
        public DavetiyeManager(IDavetiyeRepository _rep)
        {
            rep = _rep;
        }

        public Davetiye CreateDavetiye(Davetiye davetiye)
        {
            return rep.CreateDavetiye(davetiye);
        }

        public List<Davetiye> GetDavetiyes()
        {
            return rep.GetDavetiyes();
        }

        public List<Davetiye> Katilmadurumu(bool durum)
        {
            return rep.Katilmadurumu(durum);
        }
    }
}
