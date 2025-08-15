using AdamApi.Entities;
using AdamApplication.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AdamBestAPI.Controllers
{
    public class UsuariosChatController(IGenericRepository<UsuariosChatEntity, long> usuariosChatRepository) : Controller
    {
        private readonly IGenericRepository<UsuariosChatEntity, long> _usuariosChatRepository = usuariosChatRepository;
        [HttpPost]
        [Route("CrearUsuariosChat")]
        public async Task CreateAsync([FromBody] UsuariosChatEntity usuariosChat)
        {
           await _usuariosChatRepository.CreateAsync(usuariosChat);
        }
    }
}
