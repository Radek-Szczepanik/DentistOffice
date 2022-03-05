﻿// <auto-generated />
using System;
using DentistOffice.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DentistOffice.DataAccess.Migrations
{
    [DbContext(typeof(DentistOfficeContext))]
    partial class DentistOfficeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

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

                    b.HasIndex("UserId")
                        .IsUnique();

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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserAddress", b =>
                {
                    b.HasOne("DentistOffice.DataAccess.Entities.User", "User")
                        .WithOne("UserAddress")
                        .HasForeignKey("DentistOffice.DataAccess.Entities.UserAddress", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserCard", b =>
                {
                    b.HasOne("DentistOffice.DataAccess.Entities.User", "User")
                        .WithOne("UserCard")
                        .HasForeignKey("DentistOffice.DataAccess.Entities.UserCard", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserContact", b =>
                {
                    b.HasOne("DentistOffice.DataAccess.Entities.User", "User")
                        .WithOne("UserContact")
                        .HasForeignKey("DentistOffice.DataAccess.Entities.UserContact", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.User", b =>
                {
                    b.Navigation("UserAddress");

                    b.Navigation("UserCard");

                    b.Navigation("UserContact");
                });
#pragma warning restore 612, 618
        }
    }
}
