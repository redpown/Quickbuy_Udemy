using Quickbuy_Udemy.Dominio.Contract;
using Quickbuy_Udemy.Dominio.Entity;
using Quickbuy_Udemy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickyBuy_Udemy_DB_Entity quickyBuy_Udemy_DB_Entity) : base(quickyBuy_Udemy_DB_Entity)
        {
        }
    }
}
