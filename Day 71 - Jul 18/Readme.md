# Azure Resource Manager (ARM) Templates for SQL Server and Key Vault

This repository contains ARM templates for deploying an Azure SQL Server and an Azure Key Vault, and for storing the SQL Server connection string in the Key Vault as a secret.

## Prerequisites

Before deploying these templates, ensure you have:

- An Azure account
- Azure CLI or Azure PowerShell installed
- Necessary permissions to create resources in your Azure subscription

## Templates

### 1. Azure SQL Server Template

The `azure-sql-server.json` template deploys an Azure SQL Server.

**Parameters:**
- `sqlServerName`: The name of the SQL Server.
- `adminLogin`: The administrator login for the SQL Server.
- `adminPassword`: The administrator password for the SQL Server.

### 2. Azure Key Vault Template

The `azure-key-vault.json` template deploys an Azure Key Vault and stores the SQL Server connection string as a secret.

**Parameters:**
- `keyVaultName`: The name of the Key Vault.
- `sqlServerName`: The name of the SQL Server (used to construct the connection string).
- `adminLogin`: The administrator login for the SQL Server (used to construct the connection string).
- `adminPassword`: The administrator password for the SQL Server (used to construct the connection string).

## Deployment Instructions

### Deploy Azure SQL Server

1. Open a terminal or PowerShell window.
2. Navigate to the directory containing the `azure-sql-server.json` template.
3. Run the following command to deploy the SQL Server:

    ```sh
    az deployment group create --resource-group <ResourceGroupName> --template-file azure-sql-server.json --parameters sqlServerName=<YourSqlServerName> adminLogin=<YourAdminLogin> adminPassword=<YourAdminPassword>
    ```

### Deploy Azure Key Vault and Add SQL Connection String

1. Open a terminal or PowerShell window.
2. Navigate to the directory containing the `azure-key-vault.json` template.
3. Run the following command to deploy the Key Vault and add the SQL connection string as a secret:

    ```sh
    az deployment group create --resource-group <ResourceGroupName> --template-file azure-key-vault.json --parameters keyVaultName=<YourKeyVaultName> sqlServerName=<YourSqlServerName> adminLogin=<YourAdminLogin> adminPassword=<YourAdminPassword>
    ```

## Notes

- Replace `<ResourceGroupName>`, `<YourSqlServerName>`, `<YourAdminLogin>`, `<YourAdminPassword>`, and `<YourKeyVaultName>` with your actual values.
- Ensure the SQL Server and Key Vault names are unique within your Azure subscription.
- Follow best practices for managing and securing your Azure resources.


