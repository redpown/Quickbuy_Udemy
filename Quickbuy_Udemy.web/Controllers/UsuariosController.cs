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
    [Route("api/[controller]")]
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
        [HttpPost]
        public ActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                _IUsuarioRepositorio.Adicionar(usuario);
                //return Created("api/produto",produto);
                return Created("api/usuarios", usuario);
            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.ToString());
            }
        }
        [HttpPost("verificausuario")]//em parenteses esta o caminho 
        public ActionResult VerificarUsuario([FromBody]Usuario usuario)//converte a classe usuario em json
        {
            try
            {
                if (usuario.Email != "" || usuario.Senha != "") {
                    return Ok(usuario);
                } else {
                    return BadRequest("Usuário ou senha inválido!.");
                }
            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.ToString());
            }
        }
    }
}
