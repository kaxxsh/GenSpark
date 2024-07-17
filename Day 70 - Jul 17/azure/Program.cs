using azure.Context;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

const string secretName = "DefaultConnection";
var keyVaultName = "productsapisecrets";
var kvUri = $"https://{keyVaultName}.vault.azure.net";
var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
var secret = await client.GetSecretAsync(secretName);
builder.Services.AddDbContext<productdbcontext>(options => options.UseSqlServer(secret.Value.Value));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
