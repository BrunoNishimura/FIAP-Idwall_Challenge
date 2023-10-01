﻿// <auto-generated />
using System;
using FIAP_Idwall.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FIAP_Idwall.Persistence.Migrations
{
    [DbContext(typeof(FIAP_IdwallContext))]
    [Migration("20231001203057_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("FIAP_Idwall.Domain.FiapIdwall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fullname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nationality")
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FiapIdwalls");
                });

            modelBuilder.Entity("FIAP_Idwall.Domain.ModelFbi", b =>
                {
                    b.Property<int>("FbiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FbiDateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FbiDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("FbiFullname")
                        .HasColumnType("TEXT");

                    b.Property<string>("FbiPictureUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("FbiId");

                    b.ToTable("ModelFbis");
                });

            modelBuilder.Entity("FIAP_Idwall.Domain.ModelInterpol", b =>
                {
                    b.Property<int>("InterpolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("InterpolDateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("InterpolDetails")
                        .HasColumnType("TEXT");

                    b.Property<string>("InterpolFullname")
                        .HasColumnType("TEXT");

                    b.Property<string>("InterpolNationality")
                        .HasColumnType("TEXT");

                    b.Property<string>("InterpolPictureUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("InterpolId");

                    b.ToTable("ModelInterpols");
                });
#pragma warning restore 612, 618
        }
    }
}
