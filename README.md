# error-reporting-csharp

[![.NET](https://github.com/exasol/error-reporting-csharp/actions/workflows/dotnet.yml/badge.svg)](https://github.com/exasol/error-reporting-csharp/actions/workflows/dotnet.yml)
## Description

Contains a C# library for describing errors.

Based on https://github.com/exasol/error-reporting-java

Major difference is this library is simplified by the string interpolation feature available in the C# language.

## Installation

- Make sure you have the .NET core SDK (use the dotnet SDK installation step on GitHub runners).

- You'll need to add the Exasol Github NuGet repository to the NuGet package manager on your local machine or the GitHub CI runner, like so: 
   - On GitHub CI runners:
	```dotnet nuget add source --username <username/or ci user> --password ${{ secrets.GITHUB_TOKEN }} --store-password-in-clear-text --name github "https://nuget.pkg.github.com/EXASOL/index.json"```
   - You can use a GitHub PAT on your local system:
    ```dotnet nuget add source --username <username/or ci user> --password <yourPAT> --store-password-in-clear-text --name github "https://nuget.pkg.github.com/EXASOL/index.json"```

- You can then add the package to your projects: `$ dotnet add <PROJECT> package error-reporting-csharp --version 0.2.0`
## Usage

### Simple Messages

Simple error messages consist out of the message builder helper method which specifies an identifier and one or more messages describing the error.
```csharp
ExaError.MessageBuilder("E-TEST-1").Message("Something went wrong.").ToString();
```

Result: `E-TEST-1: Something went wrong.`

### String Interpolation

Since C# has string interpolation you should use that in messages and mitigations where needed, instead of parameters (which are currently not supported):

```csharp
ExaError.MessageBuilder("E-TEST-2")
    .Message($"Unknown input: '{input}'.").ToString();
```

Result: `E-TEST-2: Unknown input: 'unknown'.`

### Mitigations

The mitigations describe actions the user can take to resolve the error. Here is an example of a mitigation definition:

```csharp
ExaError.MessageBuilder("E-TEST-2")
    .Message("Not enough space on device.")
    .Mitigation("Delete something.")
    .ToString();
```

Result:

    `E-TEST-2: Not enough space on device. Delete something.`

You can use string interpolation in mitigations as well.

```csharp
ExaError.MessageBuilder("E-TEST-2")
    .Message($"Not enough space on device {device}.")
    .Mitigation($"Delete something from {device}.")
    .ToString();
```

Result: 

    `E-TEST-2: Not enough space on device '/dev/sda1'. Delete something from '/dev/sda1'.`

You can chain `Mitigation` definitions if you want to tell the users that there is more than one solution.

```csharp
ExaError.MessageBuilder("E-TEST-2")
    .Message("Not enough space on device.")
    .Mitigation("Delete something.")
    .Mitigation("Create larger partition.")
    .ToString();
```

Result:

    ```E-TEST-2: Not enough space on device. Known mitigations:
    * Delete something.
    * Create larger partition.```

## Information for Users

- [Changelog](doc/changes/changelog.md)
