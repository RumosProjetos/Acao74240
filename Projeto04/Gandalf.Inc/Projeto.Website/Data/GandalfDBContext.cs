using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Projeto.Website.Models;

namespace Projeto.Website.Data
{
    public partial class GandalfDBContext : DbContext
    {
        public GandalfDBContext()
        {
        }

        public GandalfDBContext(DbContextOptions<GandalfDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; } = null!;
        public virtual DbSet<DetalhesDasVenda> DetalhesDasVendas { get; set; } = null!;
        public virtual DbSet<Estoque> Estoques { get; set; } = null!;
        public virtual DbSet<Loja> Lojas { get; set; } = null!;
        public virtual DbSet<Pagamento> Pagamentos { get; set; } = null!;
        public virtual DbSet<Pessoa> Pessoas { get; set; } = null!;
        public virtual DbSet<PontosDeVenda> PontosDeVendas { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<TiposDePagamento> TiposDePagamentos { get; set; } = null!;
        public virtual DbSet<Venda> Vendas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: REmover daqui
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GandalfDB;Trusted_Connection=True;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<DetalhesDasVenda>(entity =>
            {
                entity.HasIndex(e => e.ProdutoId, "IX_DetalhesDasVendas_ProdutoId");

                entity.HasIndex(e => e.VendaId, "IX_DetalhesDasVendas_VendaId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TotalPorItem).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.DetalhesDasVenda)
                    .HasForeignKey(d => d.ProdutoId);

                entity.HasOne(d => d.Venda)
                    .WithMany(p => p.DetalhesDasVenda)
                    .HasForeignKey(d => d.VendaId);
            });

            modelBuilder.Entity<Estoque>(entity =>
            {
                entity.HasIndex(e => e.LojaId, "IX_Estoques_LojaId");

                entity.HasIndex(e => e.ProdutoId, "IX_Estoques_ProdutoId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Loja)
                    .WithMany(p => p.Estoques)
                    .HasForeignKey(d => d.LojaId);

                entity.HasOne(d => d.Produto)
                    .WithMany(p => p.Estoques)
                    .HasForeignKey(d => d.ProdutoId);
            });

            modelBuilder.Entity<Loja>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Pagamento>(entity =>
            {
                entity.HasIndex(e => e.LojaId, "IX_Pagamentos_LojaId");

                entity.HasIndex(e => e.TipoPagamentoId, "IX_Pagamentos_TipoPagamentoId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ValorTotalPago).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Loja)
                    .WithMany(p => p.Pagamentos)
                    .HasForeignKey(d => d.LojaId);

                entity.HasOne(d => d.TipoPagamento)
                    .WithMany(p => p.Pagamentos)
                    .HasForeignKey(d => d.TipoPagamentoId);
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Cidade).HasMaxLength(50);

                entity.Property(e => e.Discriminator).HasDefaultValueSql("(N'')");

                entity.Property(e => e.EnderecoEletronico).HasMaxLength(150);

                entity.Property(e => e.Morada).HasMaxLength(120);

                entity.Property(e => e.Nome).HasMaxLength(60);

                entity.Property(e => e.NumeroIdentificacaoFiscal).HasMaxLength(9);

                entity.Property(e => e.Telefone).HasMaxLength(9);
            });

            modelBuilder.Entity<PontosDeVenda>(entity =>
            {
                entity.HasIndex(e => e.LojaId, "IX_PontosDeVendas_LojaId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Loja)
                    .WithMany(p => p.PontosDeVenda)
                    .HasForeignKey(d => d.LojaId);
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasIndex(e => e.CategoriaId, "IX_Produtos_CategoriaId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PrecoUnitario).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuantidadePorUnidade).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.CategoriaId);
            });

            modelBuilder.Entity<TiposDePagamento>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Venda>(entity =>
            {
                entity.HasIndex(e => e.ClienteId, "IX_Vendas_ClienteId");

                entity.HasIndex(e => e.LojaId, "IX_Vendas_LojaId");

                entity.HasIndex(e => e.PagamentoId, "IX_Vendas_PagamentoId");

                entity.HasIndex(e => e.PontoDeVendaId, "IX_Vendas_PontoDeVendaId");

                entity.HasIndex(e => e.UtilizadorId, "IX_Vendas_UtilizadorId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.VendaClientes)
                    .HasForeignKey(d => d.ClienteId);

                entity.HasOne(d => d.Loja)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.LojaId);

                entity.HasOne(d => d.Pagamento)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.PagamentoId);

                entity.HasOne(d => d.PontoDeVenda)
                    .WithMany(p => p.Venda)
                    .HasForeignKey(d => d.PontoDeVendaId);

                entity.HasOne(d => d.Utilizador)
                    .WithMany(p => p.VendaUtilizadors)
                    .HasForeignKey(d => d.UtilizadorId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
