﻿// <auto-generated />
using System;
using EntityFrameworkCore.Jet.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestSearchApplication.Data;

#nullable disable

namespace TestSearchApplication.Migrations
{
    [DbContext(typeof(DataMSAccessContext))]
    [Migration("20240505111827_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Jet:ValueGenerationStrategy", JetValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestSearchApplication.Models.B010105", b =>
                {
                    b.Property<int?>("Hno")
                        .HasColumnType("integer");

                    b.Property<int?>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int?>("Mno")
                        .HasColumnType("integer")
                        .HasColumnName("MNO");

                    b.Property<string>("Nass")
                        .HasColumnType("longchar")
                        .HasColumnName("nass");

                    b.Property<string>("Nassx")
                        .HasColumnType("longchar")
                        .HasColumnName("NASSX");

                    b.Property<int?>("Page")
                        .HasColumnType("integer")
                        .HasColumnName("page");

                    b.Property<int?>("Part")
                        .HasColumnType("integer")
                        .HasColumnName("part");

                    b.Property<string>("TabNo")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<double?>("Tno")
                        .HasColumnType("double");

                    b.HasIndex(new[] { "Mno" }, "MNO");

                    b.HasIndex(new[] { "Tno" }, "Tno");

                    b.ToTable("b010105", (string)null);
                });

            modelBuilder.Entity("TestSearchApplication.Models.Tab", b =>
                {
                    b.Property<int>("Mno")
                        .HasColumnType("integer")
                        .HasColumnName("MNO");

                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("counter")
                        .HasColumnName("ID")
                        .HasAnnotation("Jet:ValueGenerationStrategy", JetValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MhNass")
                        .HasColumnType("longchar")
                        .HasColumnName("MH_Nass");

                    b.Property<bool?>("Mtn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("MTN")
                        .HasDefaultValueSql("No");

                    b.Property<int?>("Musnad")
                        .HasColumnType("integer")
                        .HasColumnName("MUSNAD");

                    b.Property<string>("Nassx")
                        .HasColumnType("longchar")
                        .HasColumnName("NASSX");

                    b.Property<bool?>("Tmam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("No");

                    b.HasKey("Mno")
                        .HasName("PrimaryKey");

                    b.HasIndex(new[] { "Id" }, "ID")
                        .IsUnique()
                        .HasFilter("IGNORE NULL");

                    b.HasIndex(new[] { "Mno" }, "MNO")
                        .IsUnique();

                    b.HasIndex(new[] { "Musnad" }, "MUSNAD");

                    b.ToTable("TAB", (string)null);
                });

            modelBuilder.Entity("TestSearchApplication.Models.B010105", b =>
                {
                    b.HasOne("TestSearchApplication.Models.Tab", "MnoNavigation")
                        .WithMany()
                        .HasForeignKey("Mno")
                        .HasConstraintName("TABb010105");

                    b.Navigation("MnoNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
