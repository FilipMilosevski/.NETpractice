using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

[Table("Warehouse")]
public partial class Warehouse
{
    [Key]
    [Column("WID")]
    public int Wid { get; set; }

    [Column("WADDRESS")]
    [StringLength(50)]
    public string? Waddress { get; set; }

    [Column("WNAME")]
    [StringLength(25)]
    public string? Wname { get; set; }

    [Column("WPHONENUMBER")]
    public int? Wphonenumber { get; set; }

    [InverseProperty("WidNavigation")]
    public virtual ICollection<WarehouseInventory> WarehouseInventories { get; set; } = new List<WarehouseInventory>();
}
