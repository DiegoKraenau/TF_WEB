﻿// <auto-generated />
using System;
using Hospital.Repositoy.dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RapiSolverWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RapiSolverWeb.Models.Customer", b =>
                {
                    b.Property<int>("IdCustomer")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age")
                        .HasColumnName("age")
                        .HasMaxLength(80);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasColumnName("gender");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("phone")
                        .HasMaxLength(10);

                    b.HasKey("IdCustomer");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("RapiSolverWeb.Models.DetalleServiceSupplier", b =>
                {
                    b.Property<int>("IdDetalleServiceSupplier")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ServicioDetailIdServicio");

                    b.Property<int?>("SupplierDetailIdSupplier");

                    b.HasKey("IdDetalleServiceSupplier");

                    b.HasIndex("ServicioDetailIdServicio");

                    b.HasIndex("SupplierDetailIdSupplier");

                    b.ToTable("detailServiceSupplier");
                });

            modelBuilder.Entity("RapiSolverWeb.Models.Location", b =>
                {
                    b.Property<int>("Idlocation")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("address")
                        .HasMaxLength(80);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("city")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnName("country")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnName("state")
                        .HasMaxLength(50);

                    b.HasKey("Idlocation");

                    b.ToTable("location");
                });

            modelBuilder.Entity("RapiSolverWeb.Models.Reservation", b =>
                {
                    b.Property<int>("IdReservation")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<double>("Discount")
                        .HasColumnName("discount");

                    b.Property<int>("LocationId");

                    b.Property<double>("Prince")
                        .HasColumnName("price");

                    b.Property<string>("ReservationDate")
                        .HasColumnName("reservationDate");

                    b.Property<int>("ServiceId");

                    b.Property<int?>("ServicioIdServicio");

                    b.Property<int>("SupplierId");

                    b.HasKey("IdReservation");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ServicioIdServicio");

                    b.HasIndex("SupplierId");

                    b.ToTable("reservation");
                });

            modelBuilder.Entity("RapiSolverWeb.Models.ServiceCategory", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.HasKey("IdCategory");

                    b.ToTable("serviceCategory");
                });

            modelBuilder.Entity("RapiSolverWeb.Models.Servicio", b =>
                {
                    b.Property<int>("IdServicio")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Cost")
                        .HasColumnName("cost");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.HasKey("IdServicio");

                    b.HasIndex("CategoryId");

                    b.ToTable("servicio");
                });

            modelBuilder.Entity("RapiSolverWeb.Models.Supplier", b =>
                {
                    b.Property<int>("IdSupplier")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age")
                        .HasColumnName("age")
                        .HasMaxLength(80);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasColumnName("gender");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(50);

                    b.Property<string>("NameCompany")
                        .HasColumnName("nameCompany");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("phone")
                        .HasMaxLength(10);

                    b.Property<int?>("locationIdlocation");

                    b.HasKey("IdSupplier");

                    b.HasIndex("locationIdlocation");

                    b.ToTable("supplier");
                });

            modelBuilder.Entity("RapiSolverWeb.Models.DetalleServiceSupplier", b =>
                {
                    b.HasOne("RapiSolverWeb.Models.Servicio", "ServicioDetail")
                        .WithMany("DetalleSupplier")
                        .HasForeignKey("ServicioDetailIdServicio");

                    b.HasOne("RapiSolverWeb.Models.Supplier", "SupplierDetail")
                        .WithMany("DetalleServicio")
                        .HasForeignKey("SupplierDetailIdSupplier");
                });

            modelBuilder.Entity("RapiSolverWeb.Models.Reservation", b =>
                {
                    b.HasOne("RapiSolverWeb.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RapiSolverWeb.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RapiSolverWeb.Models.Servicio", "Servicio")
                        .WithMany("Reservations")
                        .HasForeignKey("ServicioIdServicio");

                    b.HasOne("RapiSolverWeb.Models.Supplier", "Supplier")
                        .WithMany("Reservations")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RapiSolverWeb.Models.Servicio", b =>
                {
                    b.HasOne("RapiSolverWeb.Models.ServiceCategory", "Category")
                        .WithMany("services")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RapiSolverWeb.Models.Supplier", b =>
                {
                    b.HasOne("RapiSolverWeb.Models.Location", "location")
                        .WithMany("Suppliers")
                        .HasForeignKey("locationIdlocation");
                });
#pragma warning restore 612, 618
        }
    }
}
