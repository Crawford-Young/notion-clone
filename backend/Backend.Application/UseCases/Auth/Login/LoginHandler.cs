using Backend.Application.Services;
using Backend.Domain.Repositories;
using Backend.Domain.ValueObjects;

namespace Backend.Application.UseCases.Auth.Login;

/// <summary>
/// Handler for user login use case.
/// 
/// TODO: Ticket #2 - Implement login handler
/// - Add constructor with dependencies
/// - Implement HandleAsync method
/// - Add user lookup logic
/// - Add password verification
/// - Add JWT token generation
/// </summary>
public class LoginHandler
{
    // TODO: Implement constructor with dependencies
    // private readonly IUserRepository _userRepository;
    // private readonly IPasswordHasher _passwordHasher;
    // private readonly IJwtTokenGenerator _jwtTokenGenerator;

    // public LoginHandler(
    //     IUserRepository userRepository,
    //     IPasswordHasher passwordHasher,
    //     IJwtTokenGenerator jwtTokenGenerator)
    // {
    //     _userRepository = userRepository;
    //     _passwordHasher = passwordHasher;
    //     _jwtTokenGenerator = jwtTokenGenerator;
    // }

    // TODO: Implement HandleAsync method
    // public async Task<LoginResult> HandleAsync(
    //     LoginCommand command,
    //     CancellationToken cancellationToken = default)
    // {
    //     // Validate email format
    //     // Find user by email
    //     // Verify password
    //     // Generate JWT token
    //     // Return result
    // }
}
