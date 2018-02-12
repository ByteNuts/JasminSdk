using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Entity
{
    public class PartyAddressResource
    {
        #region Required Properties

        [JsonProperty("country")]
        public string Country { get; set; }


        #endregion Required Properties



        #region Optional Properties


        [JsonProperty("streetName")]
        public string StreetName { get; set; }


        [JsonProperty("buildingNumber")]
        public string BuildingNumber { get; set; }


        [JsonProperty("postalZone")]
        public string PostalZone { get; set; }


        [JsonProperty("cityName")]
        public string CityName { get; set; }


        [JsonProperty("contactName")]
        public string ContactName { get; set; }


        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }


        #endregion Optional Properties
    }
}
