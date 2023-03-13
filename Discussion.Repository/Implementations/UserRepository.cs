using Discussion.Data.Entities;
using Discussion.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discussion.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private ApplicationContext Context { get; }
        public UserRepository(ApplicationContext context)
        {
            Context = context;
        }


        public async Task CreateAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(User));

            Context.User.Add(user);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(User));

            user.Deleted = true;

            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await Context.User
                 .Where(u => u.Deleted == false).ToListAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await Context.User
                .Where(u => u.Id == id && u.Deleted == false).FirstOrDefaultAsync();

        }

        public async Task UpdateAsync(User user)
        {
            Context.User.Update(user);
            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync(Guid[] userIds)
        {
            return await Context.User.Where(u => userIds.Contains(u.Id) & !u.Deleted).ToListAsync();
        }
    }
}
