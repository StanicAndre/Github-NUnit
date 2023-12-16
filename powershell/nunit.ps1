cd NUnitTestProject

dotnet restore
dotnet build
dotnet test --logger trx --results-directory "TestResults"
  
