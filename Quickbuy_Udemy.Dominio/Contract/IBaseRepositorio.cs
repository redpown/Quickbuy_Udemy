using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Contract
{
    public interface IBaseRepositorio<Tentity> : IDisposable where Tentity : class
    {
        void Adcionar(Tentity entity);
        Tentity ObterPorId(int id);
        void Atualizar(Tentity entity);
        void Remover(Tentity entity);
    }
}
