using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem
{
    public class BaseSalesItemPriceListLinesResource
    {

        #region Required Properties

        /// <summary>
        /// The price.
        /// </summary>
        [JsonProperty("priceAmount")]
        public MoneyResource PriceAmount { get; set; }

        /// <summary>
        /// The pricelist's line unit.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The money's unit used by the document. This value is important for currency exchanges or to set the number of decimal places used to represent values.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        #endregion Required Properties


        #region Optional Properties

        /// <summary>
        /// Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The pricelist that corresponds to this price list line.
        /// </summary>
        [JsonProperty("priceList")]
        public string PriceList { get; set; }


        #endregion Optional Properties

    }
}
