using Microsoft.EntityFrameworkCore.Storage;

namespace ventas.webapi.ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        IDbContextTransaction BeginTransaction();
    }
}