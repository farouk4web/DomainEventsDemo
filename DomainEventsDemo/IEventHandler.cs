namespace DomainEventsDemo
{
    public interface IEventHandler<TEvent> where TEvent : IDomainEvent
    {
        void Handle(TEvent domainEvent);
    }
}