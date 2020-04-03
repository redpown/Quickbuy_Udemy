﻿using System;
using System.Collections.Generic;
using System.Linq;//para.Any
using System.Text;

namespace Quickbuy_Udemy.Dominio.Entity
{
    public abstract class Entity
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());  }//?? verifica se esta vazio
        }
        public abstract void Validate();
        protected bool IsValiado { get { return MensagemValidacao.Any(); } }
        protected void LimparmensagemDeValidacao() {
            MensagemValidacao.Clear();
        }

        protected void AdcionarMensagemDeAlerta(string mensagen)
        {
            MensagemValidacao.Add(mensagen);
        }

    }
}