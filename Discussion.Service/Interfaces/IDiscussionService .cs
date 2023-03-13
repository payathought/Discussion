using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discussion.Service.Interfaces
{
    public interface IDiscussionService
    {
        Task<IEnumerable<Data.Entities.Discussion>> GetAllAsync();
        Task<Data.Entities.Discussion> GetByIdAsync(Guid id);
        Task CreateAsync(Data.Entities.Discussion discussion);
        Task UpdateAsync(Data.Entities.Discussion discussion);
        Task DeleteAsync(Data.Entities.Discussion discussion);
        Task<Tuple<IEnumerable<Data.Entities.Discussion>, int>> FilterAsync(int? skip, int? take);
        Task UpdateAsync(Data.Entities.Discussion discussion, IEnumerable<Guid> discussionUserIds);
    }
}
