using Quickbuy_Udemy.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Contract
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        public Usuario Obter(string email, string senha);
        public Usuario Obter(string email);
    }
}
