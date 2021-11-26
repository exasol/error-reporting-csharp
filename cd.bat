rmdir package
dotnet pack error-reporting-csharp --configuration Release -o package > packageoutput
::SET NUGETPACKAGEPATH

::https://stackoverflow.com/questions/108439/how-do-i-get-the-result-of-a-command-in-a-variable-in-windows
ExtractNugetPackagePath\ExtractNugetPackagePath.exe
call setnpp.bat
echo %NUGETPACKAGEPATH%

