using System.Globalization;
using System.Text;
using NLog;
using NLog.Config;
using NLog.LayoutRenderers;

namespace App.Infrastructure.Logging
{
    public class UtcDateRenderer : LayoutRenderer
    {
        public UtcDateRenderer()
        {
            Format = "G";
            Culture = CultureInfo.InvariantCulture;
        }

        public CultureInfo Culture { get; set; }

        [DefaultParameter]
        public string Format { get; set; }

        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            builder.Append(logEvent.TimeStamp.ToUniversalTime().ToString(Format, Culture));
        }
    }
}
