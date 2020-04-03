using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Entity
{
   public class ItemPedido : Entity
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparmensagemDeValidacao();
            if (int.Equals(Id, 0))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Id.");
            }
            if (int.Equals(ProdutoId, 0))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem ProdutoId.");
            }
            if (int.Equals(Quantidade, 0))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Quantidade.");
            }
        }

    }
}
