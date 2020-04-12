using Quickbuy_Udemy.Dominio.Contract;
using Quickbuy_Udemy.Dominio.Entity;
using Quickbuy_Udemy.Repositorio.Contexto;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickyBuy_Udemy_DB_Entity quickyBuy_Udemy_DB_Entity) : base(quickyBuy_Udemy_DB_Entity)
       //  public UsuarioRepositorio(QuickyBuy_Udemy_DB_Entity quickyBuy_Udemy_DB_Entity) : base(quickyBuy_Udemy_DB_Entity)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            // funcao lambda e usada em lista de dados
            //sintax uma variavel para o foreach exemplo:
            // u  
            //sinal para definir a expresao =>
            //expressao u.Email == email && u.Senha == senha
            //que so vai retornar onde for true
            return _quickyBuy_Udemy_DB_Entity.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return _quickyBuy_Udemy_DB_Entity.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
