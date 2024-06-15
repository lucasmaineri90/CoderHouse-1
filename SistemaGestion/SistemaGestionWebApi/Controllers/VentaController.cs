using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionUI.SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "ListarVenta")]
        public IEnumerable<Venta> Ventas()
        {
            return VentaBussiness.ListarVenta().ToArray();
        }
        [HttpGet("{Id}")]

        public IActionResult ObtenerVenta(int Id)
        {
            Venta Ventas = VentaBussiness.ObtenerVenta(Id);
            return Ok(Ventas);
        }
    }
}
