// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220105161227_SeedData")]
    partial class SeedData
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
                            Id = new Guid("5da78997-32ad-4846-b682-3f3110ce2aa1"),
                            Description = "Channel 1",
                            Name = "Channel 1"
                        },
                        new
                        {
                            Id = new Guid("33cbf403-39c4-48d0-a41a-ef35cbfc372f"),
                            Description = "Channel 2",
                            Name = "Channel 2"
                        },
                        new
                        {
                            Id = new Guid("729fafeb-615d-4384-876a-04ea11e09153"),
                            Description = "Channel 3",
                            Name = "Channel 3"
                        },
                        new
                        {
                            Id = new Guid("4ba0e071-966d-48f9-8559-a6e3850a3515"),
                            Description = "Channel 4",
                            Name = "Channel 4"
                        },
                        new
                        {
                            Id = new Guid("f878f08e-07b0-4eb5-b9e0-b3277d187250"),
                            Description = "Channel 5",
                            Name = "Channel 5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
