using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ders3.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public String DepartmentName { get; set; }
        public virtual ICollection<Personnel> Personnels { get; set; }
    }
}
