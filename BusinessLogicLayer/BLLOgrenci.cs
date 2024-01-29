using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
     public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if(p.AD!=null && p.SOYAD!=null &&p.NUMARA!=null &p.SIFRE!=null && p.FOTOGRAF!=null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BllListele()
        {
            return DALOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBLL(int a)
        {
           
                return DALOgrenci.OgrenciSil(a);

        }
        public static bool OgrenciGuncelleBLL(EntityOgrenci a)
        {

            return DALOgrenci.OgrenciGuncelle(a.ID,a.AD,a.SOYAD,a.NUMARA,a.SIFRE,a.FOTOGRAF);

        }
    }
}
