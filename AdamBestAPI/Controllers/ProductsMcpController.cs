using AdamApplication.Services;
using Microsoft.AspNetCore.Mvc;
using ModelContextProtocol;
using AdamApi.Entities;

namespace AdamBestAPI.Controllers
{
    [ApiController]
    [Route("mcp/resources")]
    public class ProductsMcpController(ProductosService productosService) : ControllerBase
    {
        private readonly ProductosService _productosService = productosService;

        [HttpGet("products_listAvailable")]
        public async Task<IActionResult> GetProductAvailable()
        {
            var resultado = await _productosService.GetProductAvailable();
            return Ok(new
            {
                type = "resource",
                name = "products_listAvailable",
                data = resultado
            });
        }
    }
}
