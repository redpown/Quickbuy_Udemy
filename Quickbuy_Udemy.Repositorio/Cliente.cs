using Quickbuy_Udemy.Dominio.Entity;
using Quickbuy_Udemy.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy_Udemy.Repositorio
{
   public class Cliente
    {
        public Cliente() {
            // so funciona no metodo construtor
            var usuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            var usuario = new Usuario();
            //usuarioRepositorio.Adcionar(produto);
            usuarioRepositorio.Adcionar(usuario);
        }  
    }
}
