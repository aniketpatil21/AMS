﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ratings.DbContexts;

#nullable disable

namespace Ratings.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230127082718_UpdatedTotalClass")]
    partial class UpdatedTotalClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ratings.Models.CheckoutCounter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CDC")
                        .HasColumnType("int");

                    b.Property<int>("QECC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CheckoutCounters");
                });

            modelBuilder.Entity("Ratings.Models.ManningCustomerRelation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CSI")
                        .HasColumnType("int");

                    b.Property<int>("GG")
                        .HasColumnType("int");

                    b.Property<int>("Manning")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ManningCustomerRelations");
                });

            modelBuilder.Entity("Ratings.Models.MerchandiseReadiness", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DS")
                        .HasColumnType("int");

                    b.Property<int>("FMCG")
                        .HasColumnType("int");

                    b.Property<int>("GMD")
                        .HasColumnType("int");

                    b.Property<int>("PT")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MerchandiseReadinesses");
                });

            modelBuilder.Entity("Ratings.Models.StoreCleanliness", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BOEA")
                        .HasColumnType("int");

                    b.Property<int>("FSCR")
                        .HasColumnType("int");

                    b.Property<int>("GPFE")
                        .HasColumnType("int");

                    b.Property<int>("RS")
                        .HasColumnType("int");

                    b.Property<int>("SAB")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("storeCleanlinesses");
                });

            modelBuilder.Entity("Ratings.Models.Total", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MCRId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MRId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SCId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalRating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Totals");
                });

            modelBuilder.Entity("Ratings.Models.Total", b =>
                {
                    b.HasOne("Ratings.Models.CheckoutCounter", "CC")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ratings.Models.ManningCustomerRelation", "MCR")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ratings.Models.MerchandiseReadiness", "MR")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ratings.Models.StoreCleanliness", "SC")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CC");

                    b.Navigation("MCR");

                    b.Navigation("MR");

                    b.Navigation("SC");
                });
#pragma warning restore 612, 618
        }
    }
}
