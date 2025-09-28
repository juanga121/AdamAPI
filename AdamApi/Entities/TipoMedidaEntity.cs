using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.Entities
{
    [Table("tipo_medida")]
    public class TipoMedidaEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre_detalle")]
        [StringLength(35)]
        public string? NombreDetalle { get; set; }

        [Column("nombre_abreviado")]
        [StringLength(3)]
        public string? NombreAbreviado { get; set; }
    }
}
