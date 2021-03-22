using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11319028.Students.VicktorDesrony.Models;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public class KeranjangList
    {
        static List<Keranjang> listKeranjang = null;
        static KeranjangList()
        {
            listKeranjang = new List<Keranjang>()
            {
                new Keranjang()
                {
                    ID = 1,
                    IDProduk = 1,
                    IDPembeli = 1,
                    pathGambar = "imgCabai.jpg",
                    KategoriCart = "rempah-rempah",
                    NamaCart = "Cabai",
                    JumlahCart = 5,
                    Harga = 15000
                }
            };
        }

        public static List<Keranjang> selectallKeranjang()
        {
            return listKeranjang;
        }

        public static void insertKeranjang(Keranjang keranjang)
        {
            listKeranjang.Add(keranjang);
        }

        public static void updateKeranjang(int id,Keranjang keranjang)
        {
            Keranjang keranjangUpdate = listKeranjang.Find(x => x.ID == keranjang.ID);
            keranjangUpdate = keranjang;
        }

        public static void deleteKeranjang(int id)
        {
            Keranjang keranjangDelete = listKeranjang.Find(x => x.ID == id);
            listKeranjang.Remove(keranjangDelete);
        }


    }
}