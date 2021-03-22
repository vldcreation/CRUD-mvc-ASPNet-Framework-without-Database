using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11319028.Students.VicktorDesrony.Models;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public class ProdukRepo : IEProduk
    {
        public List<Models.Produk> allProduk()
        {
            return ProdukList.selectProdukList();
        }

        public void deleteProduk(int id)
        {
            ProdukList.DeleteProdukList(id);
        }

        public void insertProduk(Models.Produk prod)
        {
            ProdukList.InsertProdukList(prod);
        }

        public Models.Produk SelectProdukById(int id)
        {
            return ProdukList.selectProdukList().Find(x => x.Produk_ID == id);
        }

        public void updateProduk(Models.Produk prod)
        {
            ProdukList.UpdateProdukList(prod);
        }
    }
}