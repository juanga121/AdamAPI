using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.Entities
{
    [Table("mensajes_chat")]
    public class MensajesChatEntity
    {
        [Key]
        public int Id { get; set; }
        [Column("id_usuario_chat")]
        public string? IdUsuarioChat { get; set; }
        [Column("es_respuesta")]
        public bool? EsRespuesta { get; set; }
        [Column("mensaje")]
        public string? Mensaje { get; set; }
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }
    }
}
