using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploVideo1.Models;
using ExemploVideo1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploVideo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoRepository _repository;

        public ProdutoController()
        {
            _repository = new ProdutoRepository();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var produtoBusca = _repository.GetById(id);
            if (produtoBusca == null)
                return NotFound();            
            return Ok(produtoBusca);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Produto produto)
        {
            if (produto.precoVenda < 0)
            {
                return BadRequest("Preço negativo , tente novamente!");
            }
            if (produto.estoque < 0)
            {
                return BadRequest("Estoque negativo , tente novamente!");
            }
            if (produto.precoCusto < 0)
            {
                return BadRequest("Estoque negativo , tente novamente!");
            }
            if (string.IsNullOrEmpty(produto.nome))
            {
                return BadRequest("Nome em branco , tente novamente!");
            }
            if (string.IsNullOrEmpty(produto.descricao))
            {
                return BadRequest("Descricao em branco , tente novamente!");
            }
            _repository.Insert(produto);
            return Ok("Produto cadastrado com sucesso");
        }
    }
}
