using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApi.Entities
{
    [Table("productos")]
    public class ProductosEntity
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

        [Column("precio", TypeName = "decimal(10,2)")]
        public decimal? Precio { get; set; }

        [Column("stock")]
        public int? Stock { get; set; }

        [Column("id_categoria")]
        public int? IdCategoria { get; set; }

        [Column("estado")]
        public int? Estado { get; set; }

        [Column("id_tipo_medida")]
        public int? IdTipoMedida { get; set; }

        [Column("medida_ancho")]
        public int? MedidaAncho { get; set; }

        [Column("medida_largo")]
        public int? MedidaLargo { get; set; }

        [Column("peso", TypeName = "decimal(10,2)")]
        public decimal? Peso { get; set; }

        [Column("fecha_creacion")]
        public DateTime? FechaCreacion { get; set; }

        [Column("fecha_actualizacion")]
        public DateTime? FechaActualizacion { get; set; }
    }
}
