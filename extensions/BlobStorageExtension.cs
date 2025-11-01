using Azure.Security.KeyVault.Secrets;
using Azure.Storage.Blobs;

namespace MarketSonar.extensions;

public static class BlobStorageExtension
{
    public static void AddBlobStorage(this IServiceCollection services) {
        services.AddSingleton<BlobServiceClient>(provider =>
        {
            var serviceClient = provider.GetService<SecretClient>();
            var storageConnectionString = serviceClient?.GetSecret("StorageDeckConnectionString");
            return new BlobServiceClient(
                storageConnectionString?.Value.Value
            );
        });
    }
}