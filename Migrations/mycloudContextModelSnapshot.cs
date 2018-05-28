﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using mycloud.Models;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace mycloud.Migrations
{
    [DbContext(typeof(mycloudContext))]
    partial class mycloudContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("mycloud.Models.CableRange", b =>
                {
                    b.Property<int>("CableRangeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Description");

                    b.HasKey("CableRangeId");

                    b.HasIndex("CountryId");

                    b.ToTable("CableRanges");
                });

            modelBuilder.Entity("mycloud.Models.Conductor", b =>
                {
                    b.Property<int>("ConductorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("ConductorId");

                    b.ToTable("Conductors");
                });

            modelBuilder.Entity("mycloud.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("mycloud.Models.CprClass", b =>
                {
                    b.Property<int>("CprClassId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("CprClassId");

                    b.ToTable("CprClasses");
                });

            modelBuilder.Entity("mycloud.Models.Design", b =>
                {
                    b.Property<int>("DesignId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Description");

                    b.HasKey("DesignId");

                    b.HasIndex("CountryId");

                    b.ToTable("Designs");
                });

            modelBuilder.Entity("mycloud.Models.Installation1", b =>
                {
                    b.Property<int>("Installation1Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Installation1Id");

                    b.ToTable("Installation1s");
                });

            modelBuilder.Entity("mycloud.Models.Installation2", b =>
                {
                    b.Property<int>("Installation2Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Installation2Id");

                    b.ToTable("Installation2s");
                });

            modelBuilder.Entity("mycloud.Models.Installation3", b =>
                {
                    b.Property<int>("Installation3Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Installation3Id");

                    b.ToTable("Installation3s");
                });

            modelBuilder.Entity("mycloud.Models.Insulator", b =>
                {
                    b.Property<int>("InsulatorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("InsulatorId");

                    b.ToTable("Insulators");
                });

            modelBuilder.Entity("mycloud.Models.LinkCableInstallation", b =>
                {
                    b.Property<int>("LinkCableInstallationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<int>("Installation1Id");

                    b.Property<int>("Installation2Id");

                    b.Property<int>("Installation3Id");

                    b.Property<int>("ProductId");

                    b.HasKey("LinkCableInstallationId");

                    b.HasIndex("CountryId");

                    b.HasIndex("Installation1Id");

                    b.HasIndex("Installation2Id");

                    b.HasIndex("Installation3Id");

                    b.HasIndex("ProductId");

                    b.ToTable("LinkCableInstallations");
                });

            modelBuilder.Entity("mycloud.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CableRangeId");

                    b.Property<string>("CatalogueAddress");

                    b.Property<string>("CommercialName");

                    b.Property<int>("ConductorId");

                    b.Property<int>("CountryId");

                    b.Property<int>("CprClassId");

                    b.Property<int>("DesignId");

                    b.Property<string>("GenericName");

                    b.Property<string>("Image");

                    b.Property<int>("InsulatorId");

                    b.Property<bool>("IsArmoured");

                    b.Property<int>("Position");

                    b.Property<int>("RestrictionId");

                    b.Property<string>("Translation");

                    b.Property<int>("VoltageClassId");

                    b.HasKey("ProductId");

                    b.HasIndex("CableRangeId");

                    b.HasIndex("ConductorId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CprClassId");

                    b.HasIndex("DesignId");

                    b.HasIndex("InsulatorId");

                    b.HasIndex("RestrictionId");

                    b.HasIndex("VoltageClassId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("mycloud.Models.Restriction", b =>
                {
                    b.Property<int>("RestrictionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("RestrictionId");

                    b.ToTable("Restrictions");
                });

            modelBuilder.Entity("mycloud.Models.VoltageClass", b =>
                {
                    b.Property<int>("VoltageClassId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("VoltageClassId");

                    b.ToTable("VoltageClasses");
                });

            modelBuilder.Entity("mycloud.Models.CableRange", b =>
                {
                    b.HasOne("mycloud.Models.Country", "Country")
                        .WithMany("CableRanges")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mycloud.Models.Design", b =>
                {
                    b.HasOne("mycloud.Models.Country", "Country")
                        .WithMany("Designs")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mycloud.Models.LinkCableInstallation", b =>
                {
                    b.HasOne("mycloud.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Installation1", "Installation1")
                        .WithMany()
                        .HasForeignKey("Installation1Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Installation2", "Installation2")
                        .WithMany()
                        .HasForeignKey("Installation2Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Installation3", "Installation3")
                        .WithMany()
                        .HasForeignKey("Installation3Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mycloud.Models.Product", b =>
                {
                    b.HasOne("mycloud.Models.CableRange", "CableRange")
                        .WithMany("Products")
                        .HasForeignKey("CableRangeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Conductor", "Conductor")
                        .WithMany("Products")
                        .HasForeignKey("ConductorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Country", "Country")
                        .WithMany("Products")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.CprClass", "CprClass")
                        .WithMany("Products")
                        .HasForeignKey("CprClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Design", "Design")
                        .WithMany("Products")
                        .HasForeignKey("DesignId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Insulator", "Insulator")
                        .WithMany("Products")
                        .HasForeignKey("InsulatorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Restriction", "Restriction")
                        .WithMany("Products")
                        .HasForeignKey("RestrictionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.VoltageClass", "VoltageClass")
                        .WithMany("Products")
                        .HasForeignKey("VoltageClassId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
