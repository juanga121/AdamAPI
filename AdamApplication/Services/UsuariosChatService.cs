using AdamApi.DTOS;
using AdamApi.Entities;
using AdamApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApplication.Services
{
    public class UsuariosChatService(IGenericRepository<UsuariosChatEntity, int> usuariosChatEntity)
    {
        private readonly IGenericRepository<UsuariosChatEntity, int> _usuariosChatEntity = usuariosChatEntity;

        public async Task CreateAsync(UsuariosChatDTO usuariosChatDTO)
        {
            var usuario = await UsuariosGet(usuariosChatDTO.IdUsuario!);

            if (usuario == null || usuario.IdUsuario != usuariosChatDTO.IdUsuario)
            {
                UsuariosChatEntity usuariosChatEntity = new()
                {
                    IdUsuario = usuariosChatDTO.IdUsuario,
                    IdTipoCanal = usuariosChatDTO.IdTipoCanal,
                    Nombre = usuariosChatDTO.Nombre,
                    IdEstadoChat = usuariosChatDTO.IdEstadoChat,
                    FechaCreacion = DateTime.Now
                };
                await _usuariosChatEntity.CreateAsync(usuariosChatEntity);
            }
        }

        public async Task<UsuariosChatEntity?> UsuariosGet(string id_usuario)
        {
            var usuario = await _usuariosChatEntity.FindByIdStringAsync(id_usuario);
            return usuario;
        }
    }
}
