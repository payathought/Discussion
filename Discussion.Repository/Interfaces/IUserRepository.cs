using Discussion.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussion.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(Guid id);
        Task CreateAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
        Task<IEnumerable<User>> GetAllAsync(Guid[] userIds);
    }
}
