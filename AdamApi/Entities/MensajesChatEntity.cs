using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.Entities
{
    public class MensajesChatEntity
    {
        public int Id { get; set; }
        public int IdUsuarioChat { get; set; }
        public bool? EsRespuesta { get; set; }
        public string? Mensaje { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
