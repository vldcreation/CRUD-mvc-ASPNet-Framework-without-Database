using _11319028.Students.VicktorDesrony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public class KategoriRepo : IEKategori
    {
        public List<Models.Kategori> allKategori()
        {
            return KategoriList.selectKategoriList();
        }

        public void deleteKategori(int id)
        {
            KategoriList.DeleteKategoriList(id);
        }

        public void insertKategori(Models.Kategori kat)
        {
            KategoriList.InsertKategoriList(kat);
        }


        public Models.Kategori SelectKategoriById(int id)
        {
            return KategoriList.selectKategoriList().Find(x => x.Kategori_ID == id);
        }

        public void updateKategori(Models.Kategori kat)
        {
            KategoriList.UpdateKategoriList(kat);
        }
    }
}