using Microsoft.AspNetCore.Mvc;
using ventas.webapi.ApplicationCore.Interfaces;
using ventas.webapi.ApplicationCore.Models;

namespace ventas.webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductoRepository _productoRepository;
    private readonly IOrdenRepository _ordenRepository;

    public TestController(
        IUnitOfWork unitOfWork,
        IProductoRepository productoRepository,
        IOrdenRepository ordenRepository)
    {
        this._unitOfWork = unitOfWork;
        this._productoRepository = productoRepository;
        this._ordenRepository = ordenRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Get()
    {
        using var transaction = _unitOfWork.BeginTransaction();

        try
        {
            var orden = new Orden() 
            {
                Valor = 150000,
                Creado = DateTime.Now
            };

            await _ordenRepository.Create(orden);

            var producto = new Producto() 
            {
                Nombre = "Mouse",
                Marca = "HP",
                Valor = 10000,
                Creado = DateTime.Now
            };

            await _productoRepository.Create(producto);

            await _unitOfWork.SaveChangesAsync();
            
            transaction.Commit();

            return Ok("Success!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            transaction.Rollback();

            return BadRequest(new {
                message = ex.Message,
                internal_message = ex.InnerException?.Message
            });
        }
    }
}
