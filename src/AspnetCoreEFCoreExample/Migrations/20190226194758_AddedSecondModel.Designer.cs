﻿// <auto-generated />
using AspnetCoreEFCoreExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AspnetCoreEFCoreExample.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20190226194758_AddedSecondModel")]
    partial class AddedSecondModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspnetCoreEFCoreExample.Models.MyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("SecondModelId");

                    b.HasKey("Id");

                    b.HasIndex("SecondModelId");

                    b.ToTable("MyModels");
                });

            modelBuilder.Entity("AspnetCoreEFCoreExample.Models.MySecondModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MySecondModel");
                });

            modelBuilder.Entity("AspnetCoreEFCoreExample.Models.MyModel", b =>
                {
                    b.HasOne("AspnetCoreEFCoreExample.Models.MySecondModel", "SecondModel")
                        .WithMany()
                        .HasForeignKey("SecondModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
