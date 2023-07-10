using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

[Keyless]
public partial class Player
{
    [Column("PlayerID")]
    public int PlayerId { get; set; }

    [StringLength(50)]
    public string Fname { get; set; } = null!;

    [StringLength(50)]
    public string Lname { get; set; } = null!;

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(50)]
    public string? Country { get; set; }

    public int? Zipcode { get; set; }

    public int? Phone { get; set; }
}
