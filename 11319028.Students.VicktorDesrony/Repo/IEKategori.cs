using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11319028.Students.VicktorDesrony.Models;
namespace _11319028.Students.VicktorDesrony.Repo
{
    interface IEKategori
    {
        List<Kategori> allKategori();
        Kategori SelectKategoriById(int id);
        void insertKategori(Kategori kategori);
        void updateKategori(Kategori kategori);
        void deleteKategori(int id);
    }

}
