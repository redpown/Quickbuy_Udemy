using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quickbuy_Udemy.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Config
{
    class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            //aqui e criado a chave primaria da tabela usuario
            //usando expressao lambda
            builder
                .HasKey(tabelaItemPedido => tabelaItemPedido.Id);
            //builder utiliza fluent :funcao1().funcao2().funcao()3
            builder
                .Property(tabelaItemPedido => tabelaItemPedido.Quantidade)
                .IsRequired();
            //chave estrangeira

            builder
               .HasOne(tabelaItemPedido => tabelaItemPedido.Produto);//aqui ven do virtual
        }
    }
}
