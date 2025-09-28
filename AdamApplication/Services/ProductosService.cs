using AdamApi.Entities;
using AdamApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamApplication.Services
{
    public class ProductosService(IGenericRepository<ProductosEntity, int> productosEntity)
    {
        private readonly IGenericRepository<ProductosEntity, int> _productosEntity = productosEntity;

        public async Task<List<ProductosEntity>> GetProductAvailable()
        {
            var productos = await _productosEntity.GetAllAsync();
            var productosDisponibles = productos.Where(item => item.Estado == 1).ToList();
            return productosDisponibles;
        }
    }
}
