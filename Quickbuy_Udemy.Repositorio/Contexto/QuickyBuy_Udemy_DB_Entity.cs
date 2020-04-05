using Microsoft.EntityFrameworkCore;
using Quickbuy_Udemy.Repositorio.Config;
using Quickbuy_Udemy.Dominio.Entity;
using Quickbuy_Udemy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;
using Quickbuy_Udemy.Dominio.Enumerados;

namespace Quickbuy_Udemy.Repositorio.Contexto
{
    public class QuickyBuy_Udemy_DB_Entity:DbContext
    {
        public QuickyBuy_Udemy_DB_Entity(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //classes de mapeamento aqui..
            //que sao as classes criadas na pasta Config...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            //aqui e gerado a carga inicial
            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { 
                Id = 1, Nome = "Boleto",Descricao = "Forma de pagamento Boleto."
                },
                new FormaPagamento() { 
                Id = 2, Nome = "Cartão",Descricao = "Forma de pagamento Cartão."
                },
                new FormaPagamento() { 
                Id = 3, Nome = "Deposito",Descricao = "Forma de pagamento Deposito."
                },
                new FormaPagamento() { 
                Id = 4, Nome = "Dinheiro",Descricao = "Forma de pagamento Dinheiro."
                }
                );
        }

    }
}
