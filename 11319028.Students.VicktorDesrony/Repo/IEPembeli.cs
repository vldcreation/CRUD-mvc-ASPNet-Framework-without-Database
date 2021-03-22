using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _11319028.Students.VicktorDesrony.Models;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public interface IEPembeli
    {
        List<Pembeli> allPembeli();
        Pembeli SelectPembeliById(int id);
        Pembeli SelectPembeliByUsername(String username);
        void insertPembeli(Pembeli pembeli);
        void updatePembeli(Pembeli pembeli);
        void deletePembeli(int id);
    }
}