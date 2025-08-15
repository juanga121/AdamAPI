using AdamApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.Entities
{
    [Table("usuarios_chat")]
    public class UsuariosChatEntity
    {
        [Key]
        public int Id { get; set; }
        [Column("id_usuario")]
        public string? IdUsuario { get; set; }
        [Column("id_tipo_canal")]
        public TipoCanal IdTipoCanal { get; set; }
        [Column("nombre")]
        public string? Nombre { get; set; }
        [Column("id_estado_chat")]
        public EstadoChat IdEstadoChat { get; set; }
        [Column("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }
    }
}
