using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models
{
    public class MoneyResource
    {
        #region Public Properties

        [JsonProperty("amount")]
        public double Value { get; set; }

        [JsonProperty("symbol")]
        public string Currency { get; set; }

        #endregion
    }
}
