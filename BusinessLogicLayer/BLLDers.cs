using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }
        public static int DersTalepEkleBLL(EntityBasvuruForm p)
        {
            if (p.BASDERSID>0 && p.BASOGRID>0)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }

    }
}
