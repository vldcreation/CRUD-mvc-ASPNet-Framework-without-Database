using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _11319028.Students.VicktorDesrony.Models;
using _11319028.Students.VicktorDesrony.Repo;

namespace _11319028.Students.VicktorDesrony.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        ProdukRepo produkRepo = new ProdukRepo();
        KategoriRepo kategoriRepo = new KategoriRepo();
        PembeliRepo pembeliRepo = new PembeliRepo();
        public ActionResult Index()
        {
            List<Produk> produk = produkRepo.allProduk();
            List<Pembeli> pembeli = pembeliRepo.allPembeli();
            produk.Sort(delegate (Produk x, Produk y)
            {
                if (x.Kategori == null && y.Kategori == null) return 0;
                else if (x.Kategori == null) return -1;
                else if (y.Kategori == null) return 1;
                else return x.Kategori.CompareTo(y.Kategori);
            });
             IEnumerable<Produk> prod = produkRepo.allProduk();
            IEnumerable<Pembeli> pem = pembeliRepo.allPembeli();
            ViewData["Pembeli"] = pem;
            ViewData["Produk"] = prod;
            return View(ViewData);
        }

        //
        // GET: /Produk/Create
        public ActionResult Create()
        {
            IEnumerable<Kategori> kat = kategoriRepo.allKategori();
            ViewData["ListKategori"] = kat;
            return View(ViewData);
        }

        //
        // Get : /AddPembeli
        public ActionResult AddPembeli()
        {
            return View();
        }

        //
        // POST: /Produk/Create
        [HttpPost]
        public ActionResult Create(Produk prod, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
                try
                {
                    string path = Path.Combine(Server.MapPath("~/Assets/Image"),
                                               Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                    prod.ImagePath = Path.GetFileName(file.FileName);
                    produkRepo.insertProduk(prod);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    return View();
                }
            else
            {
                ViewBag.Message = "You have not specified a file.";
                return View();
            }
        }

        //
        //Post : /Pembeli
        [HttpPost]
        public ActionResult AddPembeli(Pembeli pem)
        {
            if (pem == null)
                return RedirectToAction("AddPembeli");
            pembeliRepo.insertPembeli(pem);
            return RedirectToAction("Index");
        }

        //
        // GET: /Produk/Edit/5
        public ActionResult Edit(int id)
        {
            Produk obj = produkRepo.SelectProdukById(id);
            return View(obj);
        }

        public ActionResult EditPembeli(int id)
        {
            Pembeli pem = pembeliRepo.SelectPembeliById(id);
            return View(pem);
        }

        //
        // POST: /Produk/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Produk prod, HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
                try
                {
                    string path = Path.Combine(Server.MapPath("~/Assets/Image"),
                                               Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                    prod.ImagePath = Path.GetFileName(file.FileName);
                    produkRepo.updateProduk(prod);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    return View();
                }
            else
            {
                ViewBag.Message = "You have not specified a file.";
                return View();
            }
        }

        //
        //Post : /EditPembeli/2
        [HttpPost]
        public ActionResult EditPembeli(int id , Pembeli pem)
        {
            if (pem.NamaPembeli == "" || pem.JenisKelamin == "" || pem.Password == "" || pem.Alamat == "")
                return RedirectToAction("EditPembeli");
            pembeliRepo.updatePembeli(pem);
            return RedirectToAction("Index");
        }

        //
        // GET: /Produk/Delete/5
        public ActionResult Delete(int id)
        {
            Produk obj = produkRepo.SelectProdukById(id);
            return View(obj);
        }

        //
        //Get : /Pembeli/Delete/2
        public ActionResult DeletePembeli(int id)
        {
            Pembeli pem = pembeliRepo.SelectPembeliById(id);
            return View(pem);
        }

        //
        // POST: /Produk/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                produkRepo.deleteProduk(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        //POST : /Pembeli/Delete/2
        [HttpPost]
        public ActionResult DeletePembeli(int id, FormCollection collection)
        {
            try
            {
                pembeliRepo.deletePembeli(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}