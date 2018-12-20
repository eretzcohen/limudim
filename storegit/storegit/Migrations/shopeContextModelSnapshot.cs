﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using storegit.Models;
using System;

namespace storegit.Migrations
{
    [DbContext(typeof(shopeContext))]
    partial class shopeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("storegit.Models.Adress", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityAddress");

                    b.Property<string>("HomeAdress");

                    b.Property<int>("HomeNamber");

                    b.HasKey("id");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("storegit.Models.orders", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Usersid");

                    b.Property<string>("data");

                    b.HasKey("id");

                    b.HasIndex("Usersid");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("storegit.Models.Products", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Type_of_jewelryid");

                    b.Property<string>("color");

                    b.Property<int?>("ordersid");

                    b.Property<int>("price");

                    b.HasKey("id");

                    b.HasIndex("Type_of_jewelryid");

                    b.HasIndex("ordersid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("storegit.Models.Type_of_jewelry", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Type_of_jewelry");
                });

            modelBuilder.Entity("storegit.Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Adressid");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<int>("phone");

                    b.HasKey("id");

                    b.HasIndex("Adressid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("storegit.Models.orders", b =>
                {
                    b.HasOne("storegit.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("Usersid");
                });

            modelBuilder.Entity("storegit.Models.Products", b =>
                {
                    b.HasOne("storegit.Models.Type_of_jewelry", "Type_of_jewelry")
                        .WithMany()
                        .HasForeignKey("Type_of_jewelryid");

                    b.HasOne("storegit.Models.orders")
                        .WithMany("products")
                        .HasForeignKey("ordersid");
                });

            modelBuilder.Entity("storegit.Models.Users", b =>
                {
                    b.HasOne("storegit.Models.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("Adressid");
                });
#pragma warning restore 612, 618
        }
    }
}
