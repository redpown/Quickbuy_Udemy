using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quickbuy_Udemy.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //aqui e criado a chave primaria da tabela usuario
            //usando expressao lambda
            builder
                .HasKey(tabelaPedido => tabelaPedido.Id);
            //builder utiliza fluent :funcao1().funcao2().funcao()3
            builder
                .Property(tabelaPedido => tabelaPedido.Cep)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarhcar");
            builder
               .Property(tabelaPedido => tabelaPedido.Cep)
               .IsRequired()
               .HasMaxLength(50)
               .HasColumnType("nvarhcar");
            builder
                .Property(tabelaPedido => tabelaPedido.Cidade)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarhcar");
            builder
                .Property(tabelaPedido => tabelaPedido.DataPedido)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarhcar");
            builder
               .Property(tabelaPedido => tabelaPedido.EnderecoCompleto)
               .IsRequired()
               .HasMaxLength(256)
               .HasColumnType("nvarhcar");
            builder
               .Property(tabelaPedido => tabelaPedido.Estado)
               .IsRequired()
               .HasMaxLength(256)
               .HasColumnType("nvarhcar");
            builder
              .Property(tabelaPedido => tabelaPedido.PrevisaoDeEntrega)
              .IsRequired()
              .HasMaxLength(256)
              .HasColumnType("nvarhcar");
            //chave estrangeira
            builder
               .HasOne(tabelaPedido => tabelaPedido.Usuario);

        }
    }
}
