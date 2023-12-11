﻿// <auto-generated />
using System;
using CoreDepartman.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreDepartman.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231211181128_test1")]
    partial class test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreDepartman.Models.Departmanlar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Departmanlarid")
                        .HasColumnType("int");

                    b.Property<string>("departmanad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Departmanlarid");

                    b.ToTable("Departmanlars");
                });

            modelBuilder.Entity("CoreDepartman.Models.Personel", b =>
                {
                    b.Property<int>("perid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("perid"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Departid")
                        .HasColumnType("int");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("perid");

                    b.HasIndex("Departid");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("CoreDepartman.Models.Departmanlar", b =>
                {
                    b.HasOne("CoreDepartman.Models.Departmanlar", null)
                        .WithMany("Departmanlars")
                        .HasForeignKey("Departmanlarid");
                });

            modelBuilder.Entity("CoreDepartman.Models.Personel", b =>
                {
                    b.HasOne("CoreDepartman.Models.Departmanlar", "Depart")
                        .WithMany()
                        .HasForeignKey("Departid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depart");
                });

            modelBuilder.Entity("CoreDepartman.Models.Departmanlar", b =>
                {
                    b.Navigation("Departmanlars");
                });
#pragma warning restore 612, 618
        }
    }
}
