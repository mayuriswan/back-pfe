﻿// <auto-generated />
using System;
using System.Collections.Generic;
using API_Iresen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace API_Iresen.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240713175658_6th")]
    partial class _6th
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("API_Iresen.Models.Champ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<List<string>>("Choices")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<int?>("EtapeId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EtapeId");

                    b.ToTable("Champs");
                });

            modelBuilder.Entity("API_Iresen.Models.Etape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("FormulaireId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FormulaireId");

                    b.ToTable("Etapes");
                });

            modelBuilder.Entity("API_Iresen.Models.Evaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BaseDeNotation")
                        .HasColumnType("integer");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("API_Iresen.Models.EvaluationCriterion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Criterion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EvaluationId")
                        .HasColumnType("integer");

                    b.Property<int>("Note")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EvaluationId");

                    b.ToTable("EvaluationCriterion");
                });

            modelBuilder.Entity("API_Iresen.Models.EvaluationForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EvaluationForms");
                });

            modelBuilder.Entity("API_Iresen.Models.FormField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Options")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StepId")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StepId");

                    b.ToTable("FormFields");
                });

            modelBuilder.Entity("API_Iresen.Models.FormFieldValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Options")
                        .HasColumnType("text");

                    b.Property<int>("StepValueId")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StepValueId");

                    b.ToTable("FormFieldValues");
                });

            modelBuilder.Entity("API_Iresen.Models.Formulaire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Formulaires");
                });

            modelBuilder.Entity("API_Iresen.Models.Hostinginstitution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Hostinginstitutions");
                });

            modelBuilder.Entity("API_Iresen.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AcceptedSubmissions")
                        .HasColumnType("integer");

                    b.Property<List<string>>("AuthorizedCountries")
                        .HasColumnType("text[]");

                    b.Property<int?>("Budget")
                        .HasColumnType("integer");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("ClosingDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DocumentPath")
                        .HasColumnType("text");

                    b.Property<int?>("EvaluationFormId")
                        .HasColumnType("integer");

                    b.Property<List<int>>("Evaluators")
                        .HasColumnType("integer[]");

                    b.Property<int?>("HostingInstitutionId")
                        .HasColumnType("integer");

                    b.Property<bool?>("IsDraft")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsPublic")
                        .HasColumnType("boolean");

                    b.Property<int?>("MaxDuration")
                        .HasColumnType("integer");

                    b.Property<int?>("MinDuration")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("NombreSubmissions")
                        .HasColumnType("integer");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("text");

                    b.Property<int?>("PostBudget")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("PublicationDate")
                        .HasColumnType("date");

                    b.Property<int?>("ResponsiblePersonId")
                        .HasColumnType("integer");

                    b.Property<bool?>("SeparateBudget")
                        .HasColumnType("boolean");

                    b.Property<int?>("TaskTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EvaluationFormId");

                    b.HasIndex("HostingInstitutionId");

                    b.HasIndex("TaskTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("API_Iresen.Models.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EvaluationFormId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EvaluationFormId");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("API_Iresen.Models.StepValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SubmissionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SubmissionId");

                    b.ToTable("StepValues");
                });

            modelBuilder.Entity("API_Iresen.Models.Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("API_Iresen.Tasktype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Tasktypes");
                });

            modelBuilder.Entity("API_Iresen.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API_Iresen.Models.Champ", b =>
                {
                    b.HasOne("API_Iresen.Models.Etape", null)
                        .WithMany("Champs")
                        .HasForeignKey("EtapeId");
                });

            modelBuilder.Entity("API_Iresen.Models.Etape", b =>
                {
                    b.HasOne("API_Iresen.Models.Formulaire", null)
                        .WithMany("Etapes")
                        .HasForeignKey("FormulaireId");
                });

            modelBuilder.Entity("API_Iresen.Models.Evaluation", b =>
                {
                    b.HasOne("API_Iresen.Models.Project", null)
                        .WithMany("Evaluations")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("API_Iresen.Models.EvaluationCriterion", b =>
                {
                    b.HasOne("API_Iresen.Models.Evaluation", "Evaluation")
                        .WithMany("Criteria")
                        .HasForeignKey("EvaluationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evaluation");
                });

            modelBuilder.Entity("API_Iresen.Models.FormField", b =>
                {
                    b.HasOne("API_Iresen.Models.Step", null)
                        .WithMany("Fields")
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_Iresen.Models.FormFieldValue", b =>
                {
                    b.HasOne("API_Iresen.Models.StepValue", "StepValue")
                        .WithMany("Fields")
                        .HasForeignKey("StepValueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StepValue");
                });

            modelBuilder.Entity("API_Iresen.Models.Project", b =>
                {
                    b.HasOne("API_Iresen.Models.EvaluationForm", "EvaluationForm")
                        .WithMany()
                        .HasForeignKey("EvaluationFormId");

                    b.HasOne("API_Iresen.Models.Hostinginstitution", "HostingInstitution")
                        .WithMany()
                        .HasForeignKey("HostingInstitutionId");

                    b.HasOne("API_Iresen.Tasktype", "TaskType")
                        .WithMany()
                        .HasForeignKey("TaskTypeId");

                    b.HasOne("API_Iresen.User", null)
                        .WithMany("ProjectsToEvaluate")
                        .HasForeignKey("UserId");

                    b.Navigation("EvaluationForm");

                    b.Navigation("HostingInstitution");

                    b.Navigation("TaskType");
                });

            modelBuilder.Entity("API_Iresen.Models.Step", b =>
                {
                    b.HasOne("API_Iresen.Models.EvaluationForm", null)
                        .WithMany("Steps")
                        .HasForeignKey("EvaluationFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_Iresen.Models.StepValue", b =>
                {
                    b.HasOne("API_Iresen.Models.Submission", "Submission")
                        .WithMany("StepValues")
                        .HasForeignKey("SubmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Submission");
                });

            modelBuilder.Entity("API_Iresen.Models.Submission", b =>
                {
                    b.HasOne("API_Iresen.Models.Project", "Project")
                        .WithMany("Submissions")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Iresen.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("API_Iresen.Models.Etape", b =>
                {
                    b.Navigation("Champs");
                });

            modelBuilder.Entity("API_Iresen.Models.Evaluation", b =>
                {
                    b.Navigation("Criteria");
                });

            modelBuilder.Entity("API_Iresen.Models.EvaluationForm", b =>
                {
                    b.Navigation("Steps");
                });

            modelBuilder.Entity("API_Iresen.Models.Formulaire", b =>
                {
                    b.Navigation("Etapes");
                });

            modelBuilder.Entity("API_Iresen.Models.Project", b =>
                {
                    b.Navigation("Evaluations");

                    b.Navigation("Submissions");
                });

            modelBuilder.Entity("API_Iresen.Models.Step", b =>
                {
                    b.Navigation("Fields");
                });

            modelBuilder.Entity("API_Iresen.Models.StepValue", b =>
                {
                    b.Navigation("Fields");
                });

            modelBuilder.Entity("API_Iresen.Models.Submission", b =>
                {
                    b.Navigation("StepValues");
                });

            modelBuilder.Entity("API_Iresen.User", b =>
                {
                    b.Navigation("ProjectsToEvaluate");
                });
#pragma warning restore 612, 618
        }
    }
}
