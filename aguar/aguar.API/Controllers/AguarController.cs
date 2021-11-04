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



        // GET: api/tarefas
        [HttpGet]
        public IActionResult Get()
        {
            var formulario = _formularioRepository.Buscar();
            return Ok(formulario);
        }

        // GET api/tarefas/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {


            var formulario = _formularioRepository.Buscar(id);

            if (formulario == null)
                return NotFound("Id nao encontrado!");
            return Ok(formulario);
        }

        // POST api/tarefas/{id}
        [HttpPost]
        public IActionResult Post([FromBody] FormularioInputModel novaformulario)
        {
            var formulario = new Formulario(novaformulario.Nome,novaformulario.Email, novaformulario.Detalhes, novaformulario.Endereco, novaformulario.Foto);

            _formularioRepository.Adicionar(formulario);

            return Created("", formulario);
        }

        // PUT api/tarefas/{id}
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] FormularioInputModel formularioAtualizada)
        {

            var formulario = _formularioRepository.Buscar(id);

            if (formulario == null)
                return NotFound("formulario nao encontrado!!! ");

            formulario.AtualizarFormulario(formularioAtualizada.Nome,formularioAtualizada.Email, formularioAtualizada.Detalhes, formularioAtualizada.Endereco, formularioAtualizada.Foto, formularioAtualizada.Concluido) ;

            _formularioRepository.Atualizar(id, formulario);
            return Ok(formulario);

        }

        // DELETE api/tarefas/{id}
        [HttpDelete("{id}")]
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
