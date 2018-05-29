namespace SerilogWeb.Classic.Mvc.Enrichers
{
    /// <summary>
    /// An enricher that adds the route template for the current MVC Action to the log event properties
    /// </summary>
    public class MvcRouteTemplateEnricher : BaseMvcContextInfoEnricher
    {
        public const string MvcRouteTemplatePropertyName = "MvcRouteTemplate";

        public MvcRouteTemplateEnricher()
            : this(MvcRouteTemplatePropertyName)
        {
        }

        public MvcRouteTemplateEnricher(string propertyName, bool destructureObjects = false)
            : base(MvcRequestInfoKey.RouteUrlTemplate, propertyName, destructureObjects)
        {
        }
    }
}
