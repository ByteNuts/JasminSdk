using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.CustomerParty
{
    public class CustomerDataResource
    {
        #region Required Properties


        /// <summary>
        /// Indicates whether the customer is an end customer or not.
        /// </summary>
        [JsonProperty("oneTimeCustomer")]
        public bool OneTimeCustomer { get; set; }


        #endregion Required Properties



        #region Optional Properties


        /// <summary>
        /// The customer's name.
        /// </summary>
        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// The customer's party key.
        /// </summary>
        [JsonProperty("customerPartyKey")]
        public string CustomerPartyKey { get; set; }


        #endregion Optional Properties
    }
}
