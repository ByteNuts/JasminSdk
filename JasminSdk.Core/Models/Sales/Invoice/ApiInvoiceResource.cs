using System;
using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.Invoice
{
    public class ApiInvoiceResource
    {
        #region Required Properties

        /// <summary>
        /// Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.
        /// </summary>
        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        /// <summary>
        /// Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.
        /// </summary>
        [JsonProperty("serie")]
        public string Serie { get; set; }

        /// <summary>
        /// The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.
        /// </summary>
        [JsonProperty("seriesNumber")]
        public int? SeriesNumber { get; set; }

        /// <summary>
        /// The memo's company. The company code is the central organizational unit within the system.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// The invoice's payment term. Term specifying the manner in which a trade will be done. Generally, these terms specify a period in which the buyer can pay the due amount. They can also demand some money to be paid in advance, paid in cash at delivery, a 30 day or longer period, or other similar arrangements for deferred payment. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        /// <summary>
        /// The invoice's payment method. Financial transfer method used by the entity responsible for paying a transaction. For example, cash, transfer or check payments. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The money's unit used by the document. This value is important for currency exchanges or to set the number of decimal places used to represent values. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The date when the document is issued.
        /// </summary>
        [JsonProperty("documentDate")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// The date when the document is created.
        /// </summary>
        [JsonProperty("postingDate")]
        public DateTime? PostingDate { get; set; }

        /// <summary>
        /// The customer party that receives or consumes products (goods or services).
        /// </summary>
        [JsonProperty("buyerCustomerParty")]
        public string BuyerCustomerParty { get; set; }

        /// <summary>
        /// The customer's name. It is inferred from the customer party.
        /// </summary>
        [JsonProperty("buyerCustomerPartyName")]
        public string BuyerCustomerPartyName { get; set; }

        /// <summary>
        /// The customer designated in the invoice as the party to whom the invoice should be sent for payment. It may or may not be the party to whom the goods or services are delivered. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("accountingParty")]
        public string AccountingParty { get; set; }

        /// <summary>
        /// The rate that translates the values in the document from the document currency to company base currency. By default the system uses the exchange rates table at the document date.
        /// </summary>
        [JsonProperty("exchangeRate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The discount's percentage. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// The country of the physical location where the goods are loaded. The default is the company country.
        /// </summary>
        [JsonProperty("loadingCountry")]
        public string LoadingCountry { get; set; }

        /// <summary>
        /// The physical location address country where the goods are unloaded. The default is customer address country.
        /// </summary>
        [JsonProperty("unloadingCountry")]
        public string UnloadingCountry { get; set; }

        /// <summary>
        /// Defines if the invoice type series is defined as external. Internally determined.
        /// </summary>
        [JsonProperty("isExternal")]
        public bool? IsExternal { get; set; }

        /// <summary>
        /// Defines if the invoice type series is defined as manual. Internally determined.
        /// </summary>
        [JsonProperty("isManual")]
        public bool? IsManual { get; set; }

        /// <summary>
        /// Defines if the invoice type is defined as simple invoice type. Internally determined.
        /// </summary>
        [JsonProperty("isSimpleInvoice")]
        public bool? IsSimpleInvoice { get; set; }

        /// <summary>
        /// Indicates if the invoice is communicated via web service to fiscal authority. Inferred from the invoice type serie.
        /// </summary>
        [JsonProperty("isWsCommunicable")]
        public bool? IsWsCommunicable { get; set; }



        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The invoice's economic activity classification. A national legal standard that attributes a 5-digit value to identify a company's specific category of professional activity.
        /// </summary>
        [JsonProperty("economicActivityClassification")]
        public string EconomicActivityClassification { get; set; }

        /// <summary>
        /// The incoming and outgoing cash flow caused by the main business activities. The component of the cash flow operations shows how much money is generated by a company's products or services. Generally, the changes made to the cash, banks, accounts receivables and accounts payable affects operational cash. The classification of each of these operations' types is made by using cash flows.
        /// </summary>
        [JsonProperty("cashFlowItem")]
        public string CashFlowItem { get; set; }

        /// <summary>
        /// An account that exists in a financial institution. The financial institution holds someone's money, resulting in a positive balance. It can also be a credit or loans account in which the bank lends money, resulting in a negative balance or debit. Unlike a brokerage account, which allows the investor to buy and sell stocks, a bank account is used for savings. The types of bank accounts include savings accounts and current accounts.
        /// </summary>
        [JsonProperty("financialAccount")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Refers to a cash drawer that collects small amounts of cash in a business.
        /// </summary>
        [JsonProperty("pettyCash")]
        public string PettyCash { get; set; }

        /// <summary>
        /// The invoice's delivery term. The conditions in a sales or transportation contract that specify the means of transportation. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("deliveryTerm")]
        public string DeliveryTerm { get; set; }

        /// <summary>
        /// The customer's tax code. Unique code assigned by a country's tax authority to establish an entity's fiscal identification and responsibilities. Inferred from the customer party.
        /// </summary>
        [JsonProperty("buyerCustomerPartyTaxId")]
        public string BuyerCustomerPartyTaxId { get; set; }

        /// <summary>
        /// The customer's address. It is inferred from the customer party.
        /// </summary>
        [JsonProperty("buyerCustomerPartyAddress")]
        public string BuyerCustomerPartyAddress { get; set; }

        /// <summary>
        /// The accounting's party name. It is inferred from the accounting party.
        /// </summary>
        [JsonProperty("accountingPartyName")]
        public string AccountingPartyName { get; set; }

        /// <summary>
        /// The accounting's tax code. Unique code assigned by a country's tax authority to establish an entity's fiscal identification and responsibilities. Inferred from the accounting party.
        /// </summary>
        [JsonProperty("accountingPartyTaxId")]
        public string AccountingPartyTaxId { get; set; }

        /// <summary>
        /// The accounting's customer address. It is inferred from the accounting party.
        /// </summary>
        [JsonProperty("accountingPartyAddress")]
        public string AccountingPartyAddress { get; set; }

        /// <summary>
        /// The exchange rate creation date.
        /// </summary>
        [JsonProperty("exchangeRateDate")]
        public DateTime? ExchangeRateDate { get; set; }

        /// <summary>
        /// The payment's check date. Applicable only when the invoice is cash invoice and the payment method is of type check.
        /// </summary>
        [JsonProperty("checkDate")]
        public DateTime? CheckDate { get; set; }

        /// <summary>
        /// The payment's check bank. Applicable only when the invoice is cash invoice and the payment method is of type check.
        /// </summary>
        [JsonProperty("checkBank")]
        public string CheckBank { get; set; }

        /// <summary>
        /// The payment's check bank branch. Applicable only when the invoice is cash invoice and the payment method is of type check.
        /// </summary>
        [JsonProperty("checkBranch")]
        public string CheckBranch { get; set; }

        /// <summary>
        /// The payment's check bank account. Applicable only when the invoice is cash invoice and the payment method is of type check.
        /// </summary>
        [JsonProperty("checkAccount")]
        public string CheckAccount { get; set; }

        /// <summary>
        /// Defines if the payment check endsorded. Applicable only when the invoice is cash invoice and the payment method is of type check. In some countries, the beneficiary can endorse the check, which allows him or her to specify a third party to whom it should be paid.
        /// </summary>
        [JsonProperty("checkEndorsed")]
        public bool? CheckEndorsed { get; set; }

        /// <summary>
        /// The payment's check number. Applicable only when the invoice is cash invoice and the payment method is of type check.
        /// </summary>
        [JsonProperty("checkNumber")]
        public string CheckNumber { get; set; }

        /// <summary>
        /// The payment's check issue place. Applicable only when the invoice is cash invoice and the payment method is of type check.
        /// </summary>
        [JsonProperty("issuePlace")]
        public string IssuePlace { get; set; }

        /// <summary>
        /// Determines if the used payment method is of type check. Applicable only when the invoice is cash invoice and the payment method is of type check. Internally determined.
        /// </summary>
        [JsonProperty("checkPayment")]
        public bool? CheckPayment { get; set; }

        /// <summary>
        /// The invoice’s remarks.
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// The document's note.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The catalogued table values that sets the standard price for the products and goods traded by a specific entity. The default is inferred from the customer party if defined, otherwise from the sales setup.
        /// </summary>
        [JsonProperty("priceList")]
        public string PriceList { get; set; }

        /// <summary>
        /// The note to the invoice recipient.
        /// </summary>
        [JsonProperty("noteToRecipient")]
        public string NoteToRecipient { get; set; }

        /// <summary>
        /// The sales person associated to the invoice. Sales representative or salesman (whether he is under direct control of a company or not) is authorized to procure business opportunities for a company. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("salesperson")]
        public string Salesperson { get; set; }

        /// <summary>
        /// Obsolete.
        /// </summary>
        [Obsolete]
        [JsonProperty("settlementDiscountPercent")]
        public decimal? SettlementDiscountPercent { get; set; }

        /// <summary>
        /// The alternative customer's address key to be used on the invoice. The alternative addresses keys are defined on the customer party addresses. When defined overrides the customer party address and unloading address values.
        /// </summary>
        [JsonProperty("altAddress")]
        public string AltAddress { get; set; }

        /// <summary>
        /// The physical location where the goods are loaded. The default is the company physical location.
        /// </summary>
        [JsonProperty("loadingPoint")]
        public string LoadingPoint { get; set; }

        /// <summary>
        /// The street name of the physical location where the goods are loaded. The default is the company physical location.
        /// </summary>
        [JsonProperty("loadingStreetName")]
        public string LoadingStreetName { get; set; }

        /// <summary>
        /// The building number of the physical location where the goods are loaded. The default is the company physical location.
        /// </summary>
        [JsonProperty("loadingBuildingNumber")]
        public string LoadingBuildingNumber { get; set; }

        /// <summary>
        /// The postal zone of the physical location where the goods are loaded. The default is the company physical location.
        /// </summary>
        [JsonProperty("loadingPostalZone")]
        public string LoadingPostalZone { get; set; }

        /// <summary>
        /// The city of the physical location where the goods are loaded. The default is the company physical location.
        /// </summary>
        [JsonProperty("loadingCityName")]
        public string LoadingCityName { get; set; }

        /// <summary>
        /// The goods loading date and time from the loading physical location. The default is the invoice creation date and time.
        /// </summary>
        [JsonProperty("loadingDateTime")]
        public DateTimeOffset? LoadingDateTime { get; set; }

        /// <summary>
        /// The physical location address where the goods are loaded. The default is the company physical location address.
        /// </summary>
        [JsonProperty("loadingPointAddress")]
        public string LoadingPointAddress { get; set; }

        /// <summary>
        /// The loading warehouse. When defined the warehouse address will replace the loading address values.
        /// </summary>
        [JsonProperty("loadingWarehouse")]
        public string LoadingWarehouse { get; set; }

        /// <summary>
        /// The physical location where the goods are unloaded. Defines the unloading from the freight. The default is customer address.
        /// </summary>
        [JsonProperty("unloadingPoint")]
        public string UnloadingPoint { get; set; }

        /// <summary>
        /// The street name of the physical location where the goods are unloaded. The default is customer address street name.
        /// </summary>
        [JsonProperty("unloadingStreetName")]
        public string UnloadingStreetName { get; set; }

        /// <summary>
        /// The building number of the physical location where the goods are unloaded. The default is customer address building number.
        /// </summary>
        [JsonProperty("unloadingBuildingNumber")]
        public string UnloadingBuildingNumber { get; set; }

        /// <summary>
        /// The postal zone of the physical location where the goods are unloaded. The default is customer address postal zone.
        /// </summary>
        [JsonProperty("unloadingPostalZone")]
        public string UnloadingPostalZone { get; set; }

        /// <summary>
        /// The city name of the physical location where the goods are unloaded. The default is customer address city name.
        /// </summary>
        [JsonProperty("unloadingCityName")]
        public string UnloadingCityName { get; set; }

        /// <summary>
        /// The physical location address where the goods are unloaded. The default is customer address.
        /// </summary>
        [JsonProperty("unloadingPointAddress")]
        public string UnloadingPointAddress { get; set; }

        /// <summary>
        /// The goods unloading date and time on the unloading physical location.
        /// </summary>
        [JsonProperty("unloadingDateTime")]
        public DateTimeOffset? UnloadingDateTime { get; set; }

        /// <summary>
        /// The vehicle's plate used to trasnport the goods.
        /// </summary>
        [JsonProperty("vehiclePlateNumber")]
        public string VehiclePlateNumber { get; set; }

        /// <summary>
        /// The invoice's manual serie number. Applicable only when the invoice type series is defined as manual.
        /// </summary>
        [JsonProperty("manualNumber")]
        public int? ManualNumber { get; set; }

        /// <summary>
        /// The invoice's manual date. Applicable only when the invoice type series is defined as manual.
        /// </summary>
        [JsonProperty("manualDate")]
        public DateTime? ManualDate { get; set; }

        /// <summary>
        /// The invoice's manual serie. Applicable only when the invoice type series is defined as manual.
        /// </summary>
        [JsonProperty("manualSerie")]
        public string ManualSerie { get; set; }

        /// <summary>
        /// The invoice's lines.
        /// See ApiInvoiceDocumentLinesResource.
        /// </summary>
        [JsonProperty("documentLines")]
        public List<ApiInvoiceDocumentLinesResource> DocumentLines { get; set; }

        /// <summary>
        /// The invoice's taxes.
        /// See ApiInvoiceDocumentTaxesResource.
        /// </summary>
        [JsonProperty("documentTaxes")]
        public List<ApiInvoiceDocumentTaxesResource> DocumentTaxes { get; set; }

        /// <summary>
        /// The invoice's sales channel origin. The default value is defined in the sales setup configuration settings.
        /// </summary>
        [JsonProperty("salesChannel")]
        public string SalesChannel { get; set; }

        /// <summary>
        /// Date in which the payment is due. In some countries it is also known as law date.
        /// </summary>
        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Defines if the invoice type series is defined as manual. Internally determined.
        /// </summary>
        [JsonProperty("isManualSerie")]
        public bool? IsManualSerie { get; set; }

        /// <summary>
        /// Defines if the customer party is a marked as an one time customer. Internally determined.
        /// </summary>
        [JsonProperty("isOneTimeCustomer")]
        public bool? IsOneTimeCustomer { get; set; }

        /// <summary>
        /// The legal fiscal document type defined on the invoice type. Inferred from the invoice type.
        /// </summary>
        [JsonProperty("fiscalDocumentType")]
        public string FiscalDocumentType { get; set; }

        /// <summary>
        /// The alternative accounting's party address key to be used on the invoice. The alternative addresses keys are defined on the accounting party addresses. When defined overrides the accounting party address values.
        /// </summary>
        [JsonProperty("accountingAltAddress")]
        public string AccountingAltAddress { get; set; }

        /// <summary>
        /// The accounting's organization method. The organization can follow the rules of "Cash Accounting" or "Accrual Accounting".
        /// See AccountingSchema.
        /// </summary>
        [JsonProperty("accountingSchema")]
        public AccountingSchema AccountingSchema { get; set; }

        /// <summary>
        /// The customer's accounting organization method. The customer organication can follow the rules of "Cash Accounting" or "Accrual Accounting".
        /// See AccountingSchema.
        /// </summary>
        [JsonProperty("partyAccountingSchema")]
        public AccountingSchema PartyAccountingSchema { get; set; }

        /// <summary>
        /// The invoice's notification configuration. Inferred from the invoice type.
        /// </summary>
        [JsonProperty("notification")]
        public string Notification { get; set; }

        /// <summary>
        /// The email(s) to send invoice notification. Inferred from the notification.
        /// </summary>
        [JsonProperty("emailTo")]
        public string EmailTo { get; set; }



        #endregion Optional Properties

    }
}
