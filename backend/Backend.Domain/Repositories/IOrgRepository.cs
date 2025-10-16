using Backend.Domain.Aggregates;

namespace Backend.Domain.Repositories;

/// <summary>
/// Repository interface for Org aggregate.
/// 
/// TODO: Ticket #7 - Implement organization repository interface
/// - Add GetByIdAsync method
/// - Add GetByOwnerIdAsync method
/// - Add AddAsync method
/// - Add UpdateAsync method
/// - Add DeleteAsync method
/// </summary>
public interface IOrgRepository
{
    // TODO: Implement GetByIdAsync method
    // Task<Org?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    // TODO: Implement GetByOwnerIdAsync method
    // Task<IEnumerable<Org>> GetByOwnerIdAsync(Guid ownerId, CancellationToken cancellationToken = default);

    // TODO: Implement AddAsync method
    // Task AddAsync(Org org, CancellationToken cancellationToken = default);

    // TODO: Implement UpdateAsync method
    // Task UpdateAsync(Org org, CancellationToken cancellationToken = default);

    // TODO: Implement DeleteAsync method
    // Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}