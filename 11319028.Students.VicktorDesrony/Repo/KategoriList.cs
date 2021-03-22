using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11319028.Students.VicktorDesrony.Models;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public class KategoriList
    {
        static List<Kategori> kategoriList = null;
        static KategoriList()
        {
            kategoriList = new List<Kategori>()
            {
                new Kategori()
                {
                    Kategori_ID = 1,
                    NamaKategori = "rempah-rempah"
                },
               new Kategori()
                {
                    Kategori_ID = 2,
                    NamaKategori = "buah-buahan"
                },
               new Kategori()
                {
                    Kategori_ID = 3,
                    NamaKategori = "Ikan&DagingSegar"
                },
               new Kategori()
                {
                    Kategori_ID = 4,
                    NamaKategori = "sayur-mayur"
                }
            };
        }

        public static List<Kategori> selectKategoriList()
        {
            return kategoriList;
        }

        public static void InsertKategoriList(Kategori kategori)
        {
            kategoriList.Add(kategori);
        }

        public static void UpdateKategoriList(Kategori kategori)
        {
            Kategori kategoriUpdate = kategoriList.Find(x => x.Kategori_ID == kategori.Kategori_ID);
            kategoriUpdate.Kategori_ID = kategori.Kategori_ID;
            kategoriUpdate.NamaKategori = kategori.NamaKategori;
        }
        public static void DeleteKategoriList(int id)
        {
            Kategori kategoriDelete = kategoriList.Find(x => x.Kategori_ID == id);
            kategoriList.Remove(kategoriDelete);
        }
    }
}