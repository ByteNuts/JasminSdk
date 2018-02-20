using System;
using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Invoice
{
    public class ApiInvoiceResource
    {
        #region Required Properties

        /// <summary>
        /// The company code is the central organizational unit within the system.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice document type is defined in the purchases setup configuration setting.
        /// </summary>
        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        /// <summary>
        /// Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice document type.
        /// </summary>
        [JsonProperty("serie")]
        public string Serie { get; set; }

        /// <summary>
        /// The sequential number internally determined that uniquely identifies the +document within the invoice document type and serie. Part of the document natural key.
        /// </summary>
        [JsonProperty("seriesNumber")]
        public int? SeriesNumber { get; set; }

        /// <summary>
        /// The supplier designated in the invoice as the party to whom the memo should be sent. It may or may not be the party from whom the goods or services are received. The default is defined on the supplier party.
        /// </summary>
        [JsonProperty("accountingParty")]
        public string AccountingParty { get; set; }

        /// <summary>
        /// The supplier designated in the invoice as the party to whom the invoice is sell. It may or may not be the party from whom the goods or services are received. The default is defined on the supplier party.
        /// </summary>
        [JsonProperty("sellerSupplierParty")]
        public string SellerSupplierParty { get; set; }

        /// <summary>
        /// The term specifying the manner in which a trade will be done. Generally, these terms specify a period in which the buyer can pay the due amount. They can also demand some money to be paid in advance, paid in cash at delivery, a 30 day or longer period, or other similar arrangements for deferred payment. The default is defined on the supplier party.
        /// </summary>
        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        /// <summary>
        /// The financial transfer method used by the entity responsible for paying a transaction. For example, cash, transfer or check payments. The default is defined on the supplier party.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The money unit used by the system, such as Euros (EUR) or United States Dollars (USD). This value is important for currency exchanges or to set the number of decimal places used to represent values. The default is defined on the supplier party.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The date when the document is issued.
        /// </summary>
        [JsonProperty("documentDate")]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// The price of the document's currency expressed in the company's base currency. In other words, the rate at which the document's currency can be exchanged for the company's base currency. The default is inferred using the defined exchange rates on the system for the document date and currency.
        /// </summary>
        [JsonProperty("exchangeRate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The date when the document is created.
        /// </summary>
        [JsonProperty("postingDate")]
        public DateTime? PostingDate { get; set; }

        /// <summary>
        /// The discount percentage. The default is defined on the supplier party.
        /// </summary>
        [JsonProperty("discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// The country of the physical location where the goods are loaded. The default is the supplier's address country.
        /// </summary>
        [JsonProperty("loadingCountry")]
        public string LoadingCountry { get; set; }

        /// <summary>
        /// The country of the physical location where the goods are unloaded. The default is the company's address country.
        /// </summary>
        [JsonProperty("unloadingCountry")]
        public string UnloadingCountry { get; set; }


        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The accounting party name. It is inferred from the accounting party.
        /// </summary>
        [JsonProperty("accountingPartyName")]
        public string AccountingPartyName { get; set; }

        /// <summary>
        /// The accounting party tax code. It is inferred from the accounting party.
        /// </summary>
        [JsonProperty("accountingPartyTaxId")]
        public string AccountingPartyTaxId { get; set; }

        /// <summary>
        /// The accounting party address. It is inferred from the accounting party.
        /// </summary>
        [JsonProperty("accountingPartyAddress")]
        public string AccountingPartyAddress { get; set; }

        /// <summary>
        /// The seller supplier party name. It is inferred from the seller supplier party.
        /// </summary>
        [JsonProperty("sellerSupplierPartyName")]
        public string SellerSupplierPartyName { get; set; }

        /// <summary>
        /// The seller supplier party tax code. It is inferred from the seller supplier party.
        /// </summary>
        [JsonProperty("sellerSupplierPartyTaxId")]
        public string SellerSupplierPartyTaxId { get; set; }

        /// <summary>
        /// The seller supplier party address. It is inferred from the seller supplier party.
        /// </summary>
        [JsonProperty("sellerSupplierPartyAddress")]
        public string SellerSupplierPartyAddress { get; set; }

        /// <summary>
        /// The alternative party address key to be used on the invoice. The alternative addresses keys are defined on the party additional addresses. When defined overrides the party address and unloading address values.
        /// </summary>
        [JsonProperty("altAddress")]
        public string AltAddress { get; set; }

        /// <summary>
        /// The incoming and outgoing cash flow caused by the main business activities. The component of the cash flow operations shows how much money is generated by a company's products or services. Generally, the changes made to the cash, banks, accounts receivables and accounts payable affects operational cash. The classification of each of these operations' types is made by using cash flows. Used when the document is a cash invoice.
        /// </summary>
        [JsonProperty("cashFlowItem")]
        public string CashFlowItem { get; set; }

        /// <summary>
        /// An account that exists in a financial institution. The financial institution holds someone's money, resulting in a positive balance. It can also be a credit or loans account in which the bank lends money, resulting in a negative balance or debit. Unlike a brokerage account, which allows the investor to buy and sell stocks, a bank account is used for savings. The types of bank accounts include savings accounts and current accounts. On an invoice either a cash drawer or a bank account must be used to define where to debit the value.
        /// </summary>
        [JsonProperty("financialAccount")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Refers to a cash drawer that collects small amounts of cash in a business. On a invoice either a cash drawer or a bank account must be used to define where to debit the value. Used when the document is a cash invoice.
        /// </summary>
        [JsonProperty("pettyCash")]
        public string PettyCash { get; set; }

        /// <summary>
        /// The conditions in a sales or transportation contract that specify the means of transportation. The default is defined on the supplier party.
        /// </summary>
        [JsonProperty("deliveryTerm")]
        public string DeliveryTerm { get; set; }

        /// <summary>
        /// The invoice lines.
        /// See ApiInvoiceDocumentLinesResource.
        /// </summary>
        [JsonProperty("documentLines")]
        public List<ApiInvoiceDocumentLinesResource> DocumentLines { get; set; }

        /// <summary>
        /// The invoice taxes.
        /// See ApiInvoiceDocumentTaxesResource.
        /// </summary>
        [JsonProperty("documentTaxes")]
        public List<ApiInvoiceDocumentTaxesResource> DocumentTaxes { get; set; }

        /// <summary>
        /// The invoice note.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The exchange’s rate date.
        /// </summary>
        [JsonProperty("exchangeRateDate")]
        public DateTime? ExchangeRateDate { get; set; }

        /// <summary>
        /// The invoice remarks.
        /// </summary>
        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        /// <summary>
        /// The unique identifier of the account posting.
        /// </summary>
        [JsonProperty("paymentAccountPostingId")]
        public Guid? PaymentAccountPostingId { get; set; }

        /// <summary>
        /// Note to the invoice's recipient.
        /// </summary>
        [JsonProperty("noteToRecipient")]
        public string NoteToRecipient { get; set; }

        /// <summary>
        /// The outgoint lot of the check used for this invoice document. Applicable only when the payment is cash payment and the payment method is of type check.
        /// </summary>
        [JsonProperty("outgoingCheckLot")]
        public string OutgoingCheckLot { get; set; }

        /// <summary>
        /// The check used for this invoice. Applicable only when the payment is cash payment and the payment method is of type check.
        /// </summary>
        [JsonProperty("check")]
        public string Check { get; set; }

        /// <summary>
        /// Determines if the used payment method is of type check. Applicable only when the payment is cash payment and the payment method is of type check. Internally determined.
        /// </summary>
        [JsonProperty("isPaymentMethodCheck")]
        public bool? IsPaymentMethodCheck { get; set; }

        /// <summary>
        /// The physical location where the goods are loaded. Defines the loading from the freight. The default is the supplier's address.
        /// </summary>
        [JsonProperty("loadingPoint")]
        public string LoadingPoint { get; set; }

        /// <summary>
        /// The physical location address where the goods are loaded. The default is the supplier's address.
        /// </summary>
        [JsonProperty("loadingPointAddress")]
        public string LoadingPointAddress { get; set; }

        /// <summary>
        /// The goods loading date and time from the loading physical location. The default is the invoice creation date and time.
        /// </summary>
        [JsonProperty("loadingDateTime")]
        public DateTimeOffset? LoadingDateTime { get; set; }

        /// <summary>
        /// The street name of the physical location where the goods are loaded. The default is the supplier's address street name.
        /// </summary>
        [JsonProperty("loadingStreetName")]
        public string LoadingStreetName { get; set; }

        /// <summary>
        /// The building number of the physical location where the goods are loaded. The default is supplier address building number.
        /// </summary>
        [JsonProperty("loadingBuildingNumber")]
        public string LoadingBuildingNumber { get; set; }

        /// <summary>
        /// The postal zone of the physical location where the goods are loaded. The default is the supplier's address postal zone.
        /// </summary>
        [JsonProperty("loadingPostalZone")]
        public string LoadingPostalZone { get; set; }

        /// <summary>
        /// The city name of the physical location where the goods are loaded. The default is the supplier's address city name.
        /// </summary>
        [JsonProperty("loadingCityName")]
        public string LoadingCityName { get; set; }

        /// <summary>
        /// The vehicle plate used to transport the goods.
        /// </summary>
        [JsonProperty("vehiclePlateNumber")]
        public string VehiclePlateNumber { get; set; }

        /// <summary>
        /// The physical location where the goods are unloaded. Defines the unloading from the freight. The default is the company's physical location.
        /// </summary>
        [JsonProperty("unloadingPoint")]
        public string UnloadingPoint { get; set; }

        /// <summary>
        /// The physical location address where the goods are unloaded. The default is the company's physical location address.
        /// </summary>
        [JsonProperty("unloadingPointAddress")]
        public string UnloadingPointAddress { get; set; }

        /// <summary>
        /// The goods unloading date and time on the unloading physical location.
        /// </summary>
        [JsonProperty("unloadingDateTime")]
        public DateTimeOffset? UnloadingDateTime { get; set; }

        /// <summary>
        /// The street name of the physical location where the goods are unloaded. The default is the company's address street name.
        /// </summary>
        [JsonProperty("unloadingStreetName")]
        public string UnloadingStreetName { get; set; }

        /// <summary>
        /// The building number of the physical location where the goods are unloaded. The default is the company's address building number.
        /// </summary>
        [JsonProperty("unloadingBuildingNumber")]
        public string UnloadingBuildingNumber { get; set; }

        /// <summary>
        /// The postal zone of the physical location where the goods are unloaded. The default is the company's address postal zone.
        /// </summary>
        [JsonProperty("unloadingPostalZone")]
        public string UnloadingPostalZone { get; set; }

        /// <summary>
        /// The city name of the physical location where the goods are unloaded. The default is the company's address city name.
        /// </summary>
        [JsonProperty("unloadingCityName")]
        public string UnloadingCityName { get; set; }

        /// <summary>
        /// The due date. In some countries it is also known as law date.
        /// </summary>
        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The alternative accounting party address key to be used on the invoice. The alternative addresses keys are defined on the party additional addresses. When defined overrides the accounting party address and unloading address values.
        /// </summary>
        [JsonProperty("accountingAltAddress")]
        public string AccountingAltAddress { get; set; }

        /// <summary>
        /// The accounting organization method. The organization can follow the rules of "Cash Accounting" or "Accrual Accounting".
        /// See AccountingSchema.
        /// </summary>
        [JsonProperty("accountingSchema")]
        public AccountingSchema AccountingSchema { get; set; }

        /// <summary>
        /// The supplier accounting organization method. The supplier organication can follow the rules of "Cash Accounting" or "Accrual Accounting".
        /// See AccountingSchema.
        /// </summary>
        [JsonProperty("partyAccountingSchema")]
        public AccountingSchema PartyAccountingSchema { get; set; }

        /// <summary>
        /// The invoice notification configuration. Inferred from the invoice type.
        /// </summary>
        [JsonProperty("notification")]
        public string Notification { get; set; }

        /// <summary>
        /// The email(s) to send invoice notification. Inferred from the notification.
        /// </summary>
        [JsonProperty("emailTo")]
        public string EmailTo { get; set; }

        /// <summary>
        /// The number of the check used for this invoice. Applicable only when the payment is cash payment and the payment method is of type check.
        /// </summary>
        [JsonProperty("checkNumber")]
        public int? CheckNumber { get; set; }


        #endregion Optional Properties

    }
}
