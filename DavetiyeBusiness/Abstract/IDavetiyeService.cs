using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeBusiness.Abstract
{
    public interface IDavetiyeService
    {
        List<Davetiye> GetDavetiyes();
        Davetiye CreateDavetiye(Davetiye davetiye);
        List<Davetiye> Katilmadurumu(bool durum);
    }
}
