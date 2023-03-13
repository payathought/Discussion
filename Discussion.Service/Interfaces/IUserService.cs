using Discussion.Data.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussion.Service.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(Guid id);
        Task CreateAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
        Task<IEnumerable<User>> GetAllAsync(Guid[] userIds);
    }
}
