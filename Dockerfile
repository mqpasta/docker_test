from mcr.microsoft.com/dotnet/runtime:2.1 as base
workdir /app

copy docker_test/bin/Release/netcoreapp2.1/. ./

entrypoint ["dotnet","dockert_test.dll"]
