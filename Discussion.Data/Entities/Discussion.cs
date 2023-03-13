using System;
using System.Collections.Generic;

namespace Discussion.Data.Entities
{
    public class Discussion : BaseEntity
    {
        public Guid ObserverId { get; set; }
        public User Observer { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public string Outcomes { get; set; }
        public ICollection<DiscussionUser> DiscussionUsers { get; set; }

    }
}
