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
    [Migration("20180506153703_EditMissing")]
    partial class EditMissing
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ElectronicJournal.Models.Lesson", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Classroom");

                    b.Property<DateTime>("Date");

                    b.Property<int>("NumberLesson");

                    b.Property<int>("SubjectID");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("ElectronicJournal.Models.Missing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IsMissing");

                    b.Property<int>("LessonID");

                    b.Property<int>("StudentID");

                    b.HasKey("ID");

                    b.HasIndex("LessonID");

                    b.HasIndex("StudentID");

                    b.ToTable("Missing");
                });

            modelBuilder.Entity("ElectronicJournal.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<int?>("LessonID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("LessonID");

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

            modelBuilder.Entity("ElectronicJournal.Models.Lesson", b =>
                {
                    b.HasOne("ElectronicJournal.Models.Subject", "Subject")
                        .WithMany("Lessons")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ElectronicJournal.Models.Missing", b =>
                {
                    b.HasOne("ElectronicJournal.Models.Lesson")
                        .WithMany("Missings")
                        .HasForeignKey("LessonID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ElectronicJournal.Models.Student")
                        .WithMany("Missings")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ElectronicJournal.Models.Student", b =>
                {
                    b.HasOne("ElectronicJournal.Models.Lesson")
                        .WithMany("Students")
                        .HasForeignKey("LessonID");
                });
#pragma warning restore 612, 618
        }
    }
}
