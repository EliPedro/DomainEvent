using DomainEventsExemplo.Domain.Handles;
using DomainEventsExemplo.Domain.Interfaces;

namespace DomainEventsExemplo.Domain.Events
{
    public class DomainEvents
    {
        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            var handles = Bootstrap.GetContainer().GetAllInstances<IHandle<T>>();
            foreach (var handle in handles)
                handle.Handle(evento);
        }
    }
}