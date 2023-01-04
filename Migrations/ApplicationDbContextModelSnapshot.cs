﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NguyenTungSon999.Data;

#nullable disable

namespace NguyenTungSon999.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("NguyenTungSon999.Models.UniversityNTS999", b =>
                {
                    b.Property<string>("UniversityId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UniversityId");

                    b.ToTable("UniversityNTS999");
                });
#pragma warning restore 612, 618
        }
    }
}