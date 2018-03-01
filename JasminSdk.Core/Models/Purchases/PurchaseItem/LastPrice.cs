using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.PurchaseItem
{
    //lastPrice\": {\r\n    \"amount\": 0.000000,\r\n    \"baseAmount\": 0.000000,\r\n    \"reportingAmount\": 0.000000,\r\n    \"fractionDigits\": 2,\r\n    \"symbol\": \"€\"\r\n  }
    public class LastPrice
    {
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        [JsonProperty("baseAmount")]
        public decimal? BaseAmount { get; set; }


        [JsonProperty("reportingAmount")]
        public decimal? ReportingAmount { get; set; }


        [JsonProperty("fractionDigits")]
        public int? FractionDigits { get; set; }


        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}
