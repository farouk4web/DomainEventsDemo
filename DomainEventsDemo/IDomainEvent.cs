namespace DomainEventsDemo
{
    public interface IDomainEvent
    {
        DateTime OccurredOn { get; }
    }
}