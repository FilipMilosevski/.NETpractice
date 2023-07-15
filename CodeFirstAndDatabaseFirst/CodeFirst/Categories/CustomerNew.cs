using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Categories
{
    public class CustomerNew
    {
        public int CustomerID { get; set; }
        [Key]
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
    }
}
