using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _11319028.Students.VicktorDesrony.Models
{
    public class Keranjang
    {
        public int ID { get; set; }
        public int IDProduk { get; set; }
        public int IDPembeli { get; set; }
        public String pathGambar { get; set; }
        public String KategoriCart { get; set; }
        public String NamaCart { get; set; }
        public int JumlahCart { get; set; }
        public double Harga { get; set; }
        
    }
}