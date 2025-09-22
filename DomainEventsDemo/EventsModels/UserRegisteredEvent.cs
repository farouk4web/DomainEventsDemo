namespace DomainEventsDemo.EventsModels
{
    public class UserRegisteredEvent : IDomainEvent
    {
        public Guid UserId { get; }
        public string Email { get; }
        public DateTime OccurredOn { get; }

        public UserRegisteredEvent(Guid userId, string email)
        {
            UserId = userId;
            Email = email;
            OccurredOn = DateTime.UtcNow;
        }
    }
}
