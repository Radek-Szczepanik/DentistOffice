﻿// <auto-generated />
using System;
using DentistOffice.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DentistOffice.DataAccess.Migrations
{
    [DbContext(typeof(DentistOfficeContext))]
    [Migration("20220220071314_ChangeRelationsInDb")]
    partial class ChangeRelationsInDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("UserAddressId")
                        .HasColumnType("int");

                    b.Property<int>("UserContactId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserAddressId")
                        .IsUnique();

                    b.HasIndex("UserContactId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BodyTemperature")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsAllergy")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCough")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDiabetes")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHeartDiseases")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHypertension")
                        .HasColumnType("bit");

                    b.Property<bool>("IsJaundice")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPregnancy")
                        .HasColumnType("bit");

                    b.Property<bool>("IsQuarantine")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserCards");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.User", b =>
                {
                    b.HasOne("DentistOffice.DataAccess.Entities.UserAddress", "UserAddress")
                        .WithOne("User")
                        .HasForeignKey("DentistOffice.DataAccess.Entities.User", "UserAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistOffice.DataAccess.Entities.UserContact", "UserContact")
                        .WithOne("User")
                        .HasForeignKey("DentistOffice.DataAccess.Entities.User", "UserContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAddress");

                    b.Navigation("UserContact");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserCard", b =>
                {
                    b.HasOne("DentistOffice.DataAccess.Entities.User", "User")
                        .WithMany("UserCards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.User", b =>
                {
                    b.Navigation("UserCards");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserAddress", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserContact", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}