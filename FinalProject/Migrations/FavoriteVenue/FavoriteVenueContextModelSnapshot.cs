﻿// <auto-generated />
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject.Migrations.FavoriteVenue
{
    [DbContext(typeof(FavoriteVenueContext))]
    partial class FavoriteVenueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProject.Models.FavoriteVenue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FavBar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavPark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavRestaraunt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavStadium")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FavoriteVenues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FavBar = "Pins",
                            FavPark = "Ault Park",
                            FavRestaraunt = "Buca Di Beppo",
                            FavStadium = "Great American Ballpark"
                        },
                        new
                        {
                            Id = 2,
                            FavBar = "Rosedale",
                            FavPark = "Washington Park",
                            FavRestaraunt = "Gomez",
                            FavStadium = "TQL Stadium"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
