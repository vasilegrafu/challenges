dotnet new --install NUnit3.DotNetNew.Template

dotnet new nunit --name practice
dotnet new nunit --name contests
dotnet add practice/practice.csproj reference ../../../devfx.net/solution/DevFX/DevFX.csproj
dotnet add contests/contests.csproj reference ../../../devfx.net/solution/DevFX/DevFX.csproj
