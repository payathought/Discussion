using System;
using System.Collections.Generic;

namespace Discussion.Api.Models.ViewModels.Discussion
{
    public class DiscussionDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public string Outcomes { get; set; }
        public UserDto Observer { get; set; }
        public IEnumerable<UserDto> Colleagues { get; set; }
    }
}
