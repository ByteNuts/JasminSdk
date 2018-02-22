using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Supplier
{
    public class SupplierDataResource
    {

        #region Optional Properties

        /// <summary>
        /// The name for the supplier.
        /// </summary>
        [JsonProperty("supplierName")]
        public string SupplierName { get; set; }

        /// <summary>
        /// The key for the supplier.
        /// </summary>
        [JsonProperty("supplierKey")]
        public string SupplierKey { get; set; }

        /// <summary>
        /// The Settlement discount percentage.
        /// </summary>
        [JsonProperty("settlementDiscountPercent")]
        public decimal? SettlementDiscountPercent { get; set; }


        #endregion Optional Properties

    }
}
