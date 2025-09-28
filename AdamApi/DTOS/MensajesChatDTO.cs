using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.DTOS
{
    public class MensajesChatDTO
    {
        public string? IdUsuarioChat { get; set; }
        public bool? EsRespuesta { get; set; }
        public string? Mensaje { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
