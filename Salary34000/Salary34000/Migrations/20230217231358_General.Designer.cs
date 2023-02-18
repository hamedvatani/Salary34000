﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salary34000.Data;

#nullable disable

namespace Salary34000.Migrations
{
    [DbContext(typeof(SalaryContext))]
    [Migration("20230217231358_General")]
    partial class General
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("Salary34000.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ChildrenCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DocumentCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DocumentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DocumentSerial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PersonelCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
