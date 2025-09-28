using AdamApi.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApplication.Repositories
{
    public interface IMensajesRepository
    {
        Task<List<MensajesPorUsuarioDTO>> ObtenerMensajesPorUsuario(string idUsuario);
    }
}
