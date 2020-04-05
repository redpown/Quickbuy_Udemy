using Quickbuy_Udemy.Dominio.Contract;
using Quickbuy_Udemy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Repositorios
{
    public class BaseRepositorio<Tentity> : IBaseRepositorio<Tentity> where Tentity : class
    {
        //as classes filhas podem herdar com protected
        protected readonly QuickyBuy_Udemy_DB_Entity _quickyBuy_Udemy_DB_Entity;
        public BaseRepositorio(QuickyBuy_Udemy_DB_Entity quickyBuy_Udemy_DB_Entity) {
            // o metodo construtor instancia a classe que preciso
            // a baixo retorno todos os dados da classe
            _quickyBuy_Udemy_DB_Entity = quickyBuy_Udemy_DB_Entity;
        }
        //Tentity classe de instancia gerenerica que sera instanciada
        public void Adicionar(Tentity entity)
        {
            _quickyBuy_Udemy_DB_Entity.Set<Tentity>().Add(entity);
            _quickyBuy_Udemy_DB_Entity.SaveChanges();//sem isso nao salva na base
        }

        public void Atualizar(Tentity entity)
        {
            _quickyBuy_Udemy_DB_Entity.Set<Tentity>().Update(entity);
            _quickyBuy_Udemy_DB_Entity.SaveChanges();
        }

        public void Dispose()
        {
            _quickyBuy_Udemy_DB_Entity.Dispose();
        }

        public Tentity ObterPorId(int id)
        {
            return _quickyBuy_Udemy_DB_Entity.Set<Tentity>().Find(id);
        }

        public IEnumerable<Tentity> ObterTodos()
        {
           return  _quickyBuy_Udemy_DB_Entity.Set<Tentity>().ToList();
        }

        public void Remover(Tentity entity)
        {
            _quickyBuy_Udemy_DB_Entity.Remove(entity);
            _quickyBuy_Udemy_DB_Entity.SaveChanges();
        }
    }
}
