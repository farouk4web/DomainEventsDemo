namespace DomainEventsDemo.EventsModels
{
    public class UserDeletedEvent : IDomainEvent
    {
        public Guid UserId { get; }
        public string Reason { get; }
        public DateTime OccurredOn { get; }

        public UserDeletedEvent(Guid userId, string reason)
        {
            UserId = userId;
            Reason = reason;
            OccurredOn = DateTime.UtcNow;
        }
    }
}
