using DomainEventsDemo.EventsModels;

namespace DomainEventsDemo.EventsHandlers
{
    public class DeleteUserHandler : IEventHandler<UserDeletedEvent>
    {
        public void Handle(UserDeletedEvent domainEvent)
        {
            Console.WriteLine($"Handling UserDeletedEvent for UserId: {domainEvent.UserId}, OccurredOn: {domainEvent.OccurredOn}");
        }
    }
}