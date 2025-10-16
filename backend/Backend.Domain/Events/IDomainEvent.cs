namespace Backend.Domain.Events;

/// <summary>
/// Marker interface for domain events.
/// 
/// TODO: Ticket #1 - Implement domain event interface
/// - Add any common properties if needed
/// - Consider adding event metadata (timestamp, event id, etc.)
/// </summary>
public interface IDomainEvent
{
    // TODO: Consider adding common properties
    // DateTimeOffset OccurredAt { get; }
    // Guid EventId { get; }
}