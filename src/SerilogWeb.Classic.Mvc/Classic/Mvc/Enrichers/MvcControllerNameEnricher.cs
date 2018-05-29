namespace SerilogWeb.Classic.Mvc.Enrichers
{
    /// <summary>
    /// An enricher that adds the name of the Controller for the current MVC action to the log event properties
    /// </summary>
    public class MvcControllerNameEnricher : BaseMvcContextInfoEnricher
    {
        public const string MvcControllerPropertyName = "MvcController";

        public MvcControllerNameEnricher()
            : this(MvcControllerPropertyName)
        {
        }

        public MvcControllerNameEnricher(string propertyName, bool destructureObjects = false)
            : base(MvcRequestInfoKey.ControllerName, propertyName, destructureObjects)
        {
        }
    }
}