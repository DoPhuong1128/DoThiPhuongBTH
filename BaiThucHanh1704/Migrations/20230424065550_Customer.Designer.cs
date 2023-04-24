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
    [Migration("20230424065550_Customer")]
    partial class Customer
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

            modelBuilder.Entity("BaiThucHanh1704.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerID");

                    b.HasIndex("FacultyID");

                    b.HasIndex("PostID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BaiThucHanh1704.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeCode");

                    b.HasIndex("FacultyID");

                    b.HasIndex("PostID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BaiThucHanh1704.Models.Faculty", b =>
                {
                    b.Property<string>("FacultyID")
                        .HasColumnType("TEXT");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FacultyID");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("BaiThucHanh1704.Models.Post", b =>
                {
                    b.Property<string>("PostID")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PostID");

                    b.ToTable("Posts");
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

            modelBuilder.Entity("BaiThucHanh1704.Models.Customer", b =>
                {
                    b.HasOne("BaiThucHanh1704.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaiThucHanh1704.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("BaiThucHanh1704.Models.Employee", b =>
                {
                    b.HasOne("BaiThucHanh1704.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BaiThucHanh1704.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Post");
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
