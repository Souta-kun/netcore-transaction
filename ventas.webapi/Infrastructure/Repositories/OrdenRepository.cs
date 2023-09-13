using ventas.webapi.ApplicationCore.Interfaces;
using ventas.webapi.ApplicationCore.Models;
using ventas.webapi.Infrastructure.Base;

namespace ventas.webapi.Infrastructure.Repositories
{
    public class OrdenRepository : IOrdenRepository
    {
        private readonly VentasContext _context;

        public OrdenRepository(VentasContext context)
        {
            this._context = context;
        }

        public async Task Create(Orden entity)
        {
            await _context.Orden.AddAsync(entity);
        }
    }
}