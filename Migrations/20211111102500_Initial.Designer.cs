﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test_task_deliver_RyndychRD;

namespace test_task_deliver_RyndychRD.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20211111102500_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("test_task_deliver_RyndychRD.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("package_pickupDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("package_weight")
                        .HasColumnType("real");

                    b.Property<string>("receiver_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("receiver_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
