﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nursery.Data;

namespace Nursery.Data.Migrations
{
    [DbContext(typeof(NurseryContext))]
    partial class NurseryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Nursery.Data.Entities.AntType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("AntTypes");
                });

            modelBuilder.Entity("Nursery.Data.Entities.Eggs", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DueDate");

                    b.Property<int>("Quantity");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Eggs");
                });
#pragma warning restore 612, 618
        }
    }
}
