using ventas.webapi.ApplicationCore.Models;

namespace ventas.webapi.ApplicationCore.Interfaces
{
    public interface IProductoRepository
    {
        Task Create(Producto entity);
    }
}