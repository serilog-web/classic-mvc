# SerilogWeb.Classic.Mvc [![Build status](https://ci.appveyor.com/api/projects/status/3yidmjq6pm0f2pii?svg=true)](https://ci.appveyor.com/project/serilog-web/classic-mvc)

>  **Deprecation notice:** this package is no longer maintained. The world has moved on to ASP.NET Core. Take a look at [Serilog.AspNetCore](https://github.com/serilog/serilog-aspnetcore) instead!

ASP.NET MVC support for [SerilogWeb.Classic](https://github.com/serilog-web/classic).

*Package* - <a href="https://www.nuget.org/packages/serilogweb.classic.mvc">SerilogWeb.Classic.Mvc</a> | Platforms - .NET 4.5

_This package is designed for full framework ASP.NET applications. For ASP.NET Core, have a look at [Serilog.AspNetCore](https://github.com/serilog/serilog-aspnetcore)_

This package is used in conjunction with _SerilogWeb.Classic_ and adds ASP.NET MVC specific enrichers.

## Enrichers
The following enrichers are available as extension methods from the `LoggerConfiguration.Enrich` API:
- **WithMvcActionName** : adds a property `MvcAction` containing the name of the *Action* being executed in the *MVC Controller*
- **WithMvcControllerName** : adds a property `MvcController` containing the name of the *Controller* in which a *MVC Action* has executed
- **WithMvcRouteData** : adds a property `MvcRouteData` containing the dictionary of the *RouteData*
- **WithMvcRouteTemplate** : adds a property `MvcRouteTemplate` containing the *route template* selected by Mvc routing


Usage : 

```csharp
var log = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.WithMvcRouteTemplate()
    .Enrich.WithMvcActionName()
    .CreateLogger();
```

To override the property name of the added property:

```csharp
var log = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.WithMvcRouteTemplate("RouteTemplate")
    .CreateLogger();
```

Enrichers can also be defined in a configuration file by using [Serilog.Settings.AppSettings](https://github.com/serilog/serilog-settings-appsettings) as follows:

```xml
<appSettings>
    <add key="serilog:using:SerilogWeb.Classic.Mvc" value="SerilogWeb.Classic.Mvc"/>
    <add key="serilog:enrich:WithMvcActionName"/>
    <add key="serilog:enrich:WithMvcControllerName"/>
    <add key="serilog:enrich:WithMvcRouteData"/>
    <add key="serilog:enrich:WithMvcRouteTemplate"/>
</appSettings>
```

