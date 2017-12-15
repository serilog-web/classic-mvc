namespace SerilogWeb.Classic.Mvc.Enrichers
{
    /// <summary>
    /// An enricher that adds the name of the Controller for the current MVC action to the log event properties
    /// </summary>
    public class MvcControllerNameEnricher : BaseMvcContextInfoEnricher
    {
        public MvcControllerNameEnricher()
            : this("MvcController")
        {
        }

        public MvcControllerNameEnricher(string propertyName, bool destructureObjects = false)
            : base(MvcRequestInfoKey.ControllerName, propertyName, destructureObjects)
        {
        }
    }
}