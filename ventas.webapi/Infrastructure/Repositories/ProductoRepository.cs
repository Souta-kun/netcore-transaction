using ventas.webapi.ApplicationCore.Interfaces;
using ventas.webapi.ApplicationCore.Models;
using ventas.webapi.Infrastructure.Base;

namespace ventas.webapi.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly VentasContext _context;

        public ProductoRepository(VentasContext context)
        {
            this._context = context;
        }
        
        public async Task Create(Producto entity)
        {
            await _context.Producto.AddAsync(entity);
        }
    }
}