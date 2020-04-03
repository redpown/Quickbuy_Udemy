using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Entity
{
    public class Produto : Entity
    {
        {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
}
