namespace SerilogWeb.Classic.Mvc.Enrichers
{
    /// <summary>
    /// An enricher that adds the route data for the current MVC Action to the log event properties
    /// </summary>
    public class MvcRouteDataEnricher : BaseMvcContextInfoEnricher
    {
        public const string MvcRouteDataPropertyName = "MvcRouteData";

        public MvcRouteDataEnricher()
            : this(MvcRouteDataPropertyName)
        {
        }

        public MvcRouteDataEnricher(string propertyName, bool destructureObjects = false)
            : base(MvcRequestInfoKey.RouteData, propertyName, destructureObjects)
        {
        }
    }
}