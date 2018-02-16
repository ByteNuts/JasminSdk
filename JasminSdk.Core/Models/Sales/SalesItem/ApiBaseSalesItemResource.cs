using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem
{
    public class ApiBaseSalesItemResource
    {

        #region Required Properties

        /// <summary>
        /// The unit of measure for the sales item.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The sales item's tax schema. The tax schema identifies the group of taxes a item is liable for.
        /// </summary>
        [JsonProperty("itemTaxSchema")]
        public string ItemTaxSchema { get; set; }

        /// <summary>
        /// The defined income account.
        /// </summary>
        [JsonProperty("incomeAccount")]
        public string IncomeAccount { get; set; }

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
        /// The sales item's withholding tax schema. The withholding tax schema identifies the group of withholding taxes a item is liable for.
        /// </summary>
        [JsonProperty("itemWithholdingTaxSchema")]
        public string ItemWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The corresponding price list lines.
        /// </summary>
        [JsonProperty("priceListLines")]
        public List<ApiBaseSalesItemPriceListLinesResource> PriceListLines { get; set; }

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
