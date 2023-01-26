﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaApp.Server.DAL;

#nullable disable

namespace PizzaApp.Server.DAL.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20230115214519_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.Category", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("ID");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("address2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("city");

                    b.Property<string>("CompanyLogo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_logo");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("company_name");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("modified_by");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified_date");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("state");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("zip");

                    b.HasKey("ID");

                    b.ToTable("company", (string)null);
                });

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.Item", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long?>("CategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("items", (string)null);
                });

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<int>("UserRole")
                        .HasColumnType("int")
                        .HasColumnName("user_role");

                    b.HasKey("ID");

                    b.ToTable("roles", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "User",
                            UserRole = 0
                        },
                        new
                        {
                            ID = 2,
                            Name = "Admin",
                            UserRole = 1
                        },
                        new
                        {
                            ID = 3,
                            Name = "SuperAdmin",
                            UserRole = 2
                        });
                });

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("deleted_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_deleted");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modified_date");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("profile_picture");

                    b.Property<int>("RoleID")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.Item", b =>
                {
                    b.HasOne("PizzaApp.Server.DAL.Models.Category", null)
                        .WithMany("Items")
                        .HasForeignKey("CategoryID");
                });

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.User", b =>
                {
                    b.HasOne("PizzaApp.Server.DAL.Models.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("PizzaApp.Server.DAL.Models.Role", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
