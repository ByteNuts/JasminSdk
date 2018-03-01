using System;
using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.PurchaseItem
{
    public class BasePurchasesItemResource
    {

        #region Required Properties

        /// <summary>
        /// The unit for the purchases item.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("lastPrice")]
        public LastPrice LastPrice { get; set; }

        /// <summary>
        /// The last price for the item.
        /// </summary>
        [JsonProperty("lastPriceAmount")]
        public decimal? LastPriceAmount { get; set; }

        /// <summary>
        /// The money unit used by the system, such as Euros (EUR) or United States Dollars (USD). This value is important for currency exchanges or to set the number of decimal places used to represent values.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The purchases item tax schema. The tax schema identifies the group of taxes a item is liable for.
        /// </summary>
        [JsonProperty("itemTaxSchema")]
        public string ItemTaxSchema { get; set; }

        /// <summary>
        /// The expense account for the item.
        /// </summary>
        [JsonProperty("expenseAccount")]
        public string ExpenseAccount { get; set; }

        /// <summary>
        /// The key for the item. Uniquely identifies the item within the organization.
        /// </summary>
        [JsonProperty("itemKey")]
        public string ItemKey { get; set; }

        /// <summary>
        /// A flag indicating if the item is externally managed.
        /// </summary>
        [JsonProperty("isExternallyManaged")]
        public bool? IsExternallyManaged { get; set; }

        /// <summary>
        /// The base unit for the item.
        /// </summary>
        [JsonProperty("baseUnit")]
        public string BaseUnit { get; set; }

        /// <summary>
        /// The item type for the item.
        /// </summary>
        [JsonProperty("itemType")]
        public ItemTypeEnum ItemType { get; set; }


        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The last supplier for the item.
        /// </summary>
        [JsonProperty("lastSupplierParty")]
        public string LastSupplierParty { get; set; }

        /// <summary>
        /// The last document for the item.
        /// </summary>
        [JsonProperty("lastSourceDoc")]
        public string LastSourceDoc { get; set; }

        /// <summary>
        /// The last document date for the item.
        /// </summary>
        [JsonProperty("lastSourceDocDate")]
        public DateTime? LastSourceDocDate { get; set; }

        /// <summary>
        /// The last unit for the item.
        /// </summary>
        [JsonProperty("lastUnit")]
        public string LastUnit { get; set; }

        /// <summary>
        /// The item withholding tax schema. The withholding tax schema identifies the group of withholding taxes a item is liable for.
        /// </summary>
        [JsonProperty("itemWithholdingTaxSchema")]
        public string ItemWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The description for the item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The extended description for the item.
        /// </summary>
        [JsonProperty("complementaryDescription")]
        public string ComplementaryDescription { get; set; }

        /// <summary>
        /// The assortment for the item.
        /// </summary>
        [JsonProperty("assortment")]
        public string Assortment { get; set; }

        /// <summary>
        /// The barcode for the item.
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// The brand for the item.
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// The picture for the item.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// The remarks for the item.
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// The external identifier for the item.
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// The external version for the item.
        /// </summary>
        [JsonProperty("externalVersion")]
        public string ExternalVersion { get; set; }

        /// <summary>
        /// The brand model for the item.
        /// </summary>
        [JsonProperty("brandModel")]
        public string BrandModel { get; set; }


        #endregion Optional Properties

    }
}
