﻿// <auto-generated />
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    partial class DatabaseTaskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Core.Domain.galerii", b =>
                {
                    b.Property<string>("Nimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Aadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lahtiolek")
                        .HasColumnType("int");

                    b.Property<string>("Omanik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Töötajad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nimi");

                    b.ToTable("galerii");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.klient", b =>
                {
                    b.Property<string>("EesNimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Aadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PereNimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telnr")
                        .HasColumnType("int");

                    b.HasKey("EesNimi");

                    b.ToTable("kleint");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.kunstiteos", b =>
                {
                    b.Property<string>("Nimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Aasta")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hind")
                        .HasColumnType("int");

                    b.Property<string>("Paritolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tüüp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nimi");

                    b.ToTable("kunstiteos");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.kunstnik", b =>
                {
                    b.Property<string>("EesNimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Aadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PereNimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telnr")
                        .HasColumnType("int");

                    b.HasKey("EesNimi");

                    b.ToTable("Kunstnik");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.maal", b =>
                {
                    b.Property<string>("Nimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Aasta")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hind")
                        .HasColumnType("int");

                    b.Property<string>("Paritolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tuup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nimi");

                    b.ToTable("maal");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.omanik", b =>
                {
                    b.Property<string>("EesNimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Aadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PereNimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telnr")
                        .HasColumnType("int");

                    b.HasKey("EesNimi");

                    b.ToTable("omanik");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.skulptuur", b =>
                {
                    b.Property<string>("Nimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Aasta")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hind")
                        .HasColumnType("int");

                    b.Property<string>("Paritolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tüüp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Nimi");

                    b.ToTable("skulptuur");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.tootaja", b =>
                {
                    b.Property<string>("EesNimi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Aadress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PereNimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telnr")
                        .HasColumnType("int");

                    b.HasKey("EesNimi");

                    b.ToTable("tootaja");
                });
#pragma warning restore 612, 618
        }
    }
}
