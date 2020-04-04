using Quickbuy_Udemy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Entity
{
    public class Pedido:Entity
    {

        //log do add-migration 
        //'formaDePagamento' on entity type 'Pedido'
        //   problema                      onde esta
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        /// <summary>
        /// virtual Usuario Usuario mapea o id do usuario da classe usuario
        /// se segui o exemplo do UsuarioId ,juncoes em maisusculo Usuario + Id
        /// o entityframework separa os dois com a virtual
        /// </summary>
        public virtual Usuario Usuario { get; set; }
        public DateTime PrevisaoDeEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroDoEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento formaDePagamento { get; set; }

        /// <summary>
        /// virtual para ser alimentada na base em tempo de exucatao
        /// </summary>

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparmensagemDeValidacao();
            if (!ItensPedido.Any()) {
               
                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem item de pedido.");
            }
            if (string.IsNullOrEmpty(Cep))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Cep.");
            }
            if (string.IsNullOrEmpty(Estado))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Estado.");
            }
            if (string.IsNullOrEmpty(Cidade))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Cidade.");
            }
            if (string.IsNullOrEmpty(EnderecoCompleto))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem EnderecoCompleto.");
            }
        }
    }
}
