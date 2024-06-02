﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication5.Data;

#nullable disable

namespace WebApplication5.Migrations.RailwayDb
{
    [DbContext(typeof(RailwayDbContext))]
    [Migration("20240602075125_NumberOfTracks-added-RailwaysStations")]
    partial class NumberOfTracksaddedRailwaysStations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication5.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256)");

                    b.Property<int?>("NumberOfTracks")
                        .HasColumnType("int");

                    b.Property<string>("StationCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RailwayStations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Nellore,Andrapradesh",
                            Name = "NelloreRst",
                            StationCode = "523434"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
