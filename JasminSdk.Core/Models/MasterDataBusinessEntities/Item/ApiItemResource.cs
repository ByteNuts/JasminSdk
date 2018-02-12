using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Item
{
    public class ApiItemResource
    {

        #region Required Properties

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
