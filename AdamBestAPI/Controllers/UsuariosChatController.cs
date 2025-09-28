using AdamApi.DTOS;
using AdamApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdamBestAPI.Controllers
{
    public class UsuariosChatController(UsuariosChatService usuariosChatService) : Controller
    {
        private readonly UsuariosChatService _usuariosChatService = usuariosChatService;

        [HttpPost]
        [Route("CrearUsuariosChat")]
        public async Task<IActionResult> CreateAsync([FromBody] UsuariosChatDTO usuariosChatDTO)
        {
            await _usuariosChatService.CreateAsync(usuariosChatDTO);
            return Ok("Usuario creado correctamente");
        }

        [HttpGet]
        [Route("ObtenerUsuariosChatPorId/{id}")]
        public async Task<IActionResult> UsuariosGet(string id)
        {
            var result = await _usuariosChatService.UsuariosGet(id);
            return Ok(result);
        }
    }
}
