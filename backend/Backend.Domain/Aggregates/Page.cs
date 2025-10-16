using Backend.Domain.Common;
using Backend.Domain.Entities;
using Backend.Domain.Events;
using Backend.Domain.ValueObjects;

namespace Backend.Domain.Aggregates;

/// <summary>
/// Page aggregate root representing a document page with collaborative editing support.
/// Part of Documents bounded context.
/// 
/// TODO: Ticket #8 - Implement page aggregate
/// - Add properties: Id, OrgId, Title, CreatedBy, CreatedAt, Blocks collection
/// - Implement constructor with validation
/// - Add AddBlock method
/// - Add RemoveBlock method
/// - Add UpdateTitle method
/// - Implement domain events
/// </summary>
public class Page : AggregateRoot
{
    // TODO: Implement backing field for blocks
    // private List<Block> _blocks = new();

    // TODO: Implement properties
    // public Guid Id { get; private set; }
    // public Guid OrgId { get; private set; }
    // public string Title { get; private set; }
    // public Guid CreatedBy { get; private set; }
    // public DateTimeOffset CreatedAt { get; private set; }
    // public ICollection<Block> Blocks => _blocks;

    // TODO: Implement constructor
    // public Page(Guid orgId, string title, Guid createdBy)
    // {
    //     // Validation logic here
    // }

    // TODO: Implement AddBlock method
    // public Block AddBlock(BlockType type, Guid? parentBlockId, string? json)
    // {
    //     // Create new block
    //     // Add to collection
    //     // Add domain event
    //     // Return block
    // }

    // TODO: Implement RemoveBlock method
    // public void RemoveBlock(Guid blockId)
    // {
    //     // Find and remove block
    //     // Add domain event
    // }

    // TODO: Implement UpdateTitle method
    // public void UpdateTitle(string title)
    // {
    //     // Validation and update logic
    // }
}