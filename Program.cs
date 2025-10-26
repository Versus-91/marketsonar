using MarketSonar.Data;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Extensions.Azure;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MarketSonarDbContext>();
builder.Services.AddAzureClients(clientBuilder => {
    clientBuilder.AddSecretClient(new Uri(builder.Configuration["KeyVault:Endpoint"]));
    clientBuilder.UseCredential(new  DefaultAzureCredential());
});
builder.Services.AddMvc(options =>options.EnableEndpointRouting = false);
var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseMvc();
// app.MapControllerRoute(name:"default",
//     pattern:"{controller= Home}/{action=Index}/{id?}");
// app.MapFallbackToFile("index.html")
// ;
app.Run();