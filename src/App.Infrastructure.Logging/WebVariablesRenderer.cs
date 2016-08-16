using System.Globalization;
using System.Text;
using System.Web;
using System.Xml;
using NLog;
using NLog.Config;
using NLog.LayoutRenderers;

namespace App.Infrastructure.Logging
{
    [LayoutRenderer("web_variables")]
    public class WebVariablesRenderer : LayoutRenderer
    {
        public WebVariablesRenderer()
        {
            Format = "";
            Culture = CultureInfo.InvariantCulture;
        }

        public CultureInfo Culture { get; set; }

        [DefaultParameter]
        public string Format { get; set; }

        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            var output = new StringBuilder();
            using (var xmlWriter = XmlWriter.Create(output))
            {
                xmlWriter.WriteStartElement("error");
                xmlWriter.WriteStartElement("serverVariables");

                foreach (string key in HttpContext.Current.Request.ServerVariables.AllKeys)
                {
                    xmlWriter.WriteStartElement("item");
                    xmlWriter.WriteAttributeString("name", key);

                    xmlWriter.WriteStartElement("value");
                    xmlWriter.WriteAttributeString("string", HttpContext.Current.Request.ServerVariables[key]);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("cookies");

                foreach (string key in HttpContext.Current.Request.Cookies.AllKeys)
                {
                    xmlWriter.WriteStartElement("item");
                    xmlWriter.WriteAttributeString("name", key);

                    xmlWriter.WriteStartElement("value");
                    var cookie = HttpContext.Current.Request.Cookies[key];
                    if (cookie != null)
                        xmlWriter.WriteAttributeString("string", cookie.Value);

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }

            string xml = output.ToString();

            builder.Append(xml);
        }

    }
}
