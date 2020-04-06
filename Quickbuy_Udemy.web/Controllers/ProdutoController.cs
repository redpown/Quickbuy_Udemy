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
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _IProdutoRepositorio;
        //para que eu posso intanciar classes de outro projeto dentro da minha aplicacao
        //preciso ir em services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
        //no Startup.cs
        public ProdutoController(IProdutoRepositorio iProdutoRepositorio) {
            _IProdutoRepositorio = iProdutoRepositorio;
        }
        [HttpGet]
        public ActionResult Get() {
            try
            {
                return Ok(_IProdutoRepositorio.ObterTodos());
            }
            catch (Exception Ex) {
                return BadRequest(Ex.ToString());
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody]Produto produto)
        {
            try
            {
                _IProdutoRepositorio.Adicionar(produto);
                //return Created("api/produto",produto);
                return Created("api/produto", produto);
            }
            catch (Exception Ex)
            {
                return BadRequest(Ex.ToString());
            }
        }
    }
}
