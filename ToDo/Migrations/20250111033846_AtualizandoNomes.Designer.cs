﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToDo.Data;

#nullable disable

namespace ToDo.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20250111033846_AtualizandoNomes")]
    partial class AtualizandoNomes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ToDo.Models.TarefaModel", b =>
                {
                    b.Property<int>("Trf_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Trf_Id"));

                    b.Property<DateTime>("Trf_DataCriacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Trf_DataExpiracao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Trf_NomeUsuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Trf_Registro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Trf_Tarefa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Trf_Id");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
