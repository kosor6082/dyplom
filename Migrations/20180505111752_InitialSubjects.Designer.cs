﻿// <auto-generated />
using ElectronicJournal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ElectronicJournal.Migrations
{
    [DbContext(typeof(ElectronicJournalContext))]
    [Migration("20180505111752_InitialSubjects")]
    partial class InitialSubjects
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ElectronicJournal.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ElectronicJournal.Models.Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SubjectName");

                    b.Property<string>("Teacher");

                    b.HasKey("ID");

                    b.ToTable("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}