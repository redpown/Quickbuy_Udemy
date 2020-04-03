using Quickbuy_Udemy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool IsBoleto {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool IsCartaoDeCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoDeCredito; }
        }

        public bool IsDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool IsNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}
