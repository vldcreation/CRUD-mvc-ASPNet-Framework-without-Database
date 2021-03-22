using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11319028.Students.VicktorDesrony.Models;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public static class ProdukList
    {
        static List<Produk> produkList = null;
        static ProdukList()
        {
            produkList = new List<Produk>()
            {
                new Produk()
                {
                    Produk_ID = 1,
                    Kategori = "rempah-rempah",
                    ImagePath = "imgBawang.jpg",
                    Produk_Name = "Bawang",
                    Stok = 120,
                    Harga = 12000
                },
                new Produk()
                {
                    Produk_ID = 2,
                    Kategori = "rempah-rempah",
                    ImagePath = "imgCabai.jpg",
                    Produk_Name = "Cabai",
                    Stok = 125,
                    Harga = 15000
                }
            };
        }

        public static List<Produk> selectProdukList()
        {
            return produkList;
        }

        public static void InsertProdukList(Produk produk)
        {
            produkList.Add(produk);
        }

        public static void UpdateProdukList(Produk produk)
        {
            Produk produkUpdate = produkList.Find(x => x.Produk_ID == produk.Produk_ID);
            produkUpdate.Kategori = produk.Kategori;
            produkUpdate.ImagePath = produk.ImagePath;
            produkUpdate.Produk_Name = produk.Produk_Name;
            produkUpdate.Stok = produk.Stok;
            produkUpdate.Harga = produk.Harga;
        }
        public static void DeleteProdukList(int id)
        {
            Produk produkDelete = produkList.Find(x => x.Produk_ID == id);
            produkList.Remove(produkDelete);
        }
    }
}