using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.CustomerParty
{
    public class ApiBaseCustomerPartyResource
    {
        #region Required Properties

        /// <summary>
        /// The customer's party customer group.
        /// </summary>
        [JsonProperty("customerGroup")]
        public string CustomerGroup { get; set; }

        /// <summary>
        /// The payment's method. Financial transfer method used by the entity responsible for paying a transaction. For example, cash, transfer or check payments. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The payment's term. Term specifying the manner in which a trade will be done. Generally, these terms specify a period in which the buyer can pay the due amount. They can also demand some money to be paid in advance, paid in cash at delivery, a 30 day or longer period, or other similar arrangements for deferred payment.
        /// </summary>
        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        /// <summary>
        ///  The customer's party tax schema. The tax schema identifies the group of taxes a party is liable for. The tax schema is defined in the customer party.
        /// </summary>
        [JsonProperty("partyTaxSchema")]
        public string PartyTaxSchema { get; set; }

        /// <summary>
        /// Indicates whether the customer party is locked.
        /// </summary>
        [JsonProperty("locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// Indicates what type of accounting schema is used by the customer: 1 - Accrual; 2 - Cash.
        /// </summary>
        [JsonProperty("accountingSchema")]
        public AccountingSchema AccountingSchema { get; set; }

        /// <summary>
        /// Indicates whether the customer is an end customer or not.
        /// </summary>
        [JsonProperty("oneTimeCustomer")]
        public bool OneTimeCustomer { get; set; }

        /// <summary>
        /// Indicates whether the customer is an end customer or not.
        /// </summary>
        [JsonProperty("endCustomer")]
        public bool EndCustomer { get; set; }

        /// <summary>
        /// The key for the party. Uniquely identifies the entity/party within the organization.
        /// </summary>
        [JsonProperty("partyKey")]
        public string PartyKey { get; set; }

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
        /// The catalogued table values ​​that sets the standard price for the products and goods traded by a specific entity. The default is inferred from the customer party if defined, otherwise from the sales setup.
        /// </summary>
        [JsonProperty("priceList")]
        public string PriceList { get; set; }

        /// <summary>
        /// The settlement's discount percentage.
        /// </summary>
        [JsonProperty("settlementDiscountPercent")]
        public decimal? SettlementDiscountPercent { get; set; }

        /// <summary>
        /// The sales person associated to the party. Sales representative or salesman (whether he is under direct control of a company or not) is authorized to procure business opportunities for a company.
        /// </summary>
        [JsonProperty("salesperson")]
        public string Salesperson { get; set; }

        /// <summary>
        /// The customer's party withholding tax schema. The withholding tax schema identifies the group of withholding taxes a party is liable for. The withholding tax schema is defined in the customer party.
        /// </summary>
        [JsonProperty("partyWithholdingTaxSchema")]
        public string PartyWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The delivery's term. The conditions in a sales or transportation contract that specify the means of transportation. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("deliveryTerm")]
        public string DeliveryTerm { get; set; }

        /// <summary>
        /// The default accounting's customer party.
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
