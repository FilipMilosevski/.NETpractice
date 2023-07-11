using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

public partial class Order
{
    [Key]
    [Column("ORD_NUM", TypeName = "decimal(6, 0)")]
    public decimal OrdNum { get; set; }

    [Column("ORD_AMOUNT", TypeName = "decimal(12, 2)")]
    public decimal? OrdAmount { get; set; }

    [Column("ADVANCE_AMOUNT", TypeName = "decimal(12, 2)")]
    public decimal? AdvanceAmount { get; set; }

    [Column("ORD_DATE", TypeName = "date")]
    public DateTime? OrdDate { get; set; }

    [Column("CUST_CODE")]
    [StringLength(6)]
    [Unicode(false)]
    public string? CustCode { get; set; }

    [Column("AGENT_CODE")]
    [StringLength(6)]
    [Unicode(false)]
    public string? AgentCode { get; set; }

    [Column("ORD_DESCRIPTION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? OrdDescription { get; set; }

    [ForeignKey("AgentCode")]
    [InverseProperty("Orders")]
    public virtual Agent? AgentCodeNavigation { get; set; }

    [ForeignKey("CustCode")]
    [InverseProperty("Orders")]
    public virtual Customer? CustCodeNavigation { get; set; }
}
