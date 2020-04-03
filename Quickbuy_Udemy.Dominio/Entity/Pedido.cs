using Quickbuy_Udemy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Entity
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime PrevisaoDeEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroDoEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento formaDePagamento { get; set; }


        public ICollection<ItemPedido> ItensPedido { get; set; }

    }
}
