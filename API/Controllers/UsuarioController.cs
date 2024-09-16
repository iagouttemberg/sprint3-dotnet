using API.DTO.Request;
using Database.Models;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public UsuarioController(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var usuarios = _usuarioRepository.GetAll();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var usuario = _usuarioRepository.GetById(id);
            if (usuario == null)
            {
                return NotFound("Usuário não encontrado");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UsuarioRequest usuarioRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = new Usuario
            {
                NomeCompleto = usuarioRequest.NomeCompleto,
                NomeUsuario = usuarioRequest.NomeUsuario,
                DataNascimento = usuarioRequest.DataNascimento,
                Email = usuarioRequest.Email,
                Senha = usuarioRequest.Senha
            };

            _usuarioRepository.Add(usuario);
            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UsuarioRequest usuarioRequest)
        {
            var usuario = _usuarioRepository.GetById(id);
            if (usuario == null)
            {
                return NotFound("Usuário não encontrado");
            }

            usuario.NomeCompleto = usuarioRequest.NomeCompleto;
            usuario.NomeUsuario = usuarioRequest.NomeUsuario;
            usuario.DataNascimento = usuarioRequest.DataNascimento;
            usuario.Email = usuarioRequest.Email;
            usuario.Senha = usuarioRequest.Senha;

            _usuarioRepository.Update(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuario = _usuarioRepository.GetById(id);
            if (usuario == null)
            {
                return NotFound("Usuário não encontrado");
            }

            _usuarioRepository.Delete(usuario);
            return NoContent();
        }
    }
}
