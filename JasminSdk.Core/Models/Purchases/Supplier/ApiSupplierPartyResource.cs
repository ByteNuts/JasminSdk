using System;
using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Supplier
{
    public class ApiSupplierPartyResource
    {
        [JsonProperty("baseEntityKey")]
        public string BaseEntityKey { get; set; }

        #region Required Properties


        /// <summary>
        /// The supplier group for the party.
        /// </summary>
        [JsonProperty("supplierGroup")]
        public string SupplierGroup { get; set; }

        /// <summary>
        /// The payment term for the party.
        /// </summary>
        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        /// <summary>
        /// The delivery term for the party.
        /// </summary>
        [JsonProperty("deliveryTerm")]
        public string DeliveryTerm { get; set; }

        /// <summary>
        /// The payment method for the party.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The purchases party tax schema. The tax schema identifies the group of taxes a party is liable for.
        /// </summary>
        [JsonProperty("partyTaxSchema")]
        public string PartyTaxSchema { get; set; }

        /// <summary>
        /// When checked, the supplier party is locked.
        /// </summary>
        [JsonProperty("locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// The key for the party. Uniquely identifies the entity/party within the organization.
        /// </summary>
        [JsonProperty("partyKey")]
        public string PartyKey { get; set; }


        #endregion Required Properties



        #region Optional Properties


        /// <summary>
        /// The Settlement discount percentage.
        /// </summary>
        [JsonProperty("settlementDiscountPercent")]
        public decimal SettlementDiscountPercent { get; set; }

        /// <summary>
        /// The party withholding tax schema. The withholding tax schema identifies the group of withholding taxes a party is liable for.
        /// </summary>
        [JsonProperty("partyWithholdingTaxSchema")]
        public string PartyWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The supplier item prices.
        /// </summary>
        [JsonProperty("supplierItemPrices")]
        public List<ApiSupplierPartySupplierItemPricesResource> SupplierItemPrices { get; set; }

        /// <summary>
        /// The exchange rate date for the supplier party.
        /// </summary>
        [JsonProperty("exchangeRateDate")]
        public DateTime? ExchangeRateDate { get; set; }

        /// <summary>
        /// The customer designated in the invoice as the party to whom the invoice should be sent for payment. It may or may not be the party to whom the goods or services are delivered.
        /// </summary>
        [JsonProperty("accountingParty")]
        public string AccountingParty { get; set; }


        #endregion Optional Properties
    }
}
