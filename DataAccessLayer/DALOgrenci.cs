using System.Data.SqlClient;
using EntitiyLayer;
using System.Data;
using System.Collections.Generic;
using System;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OgrAd,OgrSoyad,OgrNumara,OGRFOTO,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            return komut1.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> deger = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * from TBLOGRENCI", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader data = komut2.ExecuteReader();
            while (data.Read())
            {
                EntityOgrenci ent1 = new EntityOgrenci();
                ent1.ID = Convert.ToInt32(data["OGRID"].ToString());
                ent1.AD = data["OGRAD"].ToString();
                ent1.SOYAD = data["OGRSOYAD"].ToString();
                ent1.NUMARA = data["OGRNUMARA"].ToString();
                ent1.FOTOGRAF = data["OGRFOTO"].ToString();
                ent1.SIFRE = data["OGRSIFRE"].ToString();
                ent1.BAKIYE = Convert.ToDouble(data["OGRBAKIYE"].ToString());
                deger.Add(ent1);

            }
            data.Close();
            return deger;

        }
        public static bool OgrenciSil(int parametre1)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLOGRENCI where OGRID=@p1",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            
            }
            komut3.Parameters.AddWithValue("@p1", parametre1);
            return komut3.ExecuteNonQuery() > 0;

        }
        public static bool OgrenciGuncelle(int parametre2,string ad,string soyad,string no ,string sifre,string foto)
        {
            SqlCommand komut4 = new SqlCommand("update  TBLOGRENCI set OGRAD=@p2, OGRSOYAD=@p3 , OGRNUMARA=@p4 , OGRFOTO=@p5 , OGRSIFRE=@p5 where OGRID=@p1", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();

            }
            komut4.Parameters.AddWithValue("@p1", parametre2);
            komut4.Parameters.AddWithValue("@p2", ad);
            komut4.Parameters.AddWithValue("@p3", soyad);
            komut4.Parameters.AddWithValue("@p4", no);
            komut4.Parameters.AddWithValue("@p5", sifre);
            komut4.Parameters.AddWithValue("@p6", foto);
            return komut4.ExecuteNonQuery()>0;



        }

    }
}
