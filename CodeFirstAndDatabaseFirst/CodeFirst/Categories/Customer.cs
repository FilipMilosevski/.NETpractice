using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Categories
{
    [Table("CustomerMaster", Schema = "Admin")]
    public class Customer
    {
        [Column(Order = 1)]
        public int CustomerID { get; set; }


        [Column("CustomerName", TypeName = "varchar(100)", Order = 7)]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)", Order = 6)]
        public string Name1 { get; set; }
        [Column(TypeName = "varchar", Order = 5)]
        public string Address { get; set; }



        [Column(TypeName = "text", Order = 4)]
        public string TextColumn { get; set; }



        [Column(TypeName = "money", Order = 3)]
        public decimal Amount { get; set; }



        [Column(TypeName = "decimal(14,2)", Order = 2)]
        public decimal Rate { get; set; }
    }
}
