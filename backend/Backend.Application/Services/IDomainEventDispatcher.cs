using Backend.Domain.Events;

namespace Backend.Application.Services;

/// <summary>
/// Service for dispatching domain events.
/// 
/// TODO: Ticket #1 - Implement domain event dispatcher
/// - Add DispatchAsync method
/// - Add DispatchEventsAsync method
/// - Handle event processing and cleanup
/// </summary>
public interface IDomainEventDispatcher
{
    // TODO: Implement DispatchAsync method
    // Task DispatchAsync(IDomainEvent domainEvent, CancellationToken cancellationToken = default);

    // TODO: Implement DispatchEventsAsync method
    // Task DispatchEventsAsync(IEnumerable<IDomainEvent> domainEvents, CancellationToken cancellationToken = default);
}