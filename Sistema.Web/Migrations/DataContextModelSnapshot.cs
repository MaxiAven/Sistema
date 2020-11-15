﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema.Web.Data;

namespace Sistema.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sistema.Web.Data.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoPostal")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("DocumentoId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("LocalidadId");

                    b.Property<string>("NroDocumento")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("ProvinciaId");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("DocumentoId");

                    b.HasIndex("LocalidadId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.DetallePedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<int?>("PedidosId");

                    b.HasKey("Id");

                    b.HasIndex("PedidosId");

                    b.ToTable("DetallePedido");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Localidad");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientesId");

                    b.Property<DateTime>("Fecha");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.Provincia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("ProvinciaId");

                    b.HasKey("Id");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.TipoProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("TipoProductosId");

                    b.HasKey("Id");

                    b.HasIndex("TipoProductosId");

                    b.ToTable("TipoProducto");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.Cliente", b =>
                {
                    b.HasOne("Sistema.Web.Data.Entities.Documento", "Documento")
                        .WithMany("Cliente")
                        .HasForeignKey("DocumentoId");

                    b.HasOne("Sistema.Web.Data.Entities.Localidad", "Localidad")
                        .WithMany("Clientes")
                        .HasForeignKey("LocalidadId");

                    b.HasOne("Sistema.Web.Data.Entities.Provincia", "Provincia")
                        .WithMany()
                        .HasForeignKey("ProvinciaId");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.DetallePedido", b =>
                {
                    b.HasOne("Sistema.Web.Data.Entities.Pedido", "Pedidos")
                        .WithMany("DetallePedido")
                        .HasForeignKey("PedidosId");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.Pedido", b =>
                {
                    b.HasOne("Sistema.Web.Data.Entities.Cliente", "Clientes")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClientesId");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.Provincia", b =>
                {
                    b.HasOne("Sistema.Web.Data.Entities.Provincia")
                        .WithMany("Provincias")
                        .HasForeignKey("ProvinciaId");
                });

            modelBuilder.Entity("Sistema.Web.Data.Entities.TipoProducto", b =>
                {
                    b.HasOne("Sistema.Web.Data.Entities.TipoProducto", "TipoProductos")
                        .WithMany()
                        .HasForeignKey("TipoProductosId");
                });
#pragma warning restore 612, 618
        }
    }
}
