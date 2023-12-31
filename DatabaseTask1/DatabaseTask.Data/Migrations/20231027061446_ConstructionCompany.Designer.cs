﻿// <auto-generated />
using System;
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    [Migration("20231027061446_ConstructionCompany")]
    partial class ConstructionCompany
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Core.Domain.ConstructionCompany", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConstructionCompanies");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniqueEmployeeNr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ConstructionCompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UniqueProjectNr")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConstructionCompanyId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Specialist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Specialists");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Project", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.ConstructionCompany", null)
                        .WithMany("Projects")
                        .HasForeignKey("ConstructionCompanyId");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Specialist", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Project", null)
                        .WithMany("Specialists")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.ConstructionCompany", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Project", b =>
                {
                    b.Navigation("Specialists");
                });
#pragma warning restore 612, 618
        }
    }
}
