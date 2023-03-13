using System;

namespace Discussion.Api.Models.ViewModels.Discussion
{
    public class DiscussionUserDto
    {
        public Guid Id { get; set; }
        public UserDto User { get; set; }
    }
}
