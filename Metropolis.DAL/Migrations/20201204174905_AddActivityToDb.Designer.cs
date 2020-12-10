﻿// <auto-generated />
using Metropolis.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Metropolis.Dal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201204174905_AddActivityToDb")]
    partial class AddActivityToDb
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
                    b.Property<int>("activityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("activityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("activityId");

                    b.ToTable("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
