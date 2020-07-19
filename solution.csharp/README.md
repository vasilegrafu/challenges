//----------------------------------------------------------------
To compile and run projects in this solution you need to have installed .net core (like dotnet-sdk-3.1.301-win-x64).
Also you need to include the path to PATH environment variable.


//----------------------------------------------------------------
Create classlib project:

dotnet new classlib --name project_name --framework netcoreapp3.1

//----------------------------------------------------------------
Create console project:

dotnet new console --name project_name --framework netcoreapp3.1

//----------------------------------------------------------------
Create nunit project:

dotnet new --install NUnit3.DotNetNew.Template
dotnet new nunit --name project_name --framework netcoreapp3.1

//----------------------------------------------------------------
Add references:

dotnet add project_name.csproj reference ../../../devfx.net/solution/DevFX/DevFX.csproj


