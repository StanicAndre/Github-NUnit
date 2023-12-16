param(
    [Parameter(Position=0, Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [string]
    $repo_path
)

cd NUnitTestProject

dotnet restore
dotnet build
dotnet test --logger trx --results-directory "TestResults"
  
