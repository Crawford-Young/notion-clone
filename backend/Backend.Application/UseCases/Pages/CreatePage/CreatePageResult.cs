namespace Backend.Application.UseCases.Pages.CreatePage;

/// <summary>
/// Result of creating a page.
/// 
/// TODO: Ticket #8 - Implement create page result
/// - Add properties: Id, OrgId, Title, CreatedBy, CreatedAt
/// - Add constructor
/// </summary>
public record CreatePageResult(
    Guid Id,
    Guid OrgId,
    string Title,
    Guid CreatedBy,
    DateTimeOffset CreatedAt
);
