using Backend.Domain.ValueObjects;

namespace Backend.Domain.Entities;

/// <summary>
/// User entity representing a user account.
/// Part of IdentityOrg bounded context.
/// 
/// TODO: Ticket #2 - Implement user entity with proper validation
/// - Add properties: Id, Email, Name, PasswordHash, CreatedAt
/// - Implement constructor with validation
/// - Add UpdateName method
/// - Add private constructor for EF Core
/// </summary>
public class User
{
    // TODO: Implement properties
    // public Guid Id { get; private set; }
    // public Email Email { get; private set; }
    // public string Name { get; private set; }
    // public string PasswordHash { get; private set; }
    // public DateTimeOffset CreatedAt { get; private set; }

    // TODO: Implement constructor with validation
    // public User(Email email, string name, string passwordHash)
    // {
    //     // Validation logic here
    // }

    // TODO: Implement UpdateName method
    // public void UpdateName(string name)
    // {
    //     // Validation and update logic here
    // }

    // TODO: Add private constructor for EF Core
    // private User() { }
}