using Quickbuy_Udemy.Dominio.Entity;
using Quickbuy_Udemy.Dominio.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using Quickbuy_Udemy.Repositorio.Contexto;

namespace Quickbuy_Udemy.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickyBuy_Udemy_DB_Entity quickyBuy_Udemy_DB_Entity) : base(quickyBuy_Udemy_DB_Entity)
        {
        }
    }
}
