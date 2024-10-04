﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGMed.Dados;

#nullable disable

namespace SGMed.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241004144815_Migracao1")]
    partial class Migracao1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("SGMed.Models.ClienteModel", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("DataNascimento")
                        .HasColumnType("int");

                    b.Property<string>("EnderecoCliente")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdCliente");

                    b.ToTable("Tb_Cliente");
                });

            modelBuilder.Entity("SGMed.Models.EmpresaModel", b =>
                {
                    b.Property<int>("IdEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdEmpresa"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EnderecoEmpresa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEmpresa");

                    b.ToTable("Tb_Empresa");
                });

            modelBuilder.Entity("SGMed.Models.ExameModel", b =>
                {
                    b.Property<int>("IdExame")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("IdExame"));

                    b.Property<string>("DescricaoExame")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdExame");

                    b.ToTable("Tb_Exame");
                });
#pragma warning restore 612, 618
        }
    }
}
