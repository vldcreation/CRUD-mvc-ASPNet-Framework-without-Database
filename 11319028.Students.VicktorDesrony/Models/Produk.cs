
//11319028
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _11319028.Students.VicktorDesrony.Models
{
    public class Produk
    {
        public int Produk_ID { get; set; }
        public String Kategori { get; set; }
        public String ImagePath { get; set; }
        public String Produk_Name { get; set; }
        public int Stok { get; set; }
        public double Harga { get; set; }
    }
}