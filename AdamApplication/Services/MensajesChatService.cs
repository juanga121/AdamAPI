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
    public class MensajesChatService(IGenericRepository<MensajesChatEntity, int> mensajesChatEntity, IMensajesRepository mensajesRepository) : IMensajesRepository
    {
        private readonly IGenericRepository<MensajesChatEntity, int> _mensajesChatEntity = mensajesChatEntity;
        private readonly IMensajesRepository _mensajesRepository = mensajesRepository;

        public async Task CreateAsync(MensajesChatDTO mensajesChatDTO)
        {
            MensajesChatEntity mensajesChatEntity = new()
            {
                IdUsuarioChat = mensajesChatDTO.IdUsuarioChat,
                EsRespuesta = mensajesChatDTO.EsRespuesta,
                Mensaje = mensajesChatDTO.Mensaje,
                FechaCreacion = DateTime.Now
            };
             
            await _mensajesChatEntity.CreateAsync(mensajesChatEntity);
        }

        public async Task<List<MensajesPorUsuarioDTO>> ObtenerMensajesPorUsuario(string idUsuario)
        {
            return await _mensajesRepository.ObtenerMensajesPorUsuario(idUsuario);
        }
    }
}
