using Backend.Domain.ValueObjects;

namespace Backend.Domain.Entities;

/// <summary>
/// Member entity representing a user's membership in an organization.
/// Part of IdentityOrg bounded context.
/// 
/// TODO: Ticket #7 - Implement member entity
/// - Add properties: Id, OrgId, UserId, Role, JoinedAt
/// - Implement constructor with validation
/// - Add UpdateRole method
/// - Add private constructor for EF Core
/// </summary>
public class Member
{
    // TODO: Implement properties
    // public Guid Id { get; private set; }
    // public Guid OrgId { get; private set; }
    // public Guid UserId { get; private set; }
    // public OrgRole Role { get; private set; }
    // public DateTimeOffset JoinedAt { get; private set; }

    // TODO: Implement constructor
    // public Member(Guid orgId, Guid userId, OrgRole role)
    // {
    //     // Validation logic here
    // }

    // TODO: Implement UpdateRole method
    // public void UpdateRole(OrgRole newRole)
    // {
    //     // Update logic here
    // }

    // TODO: Add private constructor for EF Core
    // private Member() { }
}