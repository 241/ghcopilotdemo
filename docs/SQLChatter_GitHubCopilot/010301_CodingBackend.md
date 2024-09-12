---
title: 3.1. Coding .NET Core Web API Project (Backend)
layout: home
nav_order: 1
parent: '3. Coding the SQLChatter Project with Copilot'
grand_parent: 'SQL Chatter Project (GitHub Copilot Version)'
---

#### 3.1. Coding .NET Core Web API Project (Backend):

* Prepare a prompt by using the requirements in the before section (Step 3), and ask to GitHub Copilot. For example:

    ```
    Create a .NET Core Web API project. This project should be in a microservices architecture.

    In this Web API, I want to be able to send a query to an existing Azure SQL Database and receive the response. In the project you create, do not use a specific table model, as the columns in my tables can have any data type, including null. Please code accordingly.
    ```

* GitHub Copilot will prepare a project with the source code. Try to follow all the steps and try to create and code the .NET Core Web API project.

   _**Note:** Please remember that GitHub Copilot may provide different answers to each question you ask, so don't expect the same response every time. And please note that you can use GitHub Copilot for every problem you encounter while coding. You can even send runtime errors directly to GitHub Copilot and get a solution._

   ![Backend](./CopilotImages/Backend.png)

* If you want to use a pre-built .NET Core Web API backend project, you can download it from here. //TODO: link verilecek
  * In the **"appsettings.json"** file and find the "AzureSqlDatabase" object:

      ![ConnectionString](./CopilotImages/ConnectionString.png)
  
  * Update above code in **"appsettings.json"** file with the following detailed information from Azure Portal:

     * In the Azure Portal, go to the SQL Databases and find your created database named **"AIChatterDB "**.
     * Under the "Connection strings" menu in the left, copy "ADO.NET (SQL authentication)" connection string and replace the "AzureSqlDatabase" value in **"appsettings.json"** file.

  * You should install the required Nuget packages into your solution:

     ```dotnet restore```

  * You can run your Web API project and validate the service by testing its endpoints directly within the Swagger UI, which will automatically generate the API documentation and allow for real-time interaction with your API. For this, use these 2 commands:
     
     ```dotnet build```

     ```dotnet run```

      ![SwaggerWebapi](./CopilotImages/SwaggerWebapi.png)

  * If you prefer to call your Web API using Postman, your endpoint url will be ```https://localhost:7029/SQLChatter/execute-query``` and you should use "POST" method: 

      The header parameters are:

      ![PostmanHeaders](./CopilotImages/PostmanHeaders.png) 

      The body and the result:

      ![PostmanResult](./CopilotImages/PostmanResult.png) 

  * Now, your Web API is ready to run the SQL Queries which comes from frontend.

&nbsp;
> Please continue to next step: [3.2. Coding Blazor Web App Project (Frontend))](https://241.github.io/ghcopilotdemo/SQLChatter_GitHubCopilot/010302_CodingFrontend.html).