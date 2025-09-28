using AdamApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.DTOS
{
    public class UsuariosChatDTO
    {
        public string? IdUsuario { get; set; }
        public TipoCanal IdTipoCanal { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public EstadoChat IdEstadoChat { get; set; }
    }
}
