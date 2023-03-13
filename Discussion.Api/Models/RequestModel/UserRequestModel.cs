using System;

namespace Discussion.Api.Models.RequestModel
{
    public class UserRequestModel
    {
        public Guid? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
