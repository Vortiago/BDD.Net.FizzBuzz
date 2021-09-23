# BDD.Net.FizzBuzz

Sample project for testing out SpecFlow test with a Fizz Buzz console application.

## Steps to reproduce:
Create two folders:

Console and Test

Create respective projects:

``` 
dotnet new console
dotnet new xunit
```

Add reference to console in the test project and add specflow nuget package.

```
dotnet add reference ..\console\console.csproj
dotnet add package SpecFlow.XUnit
dotnet add package SpecFlow.Plus.LivingDocPlugin
```

Write feature file and run dotnet test.

Make binding and test code. To check living doc:

```
dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
livingdoc.exe test-assembly .\Tests.dll -t .\TestExecution.json
```
