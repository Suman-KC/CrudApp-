using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class Employee
    {
        [Key]
        public int id{ get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Designation{ get; set; }
        public int Salary { get; set; }
    }
}
