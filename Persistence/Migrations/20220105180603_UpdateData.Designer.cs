﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220105180603_UpdateData")]
    partial class UpdateData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Domain.Channel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Channels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9c6183f0-c3f6-40a5-9899-0768a8170b87"),
                            Description = "Description 1",
                            Name = "Channel 1"
                        },
                        new
                        {
                            Id = new Guid("2bcd62de-9724-4ea7-8c07-0b0c4e2d4409"),
                            Description = "Description 2",
                            Name = "Channel 2"
                        },
                        new
                        {
                            Id = new Guid("cbf09cb0-a44b-4f9a-9d95-e4a3610147cf"),
                            Description = "Description 3",
                            Name = "Channel 3"
                        },
                        new
                        {
                            Id = new Guid("6cac539c-2f6d-47d2-9f78-a26ea42ab334"),
                            Description = "Description 4",
                            Name = "Channel 4"
                        },
                        new
                        {
                            Id = new Guid("feb35746-44f4-47b2-a1e6-008333bcddf1"),
                            Description = "Description 5",
                            Name = "Channel 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}