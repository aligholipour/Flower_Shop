﻿// <auto-generated />
using Flower_Shop.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Flower_Shop.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("13971002191013_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("Flower_Shop.Models.Entities.Flower", b =>
                {
                    b.Property<int>("FlowerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("FlowerId");

                    b.ToTable("Flowers");
                });
#pragma warning restore 612, 618
        }
    }
}
