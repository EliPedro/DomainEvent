using DomainEventsExemplo.Domain.Interfaces;

namespace DomainEventsExemplo.Domain.Handles
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}