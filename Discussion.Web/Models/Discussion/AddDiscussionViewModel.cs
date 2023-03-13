using System;
using System.Collections.Generic;

namespace Discussion.Web.Models.Discussion
{
    public class AddDiscussionViewModel
    {
        public List<Guid> ColleaugesId { get; set; }
        public Guid? ObserverId { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public string Outcomes { get; set; }
        public DateTime? Date { get; set; }
    }
}
