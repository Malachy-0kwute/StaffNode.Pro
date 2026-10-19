using MongoDB.Bson;
using StaffNode.Pro.Domain.Common;

namespace StaffNode.Pro.Application.Contracts.Persistence
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T?> GetByIdAsync(string id);
        Task<int> CreateAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(string id);
    }
}
