using AdamApi.DTOS;
using AdamApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamInfrastructure.Data
{
    public class AdamDataContext(DbContextOptions<AdamDataContext> options) : DbContext(options)
    {
        public DbSet<MensajesChatEntity> MensajesChat { get; set; }
        public DbSet<UsuariosChatEntity> UsuariosChat { get; set; }
        public DbSet<ProductosEntity> Productos { get; set; }
    }
}
