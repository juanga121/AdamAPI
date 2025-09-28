using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.DTOS
{
    public class MensajesPorUsuarioDTO
    {
        public string? IdUsuarioChat { get; set; }
        public string? IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string? Mensaje { get; set; }
    }
}
