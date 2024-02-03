using System.Threading.Tasks;

namespace AcmeProducts.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
