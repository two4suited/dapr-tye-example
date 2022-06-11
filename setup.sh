#/bin/bash
dotnet new sln -n Example
mkdir src
cd src
dotnet new blazorserver -n frontend
dotnet new webapi -minimal --no-https -o backend
cd ..
dotnet sln add src/frontend
dotnet sln add src/backend