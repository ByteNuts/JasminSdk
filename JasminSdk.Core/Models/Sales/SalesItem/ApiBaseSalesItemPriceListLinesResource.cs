using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem
{
    public class ApiBaseSalesItemPriceListLinesResource
    {

        #region Required Properties

        [JsonProperty("priceAmount")]
        public MoneyResource PriceAmount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        #endregion Required Properties


        #region Optional Properties

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priceList")]
        public string PriceList { get; set; }


        #endregion Optional Properties

    }
}
