using AdamApi.DTOS;
using AdamApi.Entities;
using AdamApplication.Repositories;
using AdamInfrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamInfrastructure.Repositories
{
    public class MensajesPorUsuarioRepository(AdamDataContext dbContext) : IMensajesRepository
    {
        private readonly AdamDataContext _dbContext = dbContext;
        public async Task<List<MensajesPorUsuarioDTO>> ObtenerMensajesPorUsuario(string idUsuario)
        {
            var mensajes = await (
                from mc in _dbContext.MensajesChat
                join uc in _dbContext.UsuariosChat on mc.IdUsuarioChat equals uc.IdUsuario
                where uc.IdUsuario == idUsuario
                select new MensajesPorUsuarioDTO
                {
                    IdUsuarioChat = mc.IdUsuarioChat,
                    IdUsuario = uc.IdUsuario,
                    Nombre = uc.Nombre,
                    Mensaje = mc.Mensaje,
                }
            ).ToListAsync();

            return mensajes;
        }
    }
}
