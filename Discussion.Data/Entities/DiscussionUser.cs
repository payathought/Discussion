using System;

namespace Discussion.Data.Entities
{
    public class DiscussionUser : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid DiscussionId { get; set; }
        public Discussion Discussion { get; set; }
    }
}
