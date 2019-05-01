﻿// <auto-generated />
using System;
using AdminIB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdminIB.Migrations
{
    [DbContext(typeof(RequestContext))]
    [Migration("20190428101557_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("AdminIB.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<string>("Destination");

                    b.Property<string>("NIMMahasiswa");

                    b.Property<string>("NamaMahasiswa");

                    b.Property<string>("Reason");

                    b.Property<DateTime>("ReturnDate");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Request");
                });
#pragma warning restore 612, 618
        }
    }
}