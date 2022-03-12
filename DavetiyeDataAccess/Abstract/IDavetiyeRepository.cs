using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeDataAccess.Abstract
{
    public interface IDavetiyeRepository
    {
        List<Davetiye> GetDavetiyes();
        Davetiye CreateDavetiye(Davetiye davetiye);
        List<Davetiye> Katilmadurumu(bool durum);
    }
}
