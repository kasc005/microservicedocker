using System;
namespace CA.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid Id { get; }

        public Guid UserId { get; }

        public string Category { get; }

        public string Name { get; }

        public string Description { get; }

        public DateTime CreatedDate { get; }

        public ActivityCreated() 
        {
            
        }

        public ActivityCreated(Guid id, Guid userId, string category,
                              string name, string description, DateTime createdDate) 
        {
            this.Id = id;
            this.UserId = userId;
            this.Category = category;
            this.Name = name;
            this.Description = description;
            this.CreatedDate = createdDate;
        }
    }
}
