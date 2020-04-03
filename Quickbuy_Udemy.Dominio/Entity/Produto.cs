using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Entity
{
    public class Produto : Entity
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparmensagemDeValidacao();
            if (int.Equals(Id, 0))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Id.");
            }
            if (string.IsNullOrEmpty(Nome))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Nome.");
            }
            if (string.IsNullOrEmpty(Descricao))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Descricao.");
            }
            if (decimal.Equals(Preco, 0))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Preco.");
            }
        }
    }
}
