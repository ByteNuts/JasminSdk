using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Entity
{
    public class PartyDataResource
    {
        #region Required Properties

        [JsonProperty("name")]
        public string Name { get; set; }


        [JsonProperty("partyKey")]
        public string PartyKey { get; set; }


        #endregion Required Properties



        #region Optional Properties


        [JsonProperty("companyTaxID")]
        public string CompanyTaxId { get; set; }


        #endregion Optional Properties
    }
}
