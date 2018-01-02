﻿// <auto-generated />
using Cotizaciones.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Cotizaciones.Migrations
{
    [DbContext(typeof(CotizacionesContext))]
    partial class CotizacionesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Cotizaciones.Models.Cotizacion", b =>
                {
                    b.Property<int>("CotizacionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Fecha");

                    b.Property<string>("Nombre");

                    b.Property<int>("Rut");

                    b.Property<string>("Servicios");

                    b.HasKey("CotizacionId");

                    b.HasIndex("Rut");

                    b.ToTable("Cotizaciones");
                });

            modelBuilder.Entity("Cotizaciones.Models.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Materno");

                    b.Property<string>("Nombre");

                    b.Property<string>("Paterno");

                    b.Property<string>("Rut")
                        .IsRequired();

                    b.HasKey("PersonaId");

                    b.HasAlternateKey("Rut")
                        .HasName("AlternateKey_Rut");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Cotizaciones.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Cotizaciones.Models.Cotizacion", b =>
                {
                    b.HasOne("Cotizaciones.Models.Persona", "Persona")
                        .WithMany("Cotizaciones")
                        .HasForeignKey("Rut")
                        .HasConstraintName("ForeignKey_Cotizacion_Persona")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
