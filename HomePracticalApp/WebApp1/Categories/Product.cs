using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

[Table("Product")]
public partial class Product
{
    [Key]
    [Column("PID")]
    public int Pid { get; set; }

    [Column("PNAME")]
    [StringLength(25)]
    public string? Pname { get; set; }

    [Column("PDESCRIPTION")]
    [StringLength(50)]
    public string? Pdescription { get; set; }

    [InverseProperty("PidNavigation")]
    public virtual ICollection<WarehouseInventory> WarehouseInventories { get; set; } = new List<WarehouseInventory>();
}
