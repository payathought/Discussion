﻿using System.Collections.Generic;

namespace Discussion.Data.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<DiscussionUser> DiscussionUsers { get; set; }
    }
}
