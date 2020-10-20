﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProjectV1.Models;

namespace TermProjectV1.Migrations
{
    [DbContext(typeof(TrackerContext))]
    partial class TrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TermProjectV1.Models.Details", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<DateTime>("detailDate")
                        .HasColumnName("Date Enrolled")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("MemberID");

                    b.ToTable("Statistics");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            MemberID = 1,
                            age = 34,
                            detailDate = new DateTime(2020, 10, 20, 19, 13, 58, 856, DateTimeKind.Local).AddTicks(83)
                        },
                        new
                        {
                            ID = 2,
                            MemberID = 2,
                            age = 31,
                            detailDate = new DateTime(2020, 10, 20, 19, 13, 58, 859, DateTimeKind.Local).AddTicks(85)
                        },
                        new
                        {
                            ID = 3,
                            MemberID = 3,
                            age = 37,
                            detailDate = new DateTime(2020, 10, 20, 19, 13, 58, 859, DateTimeKind.Local).AddTicks(85)
                        });
                });

            modelBuilder.Entity("TermProjectV1.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("cell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnName("Member Full Name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("zip")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Membership");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            name = "Tim Largent"
                        },
                        new
                        {
                            ID = 2,
                            email = "mlehr@mail.com",
                            name = "Max Lehr"
                        },
                        new
                        {
                            ID = 3,
                            name = "Brett Macki"
                        });
                });

            modelBuilder.Entity("TermProjectV1.Models.Reference", b =>
                {
                    b.Property<int>("ReferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferenceId");

                    b.ToTable("References");

                    b.HasData(
                        new
                        {
                            ReferenceId = 1,
                            ID = 2,
                            Name = "Brett Macki"
                        },
                        new
                        {
                            ReferenceId = 2,
                            ID = 3,
                            Name = "Tim Largent"
                        },
                        new
                        {
                            ReferenceId = 3,
                            ID = 1,
                            Name = "Max Lehr"
                        });
                });

            modelBuilder.Entity("TermProjectV1.Models.Details", b =>
                {
                    b.HasOne("TermProjectV1.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
