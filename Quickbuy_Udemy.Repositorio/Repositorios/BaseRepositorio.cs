using Quickbuy_Udemy.Dominio.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Repositorios
{
    public class BaseRepositorio<Tentity> : IBaseRepositorio<Tentity> where Tentity : class
    {
        public BaseRepositorio() { 

        }

        public void Adcionar(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Tentity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Remover(Tentity entity)
        {
            throw new NotImplementedException();
        }
    }
}
