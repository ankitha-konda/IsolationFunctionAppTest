# Isolation Function App Test

This project demonstrates an Azure Function using the **isolated worker model** with **ASP.NET Core integration**.

## Architecture

This function app uses:
- **.NET 8.0** runtime
- **Azure Functions v4** 
- **Isolated process model** (`dotnet-isolated`)
- **ASP.NET Core integration** for familiar web development patterns

## Pattern Used

The function uses ASP.NET Core integration pattern which allows:
- `HttpRequest` and `HttpResponse` from ASP.NET Core
- `IActionResult` return types
- Familiar ASP.NET Core middleware and dependency injection patterns

This is enabled by:
- `Microsoft.Azure.Functions.Worker.Extensions.Http.AspNetCore` package
- `ConfigureFunctionsWebApplication()` in Program.cs

## Local Development

### Prerequisites
- .NET 8.0 SDK
- Azure Functions Core Tools v4

### Running Locally
```bash
func start
```

**Note**: This function cannot be run with `dotnet run` directly. It requires the Azure Functions Core Tools to properly handle the gRPC communication between the host and isolated worker process.

## Project Structure

- `Function1.cs` - HTTP trigger function using ASP.NET Core integration
- `Program.cs` - Application startup and dependency injection configuration
- `host.json` - Functions host configuration
- `local.settings.json` - Local development settings

## Issues Fixed

1. **Target Framework**: Updated from .NET 6.0 to .NET 8.0 for compatibility
2. **Missing Configuration**: Added `local.settings.json` with proper isolated worker settings
3. **Documentation**: Added proper using statements and comments for clarity