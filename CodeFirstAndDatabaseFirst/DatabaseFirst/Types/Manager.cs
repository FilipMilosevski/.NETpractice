using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

[Keyless]
public partial class Manager
{
    [Column("ManagerID")]
    public int ManagerId { get; set; }

    [Column("MFName")]
    [StringLength(50)]
    public string Mfname { get; set; } = null!;

    [Column("MLName")]
    [StringLength(50)]
    public string Mlname { get; set; } = null!;

    [Column("MCity")]
    [StringLength(50)]
    public string? Mcity { get; set; }

    [Column("MCountry")]
    [StringLength(50)]
    public string? Mcountry { get; set; }

    [Column("MZipcode")]
    public int? Mzipcode { get; set; }

    [Column("MPhone")]
    public int? Mphone { get; set; }
}
