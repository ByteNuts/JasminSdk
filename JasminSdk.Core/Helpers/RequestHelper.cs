using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers
{
    public static class RequestHelper
    {
        public static string AccountApiUrl => string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey);

        public static JsonSerializerSettings JsonSettings => new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore,
            Formatting = Formatting.Indented
        };
    }
}
