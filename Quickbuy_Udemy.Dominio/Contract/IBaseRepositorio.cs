using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Dominio.Contract
{
    public interface IBaseRepositorio<Tentity> : IDisposable where Tentity : class
    {
        /*
        public void Adcionar(Tentity entity);
        public Tentity ObterPorId(int id);
        public void Atualizar(Tentity entity);
        public void Remover(Tentity entity);
               IEnumerable<Tentity> faltou em baixo prestar atencao
        public Tentity ObterTodos(Tentity entity);
        */

        public void Adicionar(Tentity entity);
        public Tentity ObterPorId(int id);
        public IEnumerable<Tentity> ObterTodos();
        public void Atualizar(Tentity entity);
        public void Remover(Tentity entity);


    }
}
