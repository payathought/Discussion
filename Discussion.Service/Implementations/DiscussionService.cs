using Discussion.Repository.Interfaces;
using Discussion.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussion.Service.Implementations
{
    public class DiscussionService : IDiscussionService
    {
        public IDiscussionRepository DiscussionRepository { get; }

        public DiscussionService(IDiscussionRepository discussionRepository)
        {
            DiscussionRepository = discussionRepository;
        }

        public async Task<Data.Entities.Discussion> GetByIdAsync(Guid id)
        {
            return await DiscussionRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<Data.Entities.Discussion>> GetAllAsync()
        {
            return await DiscussionRepository.GetAllAsync();
        }

        public async Task CreateAsync(Data.Entities.Discussion discussion)
        {
            await DiscussionRepository.CreateAsync(discussion);
        }

        public async Task DeleteAsync(Data.Entities.Discussion discussion)
        {
            await DiscussionRepository.DeleteAsync(discussion);
        }

        public async Task UpdateAsync(Data.Entities.Discussion discussion)
        {
            await DiscussionRepository.UpdateAsync(discussion);
        }
        public async Task UpdateAsync(Data.Entities.Discussion discussion, IEnumerable<Guid> discussionUserIds)
        {
            await DiscussionRepository.UpdateAsync(discussion, discussionUserIds);
        }

        public async Task<Tuple<IEnumerable<Data.Entities.Discussion>, int>> FilterAsync(int? skip, int? take)
        {
            return await DiscussionRepository.FilterAsync(skip, take);
        }
    }
}
