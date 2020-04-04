using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quickbuy_Udemy.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //aqui e criado a chave primaria da tabela usuario
            //usando expressao lambda
            builder
                .HasKey(tabelaProduto => tabelaProduto.Id);
            //builder utiliza fluent :funcao1().funcao2().funcao()3
            builder
                .Property(tabelaProduto => tabelaProduto.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("nvarhcar");
            builder
                .Property(tabelaProduto => tabelaProduto.Preco)
                .IsRequired();
            builder
                .Property(tabelaProduto => tabelaProduto.Descricao)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("nvarhcar");

           
        }
    }
}
