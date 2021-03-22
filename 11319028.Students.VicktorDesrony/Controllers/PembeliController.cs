using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _11319028.Students.VicktorDesrony.Models;
using _11319028.Students.VicktorDesrony.Repo;

namespace _11319028.Students.VicktorDesrony.Controllers
{
    public class PembeliController : Controller
    {
        // GET: Pembeli
        ProdukRepo produkRepo = new ProdukRepo();
        KategoriRepo kategoriRepo = new KategoriRepo();
        PembeliRepo pembeliRepo = new PembeliRepo();
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
            ViewBag.Produks = produk;
            return View(prod);
        }

        //
        //Get : Product/Beli/5
        public ActionResult Beli(int id)
        {
            Produk prod = produkRepo.SelectProdukById(id);
            return View(prod);
        }

        //
        //Post : Product/Beli/5
        [HttpPost]
        public ActionResult Beli(int id, Produk prod)
        {
            try
            {
                produkRepo.updateProduk(prod);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "ERROR:" + ex.Message.ToString();
                return View();
            }
        }
    }
}