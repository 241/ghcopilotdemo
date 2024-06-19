---
title: Building SQL Chatter Project
layout: home
nav_order: 3
---

# Building The SQL Chatter Project

## Prerequisites

Before you begin, ensure you have the following installed:

- [Visual Studio Code](https://code.visualstudio.com/)
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- An active Azure subscription with Azure OpenAI and Azure SQL Database resources created

## Steps to Build the Project

1. **Clone the Repository:**

Open your terminal and clone the repository using the following command:
```
git clone https://github.com/241/ghcopilotdemo.git
```


Navigate to the project directory:
cd sql-chatter


2. **Open the Project in Visual Studio Code:**
Launch Visual Studio Code and open the project directory:
    
    
    
3. **Update `appsettings.json`:**

    Open the `appsettings.json` file and update it with your Azure OpenAI and Azure SQL Database credentials:
    
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "AzureOpenAI": {
    "Endpoint": "https://###.openai.azure.com/",
    "Key": "###",
    "DeploymentName": "###"
  },
  "SQL": {
    "Server": "###.database.windows.net",
    "Database": "###",
    "User": "###",
    "Password": "###"
  }
}

```


4. **Access the Application:**

    Open your browser and navigate to `http://localhost:5000` (or the appropriate URL) to access the application.

## Additional Configuration

- **Environment Variables:**

    You can also set the Azure OpenAI and SQL Database credentials using environment variables. This is useful for production environments.

- **Logging:**

    Ensure logging is configured properly in `appsettings.json` to help with debugging and monitoring.

## Conclusion

You have successfully built and run the SQL Chatter Project. For any issues or further customization, refer to the official documentation or contact the project maintainers.

For more detailed information, refer to the official documentation:
- [Azure OpenAI Service](https://docs.microsoft.com/en-us/azure/cognitive-services/openai/)
- [Azure SQL Database](https://docs.microsoft.com/en-us/azure/azure-sql/database/)
