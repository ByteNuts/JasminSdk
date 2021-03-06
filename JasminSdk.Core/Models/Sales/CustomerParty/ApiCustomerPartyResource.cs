﻿using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.CustomerParty
{
    public class ApiCustomerPartyResource
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
        /// The customer's party tax schema. The tax schema identifies the group of taxes a party is liable for. The tax schema is defined in the customer party.
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
        public decimal SettlementDiscountPercent { get; set; }

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


        #endregion Optional Properties
    }
}
