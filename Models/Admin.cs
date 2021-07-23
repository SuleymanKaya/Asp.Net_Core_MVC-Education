using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ders3.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public String KullaniciAdi { get; set; }

        [Column(TypeName ="nvarchar(10)")]
        public String Sifre { get; set; }
    }
}
