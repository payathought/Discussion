using Discussion.Data.Entities;
using Discussion.Repository.Interfaces;
using Discussion.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussion.Service.Implementations
{
    public class UserService : IUserService
    {
        private IUserRepository UserRepository { get; }

        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await UserRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await UserRepository.GetAllAsync();
        }

        public async Task CreateAsync(User user)
        {
            await UserRepository.CreateAsync(user);
        }

        public async Task DeleteAsync(User user)
        {
            await UserRepository.DeleteAsync(user);
        }

        public async Task UpdateAsync(User user)
        {
            await UserRepository.UpdateAsync(user);
        }

        public async Task<IEnumerable<User>> GetAllAsync(Guid[] userIds)
        {
            return await UserRepository.GetAllAsync(userIds);
        }
    }
}
