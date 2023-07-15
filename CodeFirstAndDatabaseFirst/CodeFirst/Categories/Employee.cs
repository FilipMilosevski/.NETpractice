using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Categories
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        [ForeignKey("Department")]
        public int DeptID { get; set; }
        //Navigation property
        public Department Department { get; set; }
    }
}
