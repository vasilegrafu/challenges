dotnet new --install NUnit3.DotNetNew.Template

dotnet new nunit --name ds_a
dotnet add ds_a/ds_a.csproj reference ../../../devfx.net/solution/DevFX/DevFX.csproj

dotnet new nunit --name practice
dotnet add practice/practice.csproj reference ../../../devfx.net/solution/DevFX/DevFX.csproj

dotnet new nunit --name contests
dotnet add contests/contests.csproj reference ../../../devfx.net/solution/DevFX/DevFX.csproj
