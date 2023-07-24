using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Filip;

public partial class MyTable07112023Context : DbContext
{
    public MyTable07112023Context()
    {
    }

    public MyTable07112023Context(DbContextOptions<MyTable07112023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<WarehouseInventory> WarehouseInventories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyTable07112023;Integrated Security=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.AgentCode).HasName("PK__Agents__843A8BBA02D3CCD7");

            entity.Property(e => e.AgentCode).IsFixedLength();
            entity.Property(e => e.AgentName).IsFixedLength();
            entity.Property(e => e.PhoneNo).IsFixedLength();
            entity.Property(e => e.WorkingArea).IsFixedLength();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustCode).HasName("PK__Customer__8393C4A12CF7F88B");

            entity.Property(e => e.AgentCode).IsFixedLength();
            entity.Property(e => e.WorkingArea).IsFixedLength();

            entity.HasOne(d => d.AgentCodeNavigation).WithMany(p => p.Customers).HasConstraintName("FK__Customer__AGENT___398D8EEE");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrdNum).HasName("PK__Orders__27AB607C1F27DA59");

            entity.Property(e => e.AgentCode).IsFixedLength();

            entity.HasOne(d => d.AgentCodeNavigation).WithMany(p => p.Orders).HasConstraintName("FK__Orders__AGENT_CO__3D5E1FD2");

            entity.HasOne(d => d.CustCodeNavigation).WithMany(p => p.Orders).HasConstraintName("FK__Orders__CUST_COD__3C69FB99");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Product__C5775520207C41E9");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.Wid).HasName("PK__Warehous__DB376519EAB20A75");
        });

        modelBuilder.Entity<WarehouseInventory>(entity =>
        {
            entity.HasKey(e => e.Wiid).HasName("PK__Warehous__83D476FA8855CC53");

            entity.HasOne(d => d.PidNavigation).WithMany(p => p.WarehouseInventories).HasConstraintName("FK__WarehouseIn__PID__534D60F1");

            entity.HasOne(d => d.WidNavigation).WithMany(p => p.WarehouseInventories).HasConstraintName("FK__WarehouseIn__WID__52593CB8");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
