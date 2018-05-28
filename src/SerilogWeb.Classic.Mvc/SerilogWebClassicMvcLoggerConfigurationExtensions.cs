using Serilog.Configuration;
using SerilogWeb.Classic.Mvc.Enrichers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog
{
    /// <summary>
    /// Extends <see cref="LoggerConfiguration"/> to add enrichers for SerilogWeb.Classic.Mvc logging module 
    /// </summary>
    public static class SerilogWebClassicMvcLoggerConfigurationExtensions
    {
        /// <summary>
        /// Enrich log events with the name of the current MVC action.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithMvcActionName(
            this LoggerEnrichmentConfiguration enrichmentConfiguration)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With<MvcActionNameEnricher>();
        }

        /// <summary>
        /// Enrich log events with the name of the current MVC action.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <param name="propertyName">Name of the property to log.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithMvcActionName(
            this LoggerEnrichmentConfiguration enrichmentConfiguration,
            string propertyName)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With(new MvcActionNameEnricher(propertyName));
        }

        /// <summary>
        /// Enrich log events with the controller name for the current MVC action.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithMvcControllerName(
            this LoggerEnrichmentConfiguration enrichmentConfiguration)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With<MvcControllerNameEnricher>();
        }

        /// <summary>
        /// Enrich log events with the controller name for the current MVC action.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <param name="propertyName">Name of the property to log.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithMvcControllerName(
            this LoggerEnrichmentConfiguration enrichmentConfiguration,
            string propertyName)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With(new MvcControllerNameEnricher(propertyName));
        }

        /// <summary>
        /// Enrich log events with the route data for the current MVC action.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithMvcRouteData(
            this LoggerEnrichmentConfiguration enrichmentConfiguration)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With<MvcRouteDataEnricher>();
        }

        /// <summary>
        /// Enrich log events with the route data for the current MVC action.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <param name="propertyName">Name of the property to log.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithMvcRouteData(
            this LoggerEnrichmentConfiguration enrichmentConfiguration,
            string propertyName)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With(new MvcRouteDataEnricher(propertyName));
        }

        /// <summary>
        /// Enrich log events with the route template for the current MVC action.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithMvcRouteTemplate(
            this LoggerEnrichmentConfiguration enrichmentConfiguration)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With<MvcRouteTemplateEnricher>();
        }

        /// <summary>
        /// Enrich log events with the template for the current MVC action.
        /// </summary>
        /// <param name="enrichmentConfiguration">Logger enrichment configuration.</param>
        /// <param name="propertyName">Name of the property to log.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
        public static LoggerConfiguration WithMvcRouteTemplate(
            this LoggerEnrichmentConfiguration enrichmentConfiguration,
            string propertyName)
        {
            if (enrichmentConfiguration == null) throw new ArgumentNullException(nameof(enrichmentConfiguration));
            return enrichmentConfiguration.With(new MvcRouteTemplateEnricher(propertyName));
        }
    }
}
