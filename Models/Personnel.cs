using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ders3.Models
{
    public class Personnel
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String City { get; set; }
        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
    }
}
