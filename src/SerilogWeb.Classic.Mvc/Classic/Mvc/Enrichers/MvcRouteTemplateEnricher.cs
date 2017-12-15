namespace SerilogWeb.Classic.Mvc.Enrichers
{
    /// <summary>
    /// An enricher that adds the route template for the current MVC Action to the log event properties
    /// </summary>
    public class MvcRouteTemplateEnricher : BaseMvcContextInfoEnricher
    {
        public MvcRouteTemplateEnricher()
            : this("MvcRouteTemplate")
        {
        }

        public MvcRouteTemplateEnricher(string propertyName, bool destructureObjects = false)
            : base(MvcRequestInfoKey.RouteUrlTemplate, propertyName, destructureObjects)
        {
        }
    }
}
