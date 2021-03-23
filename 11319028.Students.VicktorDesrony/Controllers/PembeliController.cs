using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
        KeranjangRepo keranjangRepo = new KeranjangRepo();
        public ActionResult Index()
        {
            List<Produk> produk = produkRepo.allProduk();
            IEnumerable<Produk> prod = produkRepo.allProduk();
            produk.Sort(delegate (Produk x, Produk y)
            {
                if (x.Kategori == null && y.Kategori == null) return 0;
                else if (x.Kategori == null) return -1;
                else if (y.Kategori == null) return 1;
                else return x.Kategori.CompareTo(y.Kategori);
            });
            ViewBag.Produks = produk;
            return View(prod);
        }

        public ActionResult MyCart()
        {
            List<Keranjang> list = keranjangRepo.SelectKeranjangByIdPembeli(1);
            return View(list);
        }

        public ActionResult EditCart()
        {
            List<Keranjang> list = keranjangRepo.SelectKeranjangByIdPembeli(1);
            return View("MyCart",list);
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
        public ActionResult Beli(int id, Produk prod , Keranjang cart)
        {
            try
            {
                cart.IDProduk = prod.Produk_ID;
                cart.KategoriCart = prod.Kategori;
                cart.pathGambar = prod.ImagePath;
                cart.NamaCart = prod.Produk_Name;
                prod.Stok -= cart.JumlahCart;
                keranjangRepo.insertKeranjang(cart);
                produkRepo.updateProduk(prod);
                return RedirectToAction("MyCart");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "ERROR:" + ex.Message.ToString();
                return View();
            }
        }

        //
        // POST: /MyCart/EditCart/5
        [HttpPost]
        public ActionResult EditCart(int id, Keranjang cart, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
                try
                {
                    string path = Path.Combine(Server.MapPath("~/Assets/Image"),
                                               Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                    cart.pathGambar = Path.GetFileName(file.FileName);
                    keranjangRepo.updateKeranjang(id,cart);
                    return RedirectToAction("MyCart");
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    return View("MyCart");
                }
            else
            {
                ViewBag.Message = "You have not specified a file.";
                return View("MyCart");
            }
        }
    }
}