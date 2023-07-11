using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

[Table("WarehouseInventory")]
public partial class WarehouseInventory
{
    [Key]
    [Column("WIID")]
    public int Wiid { get; set; }

    [Column("WID")]
    public int? Wid { get; set; }

    [Column("PID")]
    public int? Pid { get; set; }

    [Column("PDESCRIPTION")]
    [StringLength(50)]
    public string? Pdescription { get; set; }

    [ForeignKey("Pid")]
    [InverseProperty("WarehouseInventories")]
    public virtual Product? PidNavigation { get; set; }

    [ForeignKey("Wid")]
    [InverseProperty("WarehouseInventories")]
    public virtual Warehouse? WidNavigation { get; set; }
}
