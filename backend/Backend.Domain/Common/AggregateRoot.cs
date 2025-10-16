using Backend.Domain.Events;

namespace Backend.Domain.Common;

/// <summary>
/// Base class for aggregate roots.
/// 
/// TODO: Ticket #1 - Implement aggregate root base class
/// - Add domain events collection
/// - Add AddDomainEvent method
/// - Add ClearDomainEvents method
/// - Add GetDomainEvents method
/// </summary>
public abstract class AggregateRoot
{
    // TODO: Implement backing field for domain events
    // private readonly List<IDomainEvent> _domainEvents = new();

    // TODO: Implement DomainEvents property
    // public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    // TODO: Implement AddDomainEvent method
    // protected void AddDomainEvent(IDomainEvent domainEvent)
    // {
    //     _domainEvents.Add(domainEvent);
    // }

    // TODO: Implement ClearDomainEvents method
    // public void ClearDomainEvents()
    // {
    //     _domainEvents.Clear();
    // }

    // TODO: Implement GetDomainEvents method
    // public IReadOnlyCollection<IDomainEvent> GetDomainEvents()
    // {
    //     return _domainEvents.AsReadOnly();
    // }
}