using DomainEventsDemo.EventsHandlers;
using DomainEventsDemo.EventsModels;

namespace DomainEventsDemo
{
    public class EventDispatcher
    {
        // Helped by ChatGPT

        private readonly Dictionary<Type, List<object>> _handlers = new();

        public EventDispatcher()
        {
            RegisterHandler<UserDeletedEvent>(new DeleteUserHandler());
            RegisterHandler<UserRegisteredEvent>(new UserRegisteredHandler());
        }

        private void RegisterHandler<TEvent>(IEventHandler<TEvent> handler)
            where TEvent : IDomainEvent
        {
            var eventType = typeof(TEvent);

            if (!_handlers.ContainsKey(eventType))
                _handlers[eventType] = [];

            _handlers[eventType].Add(handler);
        }

        public void Dispatch(IEnumerable<IDomainEvent> domainEvents)
        {
            foreach (var domainEvent in domainEvents)
            {
                var eventType = domainEvent.GetType();

                if (_handlers.ContainsKey(eventType))
                {
                    foreach (var handler in _handlers[eventType])
                    {
                        var method = handler.GetType().GetMethod("Handle");
                        method?.Invoke(handler, new object[] { domainEvent });
                    }
                }
            }
        }
    }
}