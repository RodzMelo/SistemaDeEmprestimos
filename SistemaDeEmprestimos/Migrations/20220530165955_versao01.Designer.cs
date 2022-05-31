﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDeEmprestimos.Data;

namespace SistemaDeEmprestimos.Migrations
{
    [DbContext(typeof(SistemaDeEmprestimosContext))]
    [Migration("20220530165955_versao01")]
    partial class versao01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaDeEmprestimos.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RendaMensal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusEmprestimo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaDeEmprestimos.Models.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEmprestimo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Devolvido")
                        .HasColumnType("bit");

                    b.Property<int>("DiaVencimento")
                        .HasColumnType("int");

                    b.Property<double>("QuantidadeParcelas")
                        .HasColumnType("float");

                    b.Property<double>("ValorEmprestimo")
                        .HasColumnType("float");

                    b.Property<double>("ValorJuros")
                        .HasColumnType("float");

                    b.Property<double>("ValorParcela")
                        .HasColumnType("float");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float");

                    b.HasKey("EmprestimoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Emprestimo");
                });

            modelBuilder.Entity("SistemaDeEmprestimos.Models.Parcela", b =>
                {
                    b.Property<int>("ParcelaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DiaVencimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmprestimoId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroParcela")
                        .HasColumnType("int");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<double>("ValorParcela")
                        .HasColumnType("float");

                    b.HasKey("ParcelaId");

                    b.HasIndex("EmprestimoId");

                    b.ToTable("Parcela");
                });

            modelBuilder.Entity("SistemaDeEmprestimos.Models.Emprestimo", b =>
                {
                    b.HasOne("SistemaDeEmprestimos.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SistemaDeEmprestimos.Models.Parcela", b =>
                {
                    b.HasOne("SistemaDeEmprestimos.Models.Emprestimo", "Emprestimo")
                        .WithMany()
                        .HasForeignKey("EmprestimoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Emprestimo");
                });
#pragma warning restore 612, 618
        }
    }
}