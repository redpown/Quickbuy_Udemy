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

    }
}
