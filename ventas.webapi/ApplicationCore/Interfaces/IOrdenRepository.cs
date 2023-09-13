using ventas.webapi.ApplicationCore.Models;

namespace ventas.webapi.ApplicationCore.Interfaces
{
    public interface IOrdenRepository
    {
        Task Create(Orden entity);
    }
}