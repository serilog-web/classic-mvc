namespace SerilogWeb.Classic.Mvc.Enrichers
{
    /// <summary>
    /// An enricher that adds the name of the current MVC Action name to the log event properties
    /// </summary>
    public class MvcActionNameEnricher : BaseMvcContextInfoEnricher
    {
        public const string MvcActionPropertyName = "MvcAction";

        public MvcActionNameEnricher()
            : this(MvcActionPropertyName)
        {
        }

        public MvcActionNameEnricher(string propertyName, bool destructureObjects = false)
            :base(MvcRequestInfoKey.ActionName, propertyName, destructureObjects)
        {
        }
    }
}