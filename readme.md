# Releasing a new version
> dotnet build
> dotnet publish --output .\octo\
> octo pack .\octo\ --id="MongoThings.Web" --version="1.0.2"
Upload manually to http://octopus.payex.net/app#/Spaces-1/library/builtinrepository

https://octopus.com/docs/packaging-applications/creating-packages/nuget-packages/using-octo.exe#packaging-a.net-core-application