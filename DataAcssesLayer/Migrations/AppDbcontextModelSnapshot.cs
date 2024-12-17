﻿// <auto-generated />
using DataAcssesLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAcssesLayer.Migrations
{
    [DbContext(typeof(AppDbcontext))]
    partial class AppDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAcssesLayer.Repositoryes.InterFases.City", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CityName")
                        .HasColumnType("int");

                    b.Property<string>("Distance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("DataAcssesLayer.Repositoryes.InterFases.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityCode")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHagigi")
                        .HasColumnType("bit");

                    b.Property<string>("Landlinephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Noehmalekiyat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tablo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("CityId");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("Domain.Border", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("BorderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Borderdistance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KollId")
                        .HasColumnType("int");

                    b.Property<int>("MoinId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Border");
                });

            modelBuilder.Entity("Domain.CodeingKoll", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("AccoungGrop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AccountStatuseIsBebtor")
                        .HasColumnType("bit");

                    b.Property<int>("CodeKoll")
                        .HasColumnType("int");

                    b.Property<string>("Explain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KollName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CodeingKoll");
                });

            modelBuilder.Entity("Domain.CodingGrohTafsili", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CodingGrohTafsili");
                });

            modelBuilder.Entity("Domain.CodingMoin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adrees")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CodeKoll")
                        .HasColumnType("int");

                    b.Property<int>("CodeMoin")
                        .HasColumnType("int");

                    b.Property<string>("Expalein")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KollName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoinName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StatuseIsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TafsiliGropId")
                        .HasColumnType("int");

                    b.Property<string>("TafsiliGropName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CodingMoind");
                });

            modelBuilder.Entity("Domain.CodingTafsili", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CodeTafsili")
                        .HasColumnType("int");

                    b.Property<string>("Explain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GropTafsiliCode")
                        .HasColumnType("int");

                    b.Property<string>("GropTafsiliName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TafsiliName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TafsiliStatusIaActive")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("CodingTafsili");
                });

            modelBuilder.Entity("Domain.Drivers", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CarNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsIraqi")
                        .HasColumnType("bit");

                    b.Property<int>("KollId")
                        .HasColumnType("int");

                    b.Property<int>("MoinId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Domain.Farmers", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("EachKiloPrice")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sarh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("autherprices")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("sardkhaneprice")
                        .HasColumnType("int");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("farmers");
                });

            modelBuilder.Entity("Domain.Kala", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("KalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KollId")
                        .HasColumnType("int");

                    b.Property<int>("MabnayeMohasebat")
                        .HasColumnType("int");

                    b.Property<int>("MoinId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("VahedMoayan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vahedjoz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kalas");
                });

            modelBuilder.Entity("Domain.TarkhisKar", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsIraqi")
                        .HasColumnType("bit");

                    b.Property<int>("KollId")
                        .HasColumnType("int");

                    b.Property<int>("MoinId")
                        .HasColumnType("int");

                    b.Property<string>("TarkisKarHazine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarkisKarMojavez")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarkisKarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TarkhisKars");
                });

            modelBuilder.Entity("Domain.sardkhane", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("sardkhane");
                });

            modelBuilder.Entity("DataAcssesLayer.Repositoryes.InterFases.Customer", b =>
                {
                    b.HasOne("DataAcssesLayer.Repositoryes.InterFases.City", "City")
                        .WithMany("Customers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("DataAcssesLayer.Repositoryes.InterFases.City", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
