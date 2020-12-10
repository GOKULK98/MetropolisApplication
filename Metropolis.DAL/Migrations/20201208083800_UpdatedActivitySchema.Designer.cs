﻿// <auto-generated />
using System;
using Metropolis.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Metropolis.Dal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201208083800_UpdatedActivitySchema")]
    partial class UpdatedActivitySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Metropolis.DAL.Entities.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternativeStreet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ScheduledDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActivityId");

                    b.ToTable("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
