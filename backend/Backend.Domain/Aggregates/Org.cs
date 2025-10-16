using Backend.Domain.Common;
using Backend.Domain.Entities;
using Backend.Domain.Events;
using Backend.Domain.ValueObjects;

namespace Backend.Domain.Aggregates;

/// <summary>
/// Org aggregate root representing an organization with members.
/// Part of IdentityOrg bounded context.
/// 
/// TODO: Ticket #7 - Implement organization aggregate
/// - Add properties: Id, Name, OwnerId, CreatedAt, Members collection
/// - Implement constructor with validation
/// - Add AddMember method
/// - Add RemoveMember method
/// - Implement domain events
/// </summary>
public class Org : AggregateRoot
{
    // TODO: Implement backing field for members
    // private List<Member> _members = new();

    // TODO: Implement properties
    // public Guid Id { get; private set; }
    // public string Name { get; private set; }
    // public Guid OwnerId { get; private set; }
    // public DateTimeOffset CreatedAt { get; private set; }
    // public ICollection<Member> Members => _members;

    // TODO: Implement constructor
    // public Org(string name, Guid ownerId)
    // {
    //     // Validation logic here
    //     // Add owner as first member
    // }

    // TODO: Implement AddMember method
    // public Member AddMember(Guid userId, OrgRole role)
    // {
    //     // Check if user already exists
    //     // Create new member
    //     // Add domain event
    //     // Return member
    // }

    // TODO: Implement RemoveMember method
    // public void RemoveMember(Guid userId)
    // {
    //     // Find and remove member
    //     // Add domain event
    // }

    // TODO: Implement UpdateName method
    // public void UpdateName(string name)
    // {
    //     // Validation and update logic
    // }
}