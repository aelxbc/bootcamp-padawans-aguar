using Microsoft.AspNetCore.Mvc;
using Aguar.API.Models;
using Aguar.API.Models.InputModels;
using Aguar.API.Data.Repositories;

namespace Aguar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : ControllerBase
    {
        private readonly IFormularioRepository _formularioRepository;

        public FormularioController(IFormularioRepository formularioRepository)
        {
            _formularioRepository = formularioRepository;
        }



        // GET: api/formulario
        [HttpGet"Todos"]
        public IActionResult Get()
        {
            var formulario = _formularioRepository.Buscar();
            return Ok(formulario);
        }

        // GET api/tarefas/{id}
        [HttpGet("Buscar{id}")]
        public IActionResult Buscar(string id)
        {


            var formulario = _formularioRepository.Buscar(id);

            if (formulario == null)
                return NotFound("Id nao encontrado!");
            return Ok(formulario);
        }

        // POST api/formulario/{id}
        [HttpPost"Inserir"]
        public IActionResult Post([FromBody] FormularioInputModel novaformulario)
        {
            var formulario = new Formulario(novaformulario.Nome,novaformulario.Email, novaformulario.Detalhes, novaformulario.Endereco, novaformulario.Foto);

            _formularioRepository.Adicionar(formulario);

            return Created("", formulario);
        }

        // PUT api/formulario/{id}
        [HttpPut("Atualizar{id}")]
        public IActionResult Put(string id, [FromBody] FormularioInputModel formularioAtualizada)
        {

            var formulario = _formularioRepository.Buscar(id);

            if (formulario == null)
                return NotFound("formulario nao encontrado!!! ");

            formulario.AtualizarFormulario(formularioAtualizada.Nome,formularioAtualizada.Email, formularioAtualizada.Detalhes, formularioAtualizada.Endereco, formularioAtualizada.Foto, formularioAtualizada.Concluido) ;

            _formularioRepository.Atualizar(id, formulario);
            return Ok(formulario);

        }

        // DELETE api/formulario/{id}
        [HttpDelete("Excluir{id}")]
        public IActionResult Delete(string id)
        {
            var formulario = _formularioRepository.Buscar(id);

            if (formulario == null)
                return NotFound("formulario nao encontrado!!! ");

            _formularioRepository.Remover(id);

            return NoContent();
        }
        












    }
}
