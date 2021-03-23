using _11319028.Students.VicktorDesrony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public class KeranjangRepo : IEKeranjang
    {
        public List<Models.Keranjang> allKeranjang()
        {
            return KeranjangList.selectallKeranjang();
        }

        public void deleteKeranjang(int id)
        {
            KeranjangList.deleteKeranjang(id);
        }

        public void insertKeranjang(Models.Keranjang keranjang)
        {
            KeranjangList.insertKeranjang(keranjang);
        }

        public List<Models.Keranjang> listbyKategori(int id,String kategori)
        {
            var newList = allKeranjang().Where(p => p.IDPembeli == id && p.KategoriCart == kategori).ToList();
            return newList;
        }

        public Models.Keranjang SelectKeranjangById(int id)
        {
            return allKeranjang().Where(p => p.ID == id).First();
        }

        public List<Models.Keranjang> SelectKeranjangByIdPembeli(int id)
        {
            var newList = allKeranjang().Where(p => p.IDPembeli == id).ToList();
            return newList;
        }

        public void updateKeranjang(int idUser, Models.Keranjang keranjang)
        {
            KeranjangList.updateKeranjang(idUser, keranjang);
        }
    }
}