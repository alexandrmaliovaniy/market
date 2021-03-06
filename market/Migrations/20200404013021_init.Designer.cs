﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using market.Models;

namespace market.Migrations
{
    [DbContext(typeof(ClothesContext))]
    [Migration("20200404013021_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("market.Models.Clothes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("imageSrc")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("material")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar(250)");

                    b.HasKey("id");

                    b.ToTable("Cloth");
                });
#pragma warning restore 612, 618
        }
    }
}
