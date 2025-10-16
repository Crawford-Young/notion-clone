namespace Backend.Application.UseCases.Auth.Register;

/// <summary>
/// Command for user registration.
/// 
/// TODO: Ticket #2 - Implement register command
/// - Add properties: Email, Password, Name
/// - Add validation attributes
/// - Add constructor
/// </summary>
public record RegisterCommand(string Email, string Password, string Name);

/// <summary>
/// Result of user registration.
/// 
/// TODO: Ticket #2 - Implement register result
/// - Add properties: UserId, Email, Name, Token
/// - Add constructor
/// </summary>
public record RegisterResult(Guid UserId, string Email, string Name, string Token);
