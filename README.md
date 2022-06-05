# .NET 7 Preview Demos :rocket:

This project includes `some`  of the preview feature demos to be released with .NET 7 and C# 11.

For the full set of features please visit,

- What's new in C# 11 - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11
- ASP.NET Core updates in .NET 7 Preview 4 - https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-4
- What's new in .NET 7 Preview 4 [WIP] - https://github.com/dotnet/core/issues/7378

## Prerequisites :speech_balloon:
To try out features in this solution, you need to install,

- .NET 7.0 (in preview as at 2022.06.05) - https://dotnet.microsoft.com/en-us/download/dotnet/7.0
- Visual Studio Code - https://code.visualstudio.com/
- k6 Open Source - https://k6.io/open-source/

## What's in here? :roll_eyes:

Following new features are discussed in this project.

- Required members - https://github.com/dotnet/csharplang/blob/main/proposals/required-members.md#detailed-design
- MemoryCache metrics - https://github.com/dotnet/runtime/issues/50406
- Microseconds and Nanoseconds to TimeSpan, DateTime, DateTimeOffset, and TimeOnly - https://github.com/dotnet/runtime/issues/23799
- New APIs for RegularExpressions - https://github.com/dotnet/runtime/issues/59629, https://github.com/dotnet/runtime/issues/65011
- Infer API controller action parameters that come from services - https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-2/#infer-api-controller-action-parameters-that-come-from-services
- Rate limiting middleware - https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-4/#rate-limiting-middleware
- INumber interface (not released with .NET 6) - https://github.com/dotnet/sdk/issues/23073

## Before you start :coffee:
`DotNet7Demos` is a console application and `DotNet7DemosWeb` is a web api project. Web api project contains the demos for `Rate limiting middleware` and `Infer API controller action parameters that come from services`.
Other demos are contained within the console application. Please check [Program.cs](./DotNet7Demos/Program.cs)

If you want to run the `Rate limiting middleware` test (in [`concurrency-users-test.js`](./DotNet7DemosWeb/concurrency-users-test.js)), install `k6` from the link in the prerequisites section and execute following command in the directory.
```
k6 run .\concurrency-users-test.js
```

## Additional :anger:
Breaking changes in .NET 7 - https://docs.microsoft.com/en-us/dotnet/core/compatibility/7.0#aspnet-core


