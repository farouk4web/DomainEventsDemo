using DomainEventsDemo.Entites;

namespace DomainEventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dispatcher = new EventDispatcher();

            var user = new User("example@email.com");
            user.Delete();

            var events = user.PullDomainEvents();
            dispatcher.Dispatch(events);

            Console.WriteLine("All domain events handled.");
        }
    }
}
