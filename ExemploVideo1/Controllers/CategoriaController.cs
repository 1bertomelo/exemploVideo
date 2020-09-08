using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploVideo1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploVideo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem de Categorias");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Detalhes da Categoria");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Categoria categoria)
        {
            if (string.IsNullOrEmpty(categoria.titulo)){
                return BadRequest("Titulo está vazio, tente novamente!");
            }
            return Ok("Categoria criada com sucesso");
        }

    }
}
