using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

public partial class Agent
{
    [Key]
    [Column("AGENT_CODE")]
    [StringLength(6)]
    [Unicode(false)]
    public string AgentCode { get; set; } = null!;

    [Column("AGENT_NAME")]
    [StringLength(40)]
    [Unicode(false)]
    public string? AgentName { get; set; }

    [Column("WORKING_AREA")]
    [StringLength(35)]
    [Unicode(false)]
    public string? WorkingArea { get; set; }

    [Column("COMMISSION", TypeName = "decimal(10, 2)")]
    public decimal? Commission { get; set; }

    [Column("PHONE_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [Column("COUNTRY")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Country { get; set; }

    [InverseProperty("AgentCodeNavigation")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    [InverseProperty("AgentCodeNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
