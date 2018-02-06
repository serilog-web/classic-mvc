# SerilogWeb.Classic.Mvc [![Build status](https://ci.appveyor.com/api/projects/status/3yidmjq6pm0f2pii?svg=true)](https://ci.appveyor.com/project/serilog-web/classic-mvc)

ASP.NET MVC support for [SerilogWeb.Classic](https://github.com/serilog-web/classic).

*Package* - <a href="https://www.nuget.org/packages/serilogweb.classic.mvc">SerilogWeb.Classic.Mvc</a> | Platforms - .NET 4.5

_This package is designed for full framework ASP.NET applications. For ASP.NET Core, have a look at [Serilog.AspNetCore](https://github.com/serilog/serilog-aspnetcore)_

This package is used in conjunction with _SerilogWeb.Classic_ and adds ASP.NET MVC specific enrichers.

## Enrichers
The following enrichers are available in the `SerilogWeb.Classic.Mvc.Enrichers` namespace:
- **MvcActionNameEnricher** : adds a property `MvcAction` containing the name of the *Action* being executed in the *MVC Controller*
- **MvcControllerNameEnricher** : adds a property `MvcController` containing the name of the *Controller* in which a *MVC Action* has executed
- **MvcRouteDataEnricher** : adds a property `MvcRouteData` containing the dictionary of the *RouteData*
- **MvcRouteTemplateEnricher** : adds a property `MvcRouteTemplate` containing the *route template* selected by Mvc routing


Usage : 

```csharp
var log = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.With<MvcRouteTemplateEnricher>()
    .Enrich.With<MvcActionNameEnricher>()
    .CreateLogger();
```

To override the property name of the added property:

```csharp
var log = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.With(new MvcRouteTemplateEnricher("RouteTemplate")
    .CreateLogger();
```

