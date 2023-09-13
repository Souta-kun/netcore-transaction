using ventas.webapi.ApplicationCore.Interfaces;
using ventas.webapi.Infrastructure.Base;
using Microsoft.EntityFrameworkCore.Storage;

namespace ventas.webapi.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VentasContext _context;

        public UnitOfWork(VentasContext context)
        {
            this._context = context;
        }

        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return this._context.SaveChangesAsync(cancellationToken);
        }

        public IDbContextTransaction BeginTransaction()
        {
            return this._context.Database.BeginTransaction();
        }
    }
}