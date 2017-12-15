namespace SerilogWeb.Classic.Mvc.Enrichers
{
    /// <summary>
    /// An enricher that adds the route data for the current MVC Action to the log event properties
    /// </summary>
    public class MvcRouteDataEnricher : BaseMvcContextInfoEnricher
    {
        public MvcRouteDataEnricher()
            : this("MvcRouteData")
        {
        }

        public MvcRouteDataEnricher(string propertyName, bool destructureObjects = false)
            : base(MvcRequestInfoKey.RouteData, propertyName, destructureObjects)
        {
        }
    }
}