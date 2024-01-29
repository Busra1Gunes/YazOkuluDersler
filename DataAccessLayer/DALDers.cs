using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> dgr = new List<EntityDers>();
            SqlCommand kmt = new SqlCommand("Select * from TBLDERSLER", Baglanti.bgl);
            if (kmt.Connection.State != ConnectionState.Open)
            {
                kmt.Connection.Open();
            }
            SqlDataReader data = kmt.ExecuteReader();
            while (data.Read())
            {
                EntityDers e = new EntityDers();
                e.ID = Convert.ToInt32(data["DERSID"].ToString());
                e.DERSAD = data["DERSAD"].ToString();
                e.MAX = Convert.ToInt32(data["DERSMAXSKONT"]);
                e.MIN =Convert.ToInt32(data["DERSMINSKONT"]);
                dgr.Add(e);

            }
            data.Close();
            return dgr;

        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLBASVURUFORM (OGRENCIID,DERSID) values (@p1,@p2)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            komut1.Parameters.AddWithValue("@p2", parametre.BASDERSID);

            return komut1.ExecuteNonQuery();

        }
    }
}
