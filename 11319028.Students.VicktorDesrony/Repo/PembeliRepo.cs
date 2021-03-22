using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11319028.Students.VicktorDesrony.Repo
{
    public class PembeliRepo : IEPembeli
    {
        public List<Models.Pembeli> allPembeli()
        {
            return PembeliList.selectpembeliList();
        }

        public void deletePembeli(int id)
        {
            PembeliList.DeletepembeliList(id);
        }

        public void insertPembeli(Models.Pembeli pem)
        {
            PembeliList.InsertpembeliList(pem);
        }

        public Models.Pembeli SelectPembeliByUsername(String username)
        {
            return PembeliList.selectpembeliList().Find(x => x.Username == username);
        }


        public Models.Pembeli SelectPembeliById(int id)
        {
            return PembeliList.selectpembeliList().Find(x => x.Pembeli_ID == id);
        }

        public void updatePembeli(Models.Pembeli pem)
        {
            PembeliList.UpdatepembeliList(pem);
        }
    }
}