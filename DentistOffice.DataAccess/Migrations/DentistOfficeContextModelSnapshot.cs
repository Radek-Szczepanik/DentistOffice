﻿// <auto-generated />
using System;
using DentistOffice.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserAddressId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserContactId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MyProperty");

                    b.HasIndex("UserAddressId")
                        .IsUnique();

                    b.HasIndex("UserCardId")
                        .IsUnique();

                    b.HasIndex("UserContactId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserAddress", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("MyProperty");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserCard", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BodyTemperature")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAllergy")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCough")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDiabetes")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHeartDiseases")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHypertension")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsJaundice")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPregnancy")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsQuarantine")
                        .HasColumnType("INTEGER");

                    b.HasKey("MyProperty");

                    b.ToTable("UserCards");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserContact", b =>
                {
                    b.Property<int>("MyProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("MyProperty");

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.User", b =>
                {
                    b.HasOne("DentistOffice.DataAccess.Entities.UserAddress", "UserAddress")
                        .WithOne("User")
                        .HasForeignKey("DentistOffice.DataAccess.Entities.User", "UserAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistOffice.DataAccess.Entities.UserCard", "UserCard")
                        .WithOne("User")
                        .HasForeignKey("DentistOffice.DataAccess.Entities.User", "UserCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentistOffice.DataAccess.Entities.UserContact", "UserContact")
                        .WithOne("User")
                        .HasForeignKey("DentistOffice.DataAccess.Entities.User", "UserContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAddress");

                    b.Navigation("UserCard");

                    b.Navigation("UserContact");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserAddress", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("DentistOffice.DataAccess.Entities.UserCard", b =>
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
