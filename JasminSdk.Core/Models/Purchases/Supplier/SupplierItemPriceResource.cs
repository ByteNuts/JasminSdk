using System;
using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.PurchaseItem;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Supplier
{
    public class SupplierItemPriceResource
    {
        #region Required Properties

        /// <summary>
        /// The amount of money which needs to be paid or paid beforehand for a product.
        /// </summary>
        [JsonProperty("price")]
        public LastPrice Price { get; set; }


        [JsonProperty("priceAmount")]
        public decimal? PriceAmount { get; set; }

        /// <summary>
        /// The last price paided for a product.
        /// </summary>
        [JsonProperty("lastPrice")]
        public LastPrice LastPrice { get; set; }


        [JsonProperty("lastPriceAmount")]
        public decimal? LastPriceAmount { get; set; }

        /// <summary>
        /// The money unit used by the system, such as Euros (EUR) or United States Dollars (USD). This value is important for currency exchanges or to set the number of decimal places used to represent values.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The unit for this item and group suppliers.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The item.
        /// </summary>
        [JsonProperty("item")]
        public string Item { get; set; }


        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The last document for the supplier group.
        /// </summary>
        [JsonProperty("lastSourceDoc")]
        public string LastSourceDoc { get; set; }

        /// <summary>
        /// The last document date for the supplier group.
        /// </summary>
        [JsonProperty("lastSourceDocDate")]
        public DateTime? LastSourceDocDate { get; set; }


        #endregion Optional Properties

    }
}
