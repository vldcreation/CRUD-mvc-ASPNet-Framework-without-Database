using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11319028.Students.VicktorDesrony.Models;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public interface IEProduk
    {
        List<Produk> allProduk();
        Produk SelectProdukById(int id);

        void insertProduk(Produk produk);
        void updateProduk(Produk produk);
        void deleteProduk(int id);
    }
}