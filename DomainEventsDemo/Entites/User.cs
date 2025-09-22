using DomainEventsDemo.EventsModels;

namespace DomainEventsDemo.Entites
{
    public class User(string email)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Email { get; private set; } = email;

        private List<IDomainEvent> DomainEvents { get; set; } = new();


        // important Events 
        public void Register()
        {
            Console.WriteLine("Registering user...");

            // Insert New User to Database Logic Here

            // Raise Domain Event
            DomainEvents.Add(new UserRegisteredEvent(Id, Email));
        }

        public void Delete()
        {
            Console.WriteLine("Delete user...");

            // Insert New User to Database Logic Here

            // Raise Domain Event
            DomainEvents.Add(new UserDeletedEvent(Id, "User requested account deletion."));
        }

        public List<IDomainEvent> PullDomainEvents()
        {
            var events = new List<IDomainEvent>(DomainEvents);
            DomainEvents.Clear();

            return events;
        }
    }
}