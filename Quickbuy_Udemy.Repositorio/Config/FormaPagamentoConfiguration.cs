using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quickbuy_Udemy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            //aqui e criado a chave primaria da tabela usuario
            //usando expressao lambda
            builder
                .HasKey(tabelaFormaPagamento => tabelaFormaPagamento.Id);
            //builder utiliza fluent :funcao1().funcao2().funcao()3
            builder
                 .Property(tabelaFormaPagamento => tabelaFormaPagamento.Nome)
                 .IsRequired();

            builder
                .Property(tabelaFormaPagamento => tabelaFormaPagamento.Descricao)
                .IsRequired();
            /*
            //acho q daqui para baixo nao devia ser gerado
            builder
                .Property(tabelaFormaPagamento => tabelaFormaPagamento.IsBoleto)
                .IsRequired()
                .HasColumnType("boolean");
            builder
                .Property(tabelaFormaPagamento => tabelaFormaPagamento.IsCartaoDeCredito)
                .IsRequired()
                .HasColumnType("boolean");
            builder
                .Property(tabelaFormaPagamento => tabelaFormaPagamento.IsDeposito)
                .IsRequired()
                .HasColumnType("boolean");
            builder
                .Property(tabelaFormaPagamento => tabelaFormaPagamento.IsNaoDefinido)
                .IsRequired()
                .HasColumnType("boolean");
                */
        }
    
    }
}
