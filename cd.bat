rmdir package
dotnet pack error-reporting-csharp --configuration Release -o package > packageoutput
::SET NUGETPACKAGEPATH

::https://stackoverflow.com/questions/108439/how-do-i-get-the-result-of-a-command-in-a-variable-in-windows
ExtractNugetPackagePath\ExtractNugetPackagePath.exe
call setnpp.bat
echo %NUGETPACKAGEPATH%
::nuget stuff
dotnet nuget add source --username pj-spoelders --password ${{ secrets.GITHUB_TOKEN }} --store-password-in-clear-text --name github "https://nuget.pkg.github.com/EXASOL/index.json"
dotnet nuget push %NUGETPACKAGEPATH% --api-key ${{ secrets.GITHUB_TOKEN }} --source "github"
