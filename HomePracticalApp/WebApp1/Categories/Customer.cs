using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Filip;

[Table("Customer")]
public partial class Customer
{
    [Key]
    [Column("CUST_CODE")]
    [StringLength(6)]
    [Unicode(false)]
    public string CustCode { get; set; } = null!;

    [Column("CUST_NAME")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CustName { get; set; }

    [Column("WORKING_AREA")]
    [StringLength(35)]
    [Unicode(false)]
    public string? WorkingArea { get; set; }

    [Column("CUST_COUNTRY")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CustCountry { get; set; }

    [Column("GRADE")]
    public int? Grade { get; set; }

    [Column("OPENING_AMT", TypeName = "decimal(12, 2)")]
    public decimal? OpeningAmt { get; set; }

    [Column("RECEIVE_AMT", TypeName = "decimal(12, 2)")]
    public decimal? ReceiveAmt { get; set; }

    [Column("PAYMENT_AMT", TypeName = "decimal(12, 2)")]
    public decimal? PaymentAmt { get; set; }

    [Column("OUTSTANDING_AMT", TypeName = "decimal(12, 2)")]
    public decimal? OutstandingAmt { get; set; }

    [Column("PHONE_NO")]
    [StringLength(17)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [Column("AGENT_CODE")]
    [StringLength(6)]
    [Unicode(false)]
    public string? AgentCode { get; set; }

    [ForeignKey("AgentCode")]
    [InverseProperty("Customers")]
    public virtual Agent? AgentCodeNavigation { get; set; }

    [InverseProperty("CustCodeNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
