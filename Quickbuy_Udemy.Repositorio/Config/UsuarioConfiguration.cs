using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quickbuy_Udemy.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //aqui e criado a chave primaria da tabela usuario
            //usando expressao lambda
            builder.HasKey(tabelaUsuario => tabelaUsuario.Id);
            //builder utiliza fluent :funcao1().funcao2().funcao()3
            builder.Property(tabelaUsuario => tabelaUsuario.Email)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar "); 
            builder.Property(tabelaUsuario => tabelaUsuario.Senha)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnType("varchar "); 
            builder.Property(tabelaUsuario => tabelaUsuario.Nome)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("varchar ");
            builder.Property(tabelaUsuario => tabelaUsuario.Sobrenome)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("varchar ");        
            builder.Property(tabelaUsuario => tabelaUsuario.Sobrenome)
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("varchar ");
            ///aqui e feito o relacionamento da chave estrangeira
            builder
                .HasMany(tabelaUsuario => tabelaUsuario.Pedidos)
                .WithOne(tabelaPedido => tabelaPedido.Usuario);
            //Hasmany precisa de uma propriedade do tipo icolletion
        }
    }
}
