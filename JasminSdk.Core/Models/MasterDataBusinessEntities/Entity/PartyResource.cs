using System.Collections.Generic;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Entity
{
    public class PartyResource
    {
        #region Required Properties

        [JsonProperty("partyKey")]
        public string PartyKey { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("isExternallyManaged")]
        public bool IsExternallyManaged { get; set; }


        [JsonProperty("currency")]
        public string Currency { get; set; }


        [JsonProperty("country")]
        public string Country { get; set; }


        #endregion Required Properties



        #region Optional Properties


        [JsonProperty("searchTerm")]
        public string SearchTerm { get; set; }


        [JsonProperty("companyTaxID")]
        public string CompanyTaxID { get; set; }


        [JsonProperty("electronicMail")]
        public string ElectronicMail { get; set; }


        [JsonProperty("telephone")]
        public string Telephone { get; set; }


        [JsonProperty("mobile")]
        public string Mobile { get; set; }


        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }


        [JsonProperty("notes")]
        public string Notes { get; set; }


        [JsonProperty("picture")]
        public string Picture { get; set; }


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


        [JsonProperty("username")]
        public string Username { get; set; }


        [JsonProperty("externalId")]
        public string ExternalId { get; set; }


        [JsonProperty("externalVersion")]
        public string ExternalVersion { get; set; }


        [JsonProperty("partyAddresses")]
        public List<PartyAddressResource> PartyAddresses { get; set; }


        [JsonProperty("partyContacts")]
        public List<PartyContactResource> PartyContacts { get; set; }


        [JsonProperty("address")]
        public string Address { get; set; }


        [JsonProperty("contact")]
        public string Contact { get; set; }


        [JsonProperty("culture")]
        public string Culture { get; set; }


        #endregion Optional Properties
    }
}
