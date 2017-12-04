using System;
using System.Collections.Generic;
using System.Web;
using Serilog.Core;
using Serilog.Events;

namespace SerilogWeb.Classic.Mvc.Enrichers
{
    /// <summary>
    /// Base class for MVC enrichers that access MVC-specific contextual information stored temporarily in HttpContext
    /// </summary>
    public abstract class BaseMvcContextInfoEnricher : ILogEventEnricher
    {
        private readonly MvcRequestInfoKey _infoItemKey;
        private readonly bool _destructureObjects;
        private readonly string _logPropertyName;

        internal BaseMvcContextInfoEnricher(MvcRequestInfoKey infoItemKey, string logPropertyName, bool destructureObjects = false)
        {
            _infoItemKey = infoItemKey;
            _destructureObjects = destructureObjects;
            _logPropertyName = logPropertyName ?? throw new ArgumentNullException(nameof(logPropertyName));
        }

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            if (logEvent == null) throw new ArgumentNullException(nameof(logEvent));

            var httpContext = HttpContext.Current;
            if (httpContext == null)
                return;

            var mvcInfo = httpContext.Items[Constants.MvcContextInfoKey] as IReadOnlyDictionary<MvcRequestInfoKey, object>;

            if (mvcInfo != null)
            {
                var propertyValue = mvcInfo[_infoItemKey];

                var logEventProperty = propertyFactory.CreateProperty(_logPropertyName, propertyValue, _destructureObjects);

                logEvent.AddOrUpdateProperty(logEventProperty);
            }
        }
    }
}