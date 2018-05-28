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
    [Migration("20180516075107_Design")]
    partial class Design
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

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

            modelBuilder.Entity("mycloud.Models.Insulator", b =>
                {
                    b.Property<int>("InsulatorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("InsulatorId");

                    b.ToTable("Insulators");
                });

            modelBuilder.Entity("mycloud.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CatalogueAddress");

                    b.Property<string>("CommercialName");

                    b.Property<int>("ConductorId");

                    b.Property<int>("CountryId");

                    b.Property<int>("DesignId");

                    b.Property<string>("GenericName");

                    b.Property<string>("Image");

                    b.Property<int>("InsulatorId");

                    b.Property<int>("Position");

                    b.Property<int>("RestrictionId");

                    b.Property<string>("Translation");

                    b.HasKey("ProductId");

                    b.HasIndex("ConductorId");

                    b.HasIndex("CountryId");

                    b.HasIndex("DesignId");

                    b.HasIndex("InsulatorId");

                    b.HasIndex("RestrictionId");

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

            modelBuilder.Entity("mycloud.Models.Design", b =>
                {
                    b.HasOne("mycloud.Models.Country", "Country")
                        .WithMany("Designs")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("mycloud.Models.Product", b =>
                {
                    b.HasOne("mycloud.Models.Conductor", "Conductor")
                        .WithMany("Products")
                        .HasForeignKey("ConductorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("mycloud.Models.Country", "Country")
                        .WithMany("Products")
                        .HasForeignKey("CountryId")
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
                });
#pragma warning restore 612, 618
        }
    }
}