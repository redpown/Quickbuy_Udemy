using Microsoft.EntityFrameworkCore;
using Quickbuy_Udemy.Repositorio.Config;
using Quickbuy_Udemy.Dominio.Entity;
using Quickbuy_Udemy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

    }
}
