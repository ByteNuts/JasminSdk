using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Entity
{
    public class ApiPartyPartyContactsResource
    {
        #region Required Properties

        [JsonProperty("contactName")]
        public string ContactName { get; set; }


        [JsonProperty("contactType")]
        public string ContactType { get; set; }


        #endregion Required Properties



        #region Optional Properties


        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }


        [JsonProperty("electronicMail")]
        public string ElectronicMail { get; set; }


        [JsonProperty("mobile")]
        public string Mobile { get; set; }


        [JsonProperty("telephone")]
        public string Telephone { get; set; }


        #endregion Optional Properties
    }
}
