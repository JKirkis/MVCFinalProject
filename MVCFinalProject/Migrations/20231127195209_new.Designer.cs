﻿// <auto-generated />
using System;
using MVCFinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCFinalProject.Migrations
{
    [DbContext(typeof(GameContext))]
    [Migration("20231127195209_new")]
    partial class @new
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCFinalProject.Models.Game", b =>
                {
                    b.Property<int?>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("GameId"));

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            Developer = "id Software",
                            Genre = "First-person shooter",
                            Name = "Doom",
                            Year = 1993
                        },
                        new
                        {
                            GameId = 2,
                            Developer = "Rare",
                            Genre = "Adventure",
                            Name = "Conker's Bad Fur Day",
                            Year = 2001
                        },
                        new
                        {
                            GameId = 3,
                            Developer = "Blizzard Entertainment",
                            Genre = "MMORPG",
                            Name = "World of Warcraft",
                            Year = 2004
                        },
                        new
                        {
                            GameId = 4,
                            Developer = "Bungie",
                            Genre = "First-person shooter",
                            Name = "Halo",
                            Year = 2001
                        },
                        new
                        {
                            GameId = 5,
                            Developer = "Square",
                            Genre = "Role-playing game",
                            Name = "Final Fantasy 7",
                            Year = 1997
                        },
                        new
                        {
                            GameId = 6,
                            Developer = "NicKyLarry",
                            Genre = "First-person shooter",
                            Name = "Extinction",
                            Year = 2023
                        },
                        new
                        {
                            GameId = 7,
                            Developer = "Bioware",
                            Genre = "Role-playing game",
                            Name = "Mass Effect 3",
                            Year = 2012
                        },
                        new
                        {
                            GameId = 8,
                            Developer = "Don't Nod",
                            Genre = "Adventure",
                            Name = "Life is Strange",
                            Year = 2015
                        },
                        new
                        {
                            GameId = 9,
                            Developer = "LucasArts",
                            Genre = "Adventure",
                            Name = "Day of the Tentacle",
                            Year = 1993
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
