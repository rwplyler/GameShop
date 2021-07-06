﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Model;

#nullable disable

namespace Repository
{
    public partial class GameShopContext : DbContext
    {
        public GameShopContext()
        {
        }

        public GameShopContext(DbContextOptions<GameShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acustomer> Acustomers { get; set; }
        public virtual DbSet<AnItem> AnItems { get; set; }
        public virtual DbSet<Aorder> Aorders { get; set; }
        public virtual DbSet<AorderDetail> AorderDetails { get; set; }
        public virtual DbSet<Astore> Astores { get; set; }
        public virtual DbSet<InventoryDetail> InventoryDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=GameShop;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Acustomer>(entity =>
            {
                entity.ToTable("ACustomer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LName");
            });

            modelBuilder.Entity<AnItem>(entity =>
            {
                entity.ToTable("AnItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Aorder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__AOrder__C3905BAFBE855E97");

                entity.ToTable("AOrder");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Aorders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__AOrder__Customer__1A14E395");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Aorders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__AOrder__StoreID__1B0907CE");
            });

            modelBuilder.Entity<AorderDetail>(entity =>
            {
                entity.ToTable("AOrderDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.AorderDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__AOrderDet__ItemI__22AA2996");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.AorderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__AOrderDet__Order__21B6055D");
            });

            modelBuilder.Entity<Astore>(entity =>
            {
                entity.ToTable("AStore");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryDetail>(entity =>
            {
                entity.HasKey(e => e.InventoryId)
                    .HasName("PK__Inventor__F5FDE6D3110B129F");

                entity.ToTable("InventoryDetail");

                entity.Property(e => e.InventoryId).HasColumnName("InventoryID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InventoryDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__Inventory__ItemI__173876EA");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.InventoryDetails)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Inventory__Store__164452B1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
