# ProductAPI

This project is a .NET Web API that connects to a SQL instance in a virtual machine to retrieve product details (name, price, and picture URL). The connection string is securely stored in Azure Key Vault, and product images are stored in Azure Blob Storage. The API follows the service and repository pattern for better organization and maintainability.

## Prerequisites

- .NET 6.0 SDK (or later)
- SQL Server instance running in a virtual machine
- Azure Blob Storage account
- Azure Key Vault with the connection string stored
- Visual Studio 2022 (or later) or Visual Studio Code

## Getting Started

### Setting Up Azure Resources

1. **SQL Database**: Create and set up your SQL Server instance in a virtual machine.
2. **Azure Blob Storage**: Create a storage account and upload product images.
3. **Azure Key Vault**: Store your SQL connection string as a secret in Azure Key Vault.

### Install Required NuGet Packages

```bash
dotnet add package Microsoft.Data.SqlClient
dotnet add package Microsoft.Azure.Services.AppAuthentication
dotnet add package Azure.Identity
dotnet add package Azure.Security.KeyVault.Secrets
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
```

### Configuration

1. **Key Vault Configuration**: Update the Key Vault URL in `Program.cs`.

2. **Fetch Connection String from Key Vault**: Ensure your application has the appropriate permissions to access Azure Key Vault.

## Project Structure

- **Models**: Contains the `Product` model.
- **Repositories**: Contains the repository interface and implementation for data access.
- **Services**: Contains the service interface and implementation for business logic.
- **Controllers**: Contains the API controller to handle HTTP requests.

## Endpoints

- **GET /api/products**: Retrieves a list of products with their details.

## Deployment

Deploy the API to your preferred hosting environment (e.g., Azure App Service). Ensure that the application has access to the necessary Azure resources (Key Vault, Blob Storage, SQL Server).

## Acknowledgments

- [Microsoft Data.SqlClient](https://www.nuget.org/packages/Microsoft.Data.SqlClient)
- [Azure.Identity](https://www.nuget.org/packages/Azure.Identity)
- [Azure.Security.KeyVault.Secrets](https://www.nuget.org/packages/Azure.Security.KeyVault.Secrets)
