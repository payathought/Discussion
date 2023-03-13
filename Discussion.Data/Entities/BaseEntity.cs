using System;

namespace Discussion.Data.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public Guid CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ModifiedById { get; set; }
        public User ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
