using System;
using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Supplier
{
    public class BaseSupplierPartyResource
    {
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
        public bool PartyKey { get; set; }

        /// <summary>
        /// The name for the party.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// A flag indicating if the party is externally managed.
        /// </summary>
        [JsonProperty("isExternallyManaged")]
        public bool IsExternallyManaged { get; set; }

        /// <summary>
        /// The party's default currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The party's country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }


        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The Settlement discount percentage.
        /// </summary>
        [JsonProperty("settlementDiscountPercent")]
        public decimal? SettlementDiscountPercent { get; set; }

        /// <summary>
        /// The party withholding tax schema. The withholding tax schema identifies the group of withholding taxes a party is liable for.
        /// </summary>
        [JsonProperty("partyWithholdingTaxSchema")]
        public string PartyWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The supplier item prices.
        /// </summary>
        [JsonProperty("supplierItemPrices")]
        public List<BaseSupplierPartySupplierItemPricesResource> SupplierItemPrices { get; set; }

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

        /// <summary>
        /// The search term.
        /// </summary>
        [JsonProperty("searchTerm")]
        public string SearchTerm { get; set; }

        /// <summary>
        /// The party tax identifier. The unique code assigned by a country's tax authority to establish an entity's fiscal identification and responsibilities.
        /// </summary>
        [JsonProperty("companyTaxID")]
        public string CompanyTaxID { get; set; }

        /// <summary>
        /// The electronic mail for the party.
        /// </summary>
        [JsonProperty("electronicMail")]
        public string ElectronicMail { get; set; }

        /// <summary>
        /// The telephone for the party.
        /// </summary>
        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// The mobile for the party.
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// The website url for the party.
        /// </summary>
        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// The notes for the party.
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// The picture for the party.
        /// </summary>
        [JsonProperty("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// The party main address street's name.
        /// </summary>
        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        /// <summary>
        /// The party main address building's number.
        /// </summary>
        [JsonProperty("buildingNumber")]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// The party main address postal zone.
        /// </summary>
        [JsonProperty("postalZone")]
        public string PostalZone { get; set; }

        /// <summary>
        /// The party main address city's name.
        /// </summary>
        [JsonProperty("cityName")]
        public string CityName { get; set; }

        /// <summary>
        /// The party main contact's name.
        /// </summary>
        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        /// <summary>
        /// The party main contact's title.
        /// </summary>
        [JsonProperty("contactTitle")]
        public string ContactTitle { get; set; }

        /// <summary>
        /// The party's Identity Username.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The external identifier for the party.
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// The external version for the party.
        /// </summary>
        [JsonProperty("externalVersion")]
        public string ExternalVersion { get; set; }

        /// <summary>
        /// The party's main address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The party's main contact.
        /// </summary>
        [JsonProperty("contact")]
        public string Contact { get; set; }

        /// <summary>
        /// The culture for the party.
        /// </summary>
        [JsonProperty("culture")]
        public string Culture { get; set; }


        #endregion Optional Properties

    }
}
