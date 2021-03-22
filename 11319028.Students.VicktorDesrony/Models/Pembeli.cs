using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _11319028.Students.VicktorDesrony.Models
{
    public class Pembeli
    {
        [Required(ErrorMessage ="ID Pembeli harus diisi")]
        public int Pembeli_ID { get; set; }
        [Required(ErrorMessage = "Nama Pembeli harus diisi")]
        public String NamaPembeli { get; set; }
        [Required(ErrorMessage = "Jenis Kelamin Pembeli harus diisi")]
        public String JenisKelamin { get; set; }
        [Required(ErrorMessage = "Alamat Pembeli harus diisi")]
        public String Username { get; set; }
        [Required(ErrorMessage = "Username Pembeli harus diisi")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Password Pembeli harus diisi")]
        public String Alamat { get; set; }
    }
}