using AdamApi.DTOS;
using AdamApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdamBestAPI.Controllers
{
    public class MensajesChatController(MensajesChatService mensajesChatService) : Controller
    {
        private readonly MensajesChatService _mensajesChatService = mensajesChatService;

        [HttpPost]
        [Route("CrearMensajesChat")]
        public async Task<IActionResult> CreateAsync([FromBody] MensajesChatDTO mensajesChatDTO)
        {
            await _mensajesChatService.CreateAsync(mensajesChatDTO);
            return Ok("Mensaje creado correctamente");
        }

        [HttpGet]
        [Route("ObtenerMensajesPorUsuario/{idUsuario}")]
        public async Task<IActionResult> ObtenerMensajesPorUsuario(string idUsuario)
        {
            var result = await _mensajesChatService.ObtenerMensajesPorUsuario(idUsuario);
            return Ok(result);
        }
    }
}
