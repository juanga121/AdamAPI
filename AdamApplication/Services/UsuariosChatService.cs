using AdamApi.Entities;
using AdamApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApplication.Services
{
    public class UsuariosChatService(IGenericRepository<UsuariosChatEntity, long> usuariosChatEntity)
    {
        private readonly IGenericRepository<UsuariosChatEntity, long> _usuariosChatEntity = usuariosChatEntity;

        public async Task CreateAsync(UsuariosChatEntity entity)
        {
            await _usuariosChatEntity.CreateAsync(entity);
        }

    }
}
