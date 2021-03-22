using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11319028.Students.VicktorDesrony.Models;
namespace _11319028.Students.VicktorDesrony.Repo
{
    interface IEKeranjang
    {
        List<Keranjang> allKeranjang();
        List<Keranjang> listbyKategori(int id,String kategori);
        Keranjang SelectKeranjangById(int id);
        Keranjang SelectKeranjangByIdPembeli(int id);
        void insertKeranjang(Keranjang keranjang);
        void updateKeranjang(int idUser,Keranjang keranjang);
        void deleteKeranjang(int id);
    }

}
