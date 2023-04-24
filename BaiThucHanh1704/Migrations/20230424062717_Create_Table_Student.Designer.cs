﻿// <auto-generated />
using BaiThucHanh1704.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThucHanh1704.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230424062717_Create_Table_Student")]
    partial class CreateTableStudent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("BaiThucHanh1704.Models.Address", b =>
                {
                    b.Property<string>("AddressID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressNane")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AddressID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BaiThucHanh1704.Models.Faculty", b =>
                {
                    b.Property<string>("FacultyID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FacultyID");

                    b.ToTable("Facultys");
                });

            modelBuilder.Entity("BaiThucHanh1704.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.HasIndex("AddressID");

                    b.HasIndex("FacultyID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("BaiThucHanh1704.Models.Student", b =>
                {
                    b.HasOne("BaiThucHanh1704.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaiThucHanh1704.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Faculty");
                });
#pragma warning restore 612, 618
        }
    }
}
