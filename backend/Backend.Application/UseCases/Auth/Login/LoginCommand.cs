namespace Backend.Application.UseCases.Auth.Login;

/// <summary>
/// Command for user login.
/// 
/// TODO: Ticket #2 - Implement login command
/// - Add properties: Email, Password
/// - Add validation attributes
/// - Add constructor
/// </summary>
public record LoginCommand(string Email, string Password);

/// <summary>
/// Result of user login.
/// 
/// TODO: Ticket #2 - Implement login result
/// - Add properties: UserId, Email, Name, Token
/// - Add constructor
/// </summary>
public record LoginResult(Guid UserId, string Email, string Name, string Token);
