using Microsoft.AspNetCore.Mvc;
using Quickbuy_Udemy.Dominio.Contract;
using Quickbuy_Udemy.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quickbuy_Udemy.web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]//aqui dou o nome do caminho mais a classe de controle //ele faz um substring da scrita controle
    public class UsuariosController: ControllerBase
    {
        private readonly IUsuarioRepositorio _IUsuarioRepositorio;
        //para que eu posso intanciar classes de outro projeto dentro da minha aplicacao
        //preciso ir em services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
        //no Startup.cs
        public UsuariosController(IUsuarioRepositorio iUsuarioRepositorio)
        {
            _IUsuarioRepositorio = iUsuarioRepositorio;
        }
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_IUsuarioRepositorio.ObterTodos());
            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.ToString());
            }
        }


        [HttpPost("VerificarUsuario")]//o nome do caminho deve ser identico ao do ActionResult funcao
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioRetorno = _IUsuarioRepositorio.Obter(usuario.Email, usuario.Senha);

                if (usuarioRetorno != null)
                    return Ok(usuarioRetorno);

                return BadRequest("Usuário ou senha inválido");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioCadastrado = _IUsuarioRepositorio.Obter(usuario.Email);

                if (usuarioCadastrado != null)
                    return BadRequest("Usuario já cadastrado no sistema");

                //usuario.EhAdministrador = true;
                _IUsuarioRepositorio.Adicionar(usuario);

                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
