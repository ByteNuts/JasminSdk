using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem
{
    public class BaseSalesItemResource
    {

        #region Required Properties

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("itemTaxSchema")]
        public string ItemTaxSchema { get; set; }

        [JsonProperty("incomeAccount")]
        public string IncomeAccount { get; set; }

        [JsonProperty("itemKey")]
        public string ItemKey { get; set; }

        [JsonProperty("isExternallyManaged")]
        public bool IsExternallyManaged { get; set; }

        [JsonProperty("baseUnit")]
        public string BaseUnit { get; set; }

        [JsonProperty("itemType")]
        public ItemTypeEnum ItemType { get; set; }


        #endregion Required Properties



        #region Optional Properties

        [JsonProperty("itemWithholdingTaxSchema")]
        public string ItemWithholdingTaxSchema { get; set; }

        [JsonProperty("priceListLines")]
        public List<ApiBaseSalesItemPriceListLinesResource> PriceListLines { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("complementaryDescription")]
        public string ComplementaryDescription { get; set; }

        [JsonProperty("assortment")]
        public string Assortment { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalVersion")]
        public string ExternalVersion { get; set; }

        [JsonProperty("brandModel")]
        public string BrandModel { get; set; }

        #endregion Optional Properties

    }
}
