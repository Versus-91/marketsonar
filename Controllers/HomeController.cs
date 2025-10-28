using Azure;
using Azure.Security.KeyVault.Secrets;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MarketSonar.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HomeController(SecretClient secretClient,BlobServiceClient storageService,ILogger<HomeController> logger): ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Upload(IFormFile file,CancellationToken cancellationToken)
    {
        await using Stream stream = file.OpenReadStream();
        var blobContainerClient =  storageService.GetBlobContainerClient("images");
        await blobContainerClient.CreateIfNotExistsAsync(publicAccessType:PublicAccessType.Blob,cancellationToken: cancellationToken);
        try
        {
            var storageResult = await blobContainerClient.UploadBlobAsync(file.FileName, stream, cancellationToken);
            return Ok(storageResult);
        }
        catch (RequestFailedException e)
        {
            logger.LogError(e.ToString());
            return BadRequest(e.Message);
        }
        
    }
}