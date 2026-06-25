# error-reporting-csharp 1.0.0, released 2026-06-25

Code Name: Publishing Improvements

## Features / Enhancements

* Updated the targeted .NET framework and package dependencies
* Improved GitHub Packages publishing workflow
* Removed Python package path extraction script
* Removed generated package output file from version control

## Dependency Updates

### `error-reporting-csharp/error-reporting-csharp.csproj`

* Updated `TargetFramework` from `netcoreapp3.1` to `net10.0`

### `error-reporting-csharp-tests/error-reporting-csharp-tests.csproj`

* Updated `TargetFramework` from `netcoreapp3.1` to `net10.0`
* Updated `Microsoft.NET.Test.Sdk` from `16.9.4` to `18.7.0`
* Updated `xunit` from `2.4.1` to `2.9.3`
* Updated `xunit.runner.console` from `2.4.1` to `2.9.3`
* Updated `xunit.runner.visualstudio` from `2.4.3` to `3.1.5`
* Updated `coverlet.collector` from `3.0.3` to `10.0.1`
