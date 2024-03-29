﻿// <auto-generated />
using System;
using KoolehPoshti.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KoolehPoshti.Migrations
{
    [DbContext(typeof(KoolehPoshtiContext))]
    partial class KoolehPoshtiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KoolehPoshti.Models.Package", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<Guid>("PackageCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackageCategoryId");

                    b.ToTable("Packages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("78318166-6992-43c7-9cd7-15ac39229391"),
                            IsVisible = true,
                            PackageCategoryId = new Guid("31679b51-c5a6-4691-b8eb-d59ad5bd7bd9"),
                            Title = "First Package"
                        });
                });

            modelBuilder.Entity("KoolehPoshti.Models.PackageCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PackageCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("31679b51-c5a6-4691-b8eb-d59ad5bd7bd9"),
                            Name = "One",
                            Title = "یک"
                        });
                });

            modelBuilder.Entity("KoolehPoshti.Models.PackageImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("PackageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.ToTable("PackageImages");
                });

            modelBuilder.Entity("KoolehPoshti.Models.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PackageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RequesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TravelerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PackageId")
                        .IsUnique();

                    b.HasIndex("RequesterId");

                    b.HasIndex("TravelerId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("KoolehPoshti.Models.Requester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelegramId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsAppNumnber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Requesters");
                });

            modelBuilder.Entity("KoolehPoshti.Models.Traveler", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelegramId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TravelDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhatsAppNumnber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Travelers");
                });

            modelBuilder.Entity("KoolehPoshti.Models.Package", b =>
                {
                    b.HasOne("KoolehPoshti.Models.PackageCategory", "Category")
                        .WithMany("Packages")
                        .HasForeignKey("PackageCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KoolehPoshti.Models.PackageImage", b =>
                {
                    b.HasOne("KoolehPoshti.Models.Package", "Package")
                        .WithMany("Images")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Package");
                });

            modelBuilder.Entity("KoolehPoshti.Models.Request", b =>
                {
                    b.HasOne("KoolehPoshti.Models.Package", "Package")
                        .WithOne("Request")
                        .HasForeignKey("KoolehPoshti.Models.Request", "PackageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("KoolehPoshti.Models.Requester", "Requester")
                        .WithMany("Requests")
                        .HasForeignKey("RequesterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("KoolehPoshti.Models.Traveler", "Traveler")
                        .WithMany("Requests")
                        .HasForeignKey("TravelerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Requester");

                    b.Navigation("Traveler");
                });

            modelBuilder.Entity("KoolehPoshti.Models.Package", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Request")
                        .IsRequired();
                });

            modelBuilder.Entity("KoolehPoshti.Models.PackageCategory", b =>
                {
                    b.Navigation("Packages");
                });

            modelBuilder.Entity("KoolehPoshti.Models.Requester", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("KoolehPoshti.Models.Traveler", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
