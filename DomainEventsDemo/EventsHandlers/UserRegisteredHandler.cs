using DomainEventsDemo.EventsModels;

namespace DomainEventsDemo.EventsHandlers
{
    public class UserRegisteredHandler : IEventHandler<UserRegisteredEvent>
    {
        public void Handle(UserRegisteredEvent domainEvent)
        {
            Console.WriteLine($"[Log] User {domainEvent.UserId} registered at {domainEvent.OccurredOn}");
            Console.WriteLine($"[Log] Welcome {domainEvent.Email} in Our App");
        }
    }
}