﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillsWebApp.Data;

namespace SkillsWebApp.Migrations
{
    [DbContext(typeof(SkillContext))]
    [Migration("20180919121520_teamlist")]
    partial class teamlist
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Moserware.Skills.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName");

                    b.Property<double>("PartialPlayPercentage");

                    b.Property<double>("PartialUpdatePercentage");

                    b.Property<string>("PlayfabId");

                    b.Property<int?>("RatingId");

                    b.HasKey("Id");

                    b.HasIndex("PlayfabId")
                        .IsUnique()
                        .HasFilter("[PlayfabId] IS NOT NULL");

                    b.HasIndex("RatingId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Moserware.Skills.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Mean");

                    b.Property<double>("StandardDeviation");

                    b.HasKey("Id");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Moserware.Skills.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Moserware.Skills.Player", b =>
                {
                    b.HasOne("Moserware.Skills.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId");
                });
#pragma warning restore 612, 618
        }
    }
}