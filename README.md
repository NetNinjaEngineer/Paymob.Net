# Paymob.Net

A comprehensive .NET client library for the Paymob payment gateway API.

## Features

- Full API coverage for Paymob's payment services
- Clean, strongly-typed request and response models
- Easy integration with ASP.NET Core via dependency injection

## Installation

```bash
dotnet add package Paymob.Net
```

## Quick Start

### ASP.NET Core Integration

Add Paymob services to your `Program.cs`:

```csharp
// Program.cs in .NET 6+
builder.Services.AddPaymob(apiKey: "YOUR_API_KEY");
```