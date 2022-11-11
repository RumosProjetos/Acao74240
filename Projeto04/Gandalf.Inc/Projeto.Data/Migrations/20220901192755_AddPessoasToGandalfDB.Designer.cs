﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto.Data;

#nullable disable

namespace Projeto.Data.Migrations
{
    [DbContext(typeof(GandalfContext))]
    [Migration("20220901192755_AddPessoasToGandalfDB")]
    partial class AddPessoasToGandalfDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Projeto.Modelo.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Projeto.Modelo.DetalhesDaVenda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrecoUnitario")
                        .HasColumnType("int");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("Sequencial")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPorItem")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("VendaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("DetalhesDasVendas");
                });

            modelBuilder.Entity("Projeto.Modelo.Estoque", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LojaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeMinima")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LojaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("Projeto.Modelo.Loja", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Ativa")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("Projeto.Modelo.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LojaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NumeroSequencialNota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TipoPagamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ValorTotalPago")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("LojaId");

                    b.HasIndex("TipoPagamentoId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("Projeto.Modelo.Pessoa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cidade")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoEletronico")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Morada")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("NumeroIdentificacaoFiscal")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoa");
                });

            modelBuilder.Entity("Projeto.Modelo.PontoDeVenda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LojaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LojaId");

                    b.ToTable("PontosDeVendas");
                });

            modelBuilder.Entity("Projeto.Modelo.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoBarras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Descontinuado")
                        .HasColumnType("bit");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("QuantidadePorUnidade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UnidadeMedida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Projeto.Modelo.TipoPagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposDePagamentos");
                });

            modelBuilder.Entity("Projeto.Modelo.Venda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataModificacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LojaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PagamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Pago")
                        .HasColumnType("bit");

                    b.Property<Guid?>("PontoDeVendaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UtilizadorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LojaId");

                    b.HasIndex("PagamentoId");

                    b.HasIndex("PontoDeVendaId");

                    b.HasIndex("UtilizadorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Projeto.Modelo.Cliente", b =>
                {
                    b.HasBaseType("Projeto.Modelo.Pessoa");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Projeto.Modelo.Utilizador", b =>
                {
                    b.HasBaseType("Projeto.Modelo.Pessoa");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<Guid>("UtilizadorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasDiscriminator().HasValue("Utilizador");
                });

            modelBuilder.Entity("Projeto.Modelo.DetalhesDaVenda", b =>
                {
                    b.HasOne("Projeto.Modelo.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("Projeto.Modelo.Venda", "Venda")
                        .WithMany("DetalhesDasVendas")
                        .HasForeignKey("VendaId");

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Projeto.Modelo.Estoque", b =>
                {
                    b.HasOne("Projeto.Modelo.Loja", "Loja")
                        .WithMany("Estoques")
                        .HasForeignKey("LojaId");

                    b.HasOne("Projeto.Modelo.Produto", "Produto")
                        .WithMany("Estoques")
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Loja");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Projeto.Modelo.Pagamento", b =>
                {
                    b.HasOne("Projeto.Modelo.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaId");

                    b.HasOne("Projeto.Modelo.TipoPagamento", "TipoPagamento")
                        .WithMany("Pagamentos")
                        .HasForeignKey("TipoPagamentoId");

                    b.Navigation("Loja");

                    b.Navigation("TipoPagamento");
                });

            modelBuilder.Entity("Projeto.Modelo.PontoDeVenda", b =>
                {
                    b.HasOne("Projeto.Modelo.Loja", "Loja")
                        .WithMany("PontoDeVendas")
                        .HasForeignKey("LojaId");

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("Projeto.Modelo.Produto", b =>
                {
                    b.HasOne("Projeto.Modelo.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Projeto.Modelo.Venda", b =>
                {
                    b.HasOne("Projeto.Modelo.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Projeto.Modelo.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaId");

                    b.HasOne("Projeto.Modelo.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId");

                    b.HasOne("Projeto.Modelo.PontoDeVenda", "PontoDeVenda")
                        .WithMany("Vendas")
                        .HasForeignKey("PontoDeVendaId");

                    b.HasOne("Projeto.Modelo.Utilizador", "Utilizador")
                        .WithMany("Vendas")
                        .HasForeignKey("UtilizadorId");

                    b.Navigation("Cliente");

                    b.Navigation("Loja");

                    b.Navigation("Pagamento");

                    b.Navigation("PontoDeVenda");

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("Projeto.Modelo.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Projeto.Modelo.Loja", b =>
                {
                    b.Navigation("Estoques");

                    b.Navigation("PontoDeVendas");
                });

            modelBuilder.Entity("Projeto.Modelo.PontoDeVenda", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Projeto.Modelo.Produto", b =>
                {
                    b.Navigation("Estoques");
                });

            modelBuilder.Entity("Projeto.Modelo.TipoPagamento", b =>
                {
                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("Projeto.Modelo.Venda", b =>
                {
                    b.Navigation("DetalhesDasVendas");
                });

            modelBuilder.Entity("Projeto.Modelo.Cliente", b =>
                {
                    b.Navigation("Vendas");
                });

            modelBuilder.Entity("Projeto.Modelo.Utilizador", b =>
                {
                    b.Navigation("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}