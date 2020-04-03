using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Entity
{
    public class Usuario : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparmensagemDeValidacao();
            if (int.Equals(Id, 0))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Id.");
            }
            if (string.IsNullOrEmpty(Email))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Email.");
            }
            if (string.IsNullOrEmpty(Senha))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Senha.");
            }
            if (string.IsNullOrEmpty(Nome))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Nome.");
            }
            if (string.IsNullOrEmpty(Sobrenome))
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Sobrenome.");
            }

            if (!Pedidos.Any())
            {

                AdcionarMensagemDeAlerta("Crítica - Pedido não pode ficar sem Pedidos.");
            }

        }
    }
}
