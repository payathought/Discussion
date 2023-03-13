using System;
using System.Collections.Generic;

namespace Discussion.Api.Models.RequestModel
{
    public class DiscussionRequestModel
    {
        public Guid Id { get; set; }
        public List<Guid> ColleaugesId { get; set; }
        public Guid ObserverId { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public string Outcomes { get; set; }
        public DateTime Date { get; set; }
    }
}
