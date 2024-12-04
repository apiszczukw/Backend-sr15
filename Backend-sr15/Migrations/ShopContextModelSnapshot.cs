﻿// <auto-generated />
using System;
using Backend_sr15.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_sr15.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend_sr15.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "pomidor",
                            Price = 8.5
                        },
                        new
                        {
                            Id = 2,
                            Name = "ziemniaki",
                            Price = 2.2999999999999998
                        },
                        new
                        {
                            Id = 3,
                            Name = "ogórek",
                            Price = 6.0
                        },
                        new
                        {
                            Id = 4,
                            Name = "kalafior",
                            Price = 8.9900000000000002
                        },
                        new
                        {
                            Id = 5,
                            Name = "cukinia",
                            Price = 7.5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
