
//11319028
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _11319028.Students.VicktorDesrony.Models;
using _11319028.Students.VicktorDesrony.Repo;

namespace _11319028.Students.VicktorDesrony.Controllers
{
    public class HomeController : Controller
    {
        ProdukRepo produkRepo = new ProdukRepo();
        KategoriRepo kategoriRepo = new KategoriRepo();
        public ActionResult Index()
        {
            List<Produk> produk = produkRepo.allProduk();
            produk.Sort(delegate (Produk x, Produk y)
            {
                if (x.Kategori == null && y.Kategori == null) return 0;
                else if (x.Kategori == null) return -1;
                else if (y.Kategori == null) return 1;
                else return x.Kategori.CompareTo(y.Kategori);
            });
            IEnumerable<Produk> prod = produkRepo.allProduk();
            return View(prod);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}