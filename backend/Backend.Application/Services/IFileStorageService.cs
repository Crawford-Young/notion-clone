namespace Backend.Application.Services;

/// <summary>
/// Service for storing and retrieving files from object storage.
/// 
/// TODO: Ticket #13 - Implement file storage service
/// - Add UploadFileAsync method
/// - Add DeleteFileAsync method
/// - Add GetPresignedUrlAsync method
/// - Support MinIO/S3 compatible storage
/// </summary>
public interface IFileStorageService
{
    // TODO: Implement UploadFileAsync method
    // Task<string> UploadFileAsync(string fileKey, Stream stream, string contentType, CancellationToken cancellationToken = default);

    // TODO: Implement DeleteFileAsync method
    // Task DeleteFileAsync(string fileKey, CancellationToken cancellationToken = default);

    // TODO: Implement GetPresignedUrlAsync method
    // Task<string> GetPresignedUrlAsync(string fileKey, int expirySeconds = 86400, CancellationToken cancellationToken = default);
}