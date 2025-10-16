namespace Backend.Domain.Events;

/// <summary>
/// Domain event raised when a new page is created.
/// 
/// TODO: Ticket #8 - Implement page created event
/// - This file already has the correct implementation
/// - Verify the properties and constructor are working correctly
/// - Test domain event raising and handling
/// </summary>
public class PageCreatedEvent : IDomainEvent
{
    public Guid PageId { get; }
    public Guid OrgId { get; }
    public Guid CreatedBy { get; }
    public string Title { get; }
    public DateTime OccurredAt { get; }

    public PageCreatedEvent(Guid pageId, Guid orgId, Guid createdBy, string title)
    {
        PageId = pageId;
        OrgId = orgId;
        CreatedBy = createdBy;
        Title = title;
        OccurredAt = DateTime.UtcNow;
    }
}
