using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.Entities
{
    [Table("categorias")]
    public class CategoriasProductosEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [Column("descripcion")]
        [StringLength(255)]
        public string? Descripcion { get; set; }

        [Column("estado")]
        public int? Estado { get; set; }

        [Column("fecha_creacion")]
        public DateTime? FechaCreacion { get; set; }

        [Column("fecha_actualizacion")]
        public DateTime? FechaActualizacion { get; set; }
    }
}
