using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11319028.Students.VicktorDesrony.Models;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public class PembeliList
    {
        static List<Pembeli> pembeliList = null;
        static PembeliList()
        {
            pembeliList = new List<Pembeli>()
            {
                new Pembeli()
                {
                    Pembeli_ID = 1,
                    NamaPembeli = "Vicktor Desrony",
                    JenisKelamin = "Laki Laki",
                    Username = "vldcreation",
                    Password = "123456",
                    Alamat = "Tanah Jawa"
                },
                new Pembeli()
                {
                    Pembeli_ID = 2,
                    NamaPembeli = "Pembeli 2",
                    JenisKelamin = "Wanita",
                    Username = "pembeli2",
                    Password = "123456",
                    Alamat = "Tarutung"
                }
            };
        }

        public static List<Pembeli> selectpembeliList()
        {
            return pembeliList;
        }

        public static void InsertpembeliList(Pembeli Pembeli)
        {
            pembeliList.Add(Pembeli);
        }

        public static void UpdatepembeliList(Pembeli Pembeli)
        {
            Pembeli PembeliUpdate = pembeliList.Find(x => x.Pembeli_ID == Pembeli.Pembeli_ID);
            PembeliUpdate.NamaPembeli = Pembeli.NamaPembeli;
            PembeliUpdate.JenisKelamin = Pembeli.JenisKelamin;
            PembeliUpdate.Alamat = Pembeli.Alamat;
        }
        public static void DeletepembeliList(int id)
        {
            Pembeli PembeliDelete = pembeliList.Find(x => x.Pembeli_ID == id);
            pembeliList.Remove(PembeliDelete);
        }
    }
}