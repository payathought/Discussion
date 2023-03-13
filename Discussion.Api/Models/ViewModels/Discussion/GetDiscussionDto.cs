using System;
using System.Collections.Generic;

namespace Discussion.Api.Models.ViewModels.Discussion
{
    public class GetDiscussionDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public string Outcomes { get; set; }
        public Guid ObserverId { get; set; }
        public IEnumerable<Guid> ColleaugesId { get; set; }
    }
}
