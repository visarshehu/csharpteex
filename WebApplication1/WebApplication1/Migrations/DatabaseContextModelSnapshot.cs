﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.CyberTruck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<int>("EstimatedDelivery");

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<int?>("OrderBid");

                    b.Property<int?>("OrderBid1");

                    b.Property<int?>("OrderBid2");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("OrderBid");

                    b.HasIndex("OrderBid1");

                    b.HasIndex("OrderBid2");

                    b.ToTable("CyberTruck");
                });

            modelBuilder.Entity("WebApplication1.Models.Order", b =>
                {
                    b.Property<int>("Bid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfOrder");

                    b.HasKey("Bid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebApplication1.Models.TestModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("test");

                    b.HasKey("Id");

                    b.ToTable("TestModels");
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<string>("FirstName")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("FirstName");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebApplication1.Models.CyberTruck", b =>
                {
                    b.HasOne("WebApplication1.Models.Order")
                        .WithMany("Color")
                        .HasForeignKey("OrderBid");

                    b.HasOne("WebApplication1.Models.Order")
                        .WithMany("Id")
                        .HasForeignKey("OrderBid1");

                    b.HasOne("WebApplication1.Models.Order")
                        .WithMany("Model")
                        .HasForeignKey("OrderBid2");
                });
#pragma warning restore 612, 618
        }
    }
}
