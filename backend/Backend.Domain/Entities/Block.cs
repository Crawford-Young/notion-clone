using Backend.Domain.Aggregates;
using Backend.Domain.ValueObjects;

namespace Backend.Domain.Entities;

/// <summary>
/// Block entity representing a block of content within a page.
/// Part of Documents bounded context.
/// 
/// TODO: Ticket #9 - Implement block entity
/// - Add properties: Id, PageId, ParentBlockId, SortKey, Type, Json
/// - Implement constructor with validation
/// - Add UpdateType method
/// - Add UpdateSortKey method
/// - Add UpdateJson method
/// </summary>
public class Block
{
    // TODO: Implement properties
    // public Guid Id { get; private set; }
    // public Guid PageId { get; private set; }
    // public Guid? ParentBlockId { get; private set; }
    // public SortKey SortKey { get; private set; }
    // public BlockType Type { get; private set; }
    // public string? Json { get; private set; }

    // TODO: Implement constructor
    // public Block(Guid pageId, SortKey sortKey, BlockType type, Guid? parentBlockId, string? json)
    // {
    //     // Validation logic here
    // }

    // TODO: Implement UpdateType method
    // public void UpdateType(BlockType newType)
    // {
    //     // Update logic here
    // }

    // TODO: Implement UpdateSortKey method
    // public void UpdateSortKey(SortKey newSortKey)
    // {
    //     // Update logic here
    // }

    // TODO: Implement UpdateJson method
    // public void UpdateJson(string? json)
    // {
    //     // Update logic here
    // }

    // TODO: Add private constructor for EF Core
    // private Block() { }
}