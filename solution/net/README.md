To compile and run projects in this solution you need to have installed .net core (like dotnet-sdk-2.1.401-win-x64).
Also you need to include the path to PATH environment variable.

To install NUnit templates in the dotnet framework installation please run: 
dotnet new --install NUnit3.DotNetNew.Template

To create a .net project please run:
dotnet new nunit --name project_name
dotnet add project_name/project_name.csproj reference ../../../devfx.net/solution/DevFX/DevFX.csproj


