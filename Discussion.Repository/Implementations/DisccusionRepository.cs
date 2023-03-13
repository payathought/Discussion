using Discussion.Data.Entities;
using Discussion.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discussion.Repository.Implementations
{
    public class DisccusionRepository : IDiscussionRepository
    {
        private ApplicationContext Context { get; }
        public DisccusionRepository(ApplicationContext context)
        {
            Context = context;
        }


        public async Task CreateAsync(Data.Entities.Discussion discussion)
        {
            if (discussion == null)
                throw new ArgumentNullException(nameof(User));

            Context.Discussion.Add(discussion);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Data.Entities.Discussion discussion)
        {
            if (discussion == null)
                throw new ArgumentNullException(nameof(User));

            discussion.Deleted = true;

            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Data.Entities.Discussion>> GetAllAsync()
        {
            return await Context.Discussion
                 .Where(u => u.Deleted == false).ToListAsync();
        }
        public async Task<Tuple<IEnumerable<Data.Entities.Discussion>, int>> FilterAsync(int? skip, int? take)
        {
            var discussions = Context.Discussion
                .Include(u => u.Observer)
                .Include(d => d.DiscussionUsers)
                    .ThenInclude(du => du.User)
                .Where(u => u.Deleted == false);

            if (skip.HasValue)
                discussions = discussions.Skip(skip.Value);

            if (take.HasValue)
                discussions = discussions.Take(take.Value);

            var total = discussions.Count();

            return new Tuple<IEnumerable<Data.Entities.Discussion>, int>(await discussions.ToListAsync(), total);
        }

        public async Task<Data.Entities.Discussion> GetByIdAsync(Guid id)
        {
            return await Context.Discussion
                .Include(u => u.Observer)
                .Include(d => d.DiscussionUsers)
                    .ThenInclude(du => du.User)
                .Where(u => u.Id == id && u.Deleted == false).FirstOrDefaultAsync();

        }

        public async Task UpdateAsync(Data.Entities.Discussion discussion)
        {
            Context.Discussion.Update(discussion);
            await Context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Data.Entities.Discussion discussion, IEnumerable<Guid> discussionUserIds)
        {
            var discussionRecord = await Context.Discussion
            .Include(u => u.DiscussionUsers)
            .SingleOrDefaultAsync(u => u.Id == discussion.Id && u.Deleted == false);

            if (discussionRecord != null)
            {
                Context.DiscussionUser.RemoveRange(discussion.DiscussionUsers);
                List<DiscussionUser> discussionUsers = new();

                foreach (var id in discussionUserIds)
                {
                    var user = await Context.User.SingleOrDefaultAsync(u => u.Id == id);

                    if (user != null)
                    {
                        discussionUsers.Add(new DiscussionUser
                        {
                            Id = new Guid(),
                            DiscussionId = discussionRecord.Id,
                            UserId = id,
                            CreatedById = discussionRecord.CreatedById,
                            CreatedDate = DateTime.UtcNow,
                        });
                    }
                }

                Context.Discussion.Update(discussion);
                await Context.DiscussionUser.AddRangeAsync(discussionUsers);
                await Context.SaveChangesAsync();
            }

        }

    }
}
