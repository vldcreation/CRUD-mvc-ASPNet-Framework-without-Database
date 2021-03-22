
//11319028
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _11319028.Students.VicktorDesrony.Models
{
    public class Kategori
    {
        public int Kategori_ID { get; set; }
        [Required(ErrorMessage="Nama Kategori harus diisi")]
        public String NamaKategori { get; set; }
    }
}