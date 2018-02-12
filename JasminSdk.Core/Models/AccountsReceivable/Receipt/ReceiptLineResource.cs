using System;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.Receipt
{
    public class ReceiptLineResource
    {
        #region Required Properties

        /// <summary>
        /// It indicates the amount (in the receipt curreny) that is settled by this receipt. This amount is deducted to the original open amount. One original document document can be partially settled over multiple receipts.
        /// </summary>
        [JsonProperty("settledAmount")]
        public decimal? SettledAmount { get; set; }

        /// <summary>
        /// It indicates the discount amount (in the receipt curreny) that is settled by this receipt. This discount amount is deducted to the setteled amount. One original document document can be partially settled over multiple receipts.
        /// </summary>
        [JsonProperty("discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// The due date of the original document to be settled. Internally determined.
        /// </summary>
        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The issue date original document to be settled. Internally determined.
        /// </summary>
        [JsonProperty("issueDate")]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// It indicates the total amount of the original document in the receipt currency. Internally determined.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// It indicates the current open amount of the original document in the receipt currency. One original document document can be partially settled over multiple receipts. Internally determined.
        /// </summary>
        [JsonProperty("openAmount")]
        public decimal? OpenAmount { get; set; }

        /// <summary>
        /// Indicates that the current line is selected to include on current receipt.
        /// </summary>
        [JsonProperty("settled")]
        public bool? Settled { get; set; }

        /// <summary>
        /// It indicates the withholding tax amount (in the receipt curreny) that is settled by this receipt. In some countries, define the tax amount deducted at the beginning of the payment flow and paid to the tax authorities on behalf of the person / company subject to that tax. This amount is deducted to the original open amount.
        /// </summary>
        [JsonProperty("withholdingTaxAmount")]
        public decimal? WithholdingTaxAmount { get; set; }

        /// <summary>
        /// It indicates the open withholding tax amount (in the receipt curreny) that is settled by this receipt. In some countries, define the tax amount deducted at the beginning of the payment flow and paid to the tax authorities on behalf of the person / company subject to that tax. This amount is deducted to the original open amount. Internally determined.
        /// </summary>
        [JsonProperty("openWithholdingTaxAmount")]
        public decimal? OpenWithholdingTaxAmount { get; set; }

        /// <summary>
        /// The original document nature (Debit or Credit). Internally determined.
        /// </summary>
        [JsonProperty("nature")]
        public Nature Nature { get; set; }

        /// <summary>
        /// Money unit used by the system, such as Euros (EUR) or United States Dollars (USD). This value is important for currency exchanges or to set the number of decimal places used to represent values. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The price of the document's currency expressed in the company's base currency. In other words, the rate at which the document's currency can be exchanged for the company's currency. The default is inferred using the defined exchange rates on the system for the document date and currency.
        /// </summary>
        [JsonProperty("exchangeRate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// It indicates the amount (in the original document currency) that is settled by this receipt. This amount is deducted to the original open amount. One original document document can be partially settled over multiple receipts. Internally determined.
        /// </summary>
        [JsonProperty("settledOriginalAmount")]
        public decimal? SettledOriginalAmount { get; set; }

        /// <summary>
        /// The price of the document's currency expressed in the company's base currency. In other words, the rate at which the document's currency can be exchanged for the company's base currency. The default is inferred using the defined exchange rates on the system for the document date and currency.
        /// </summary>
        [JsonProperty("baseExchangeRate")]
        public decimal? BaseExchangeRate { get; set; }

        /// <summary>
        /// The price of the document's currency expressed in the organization reporting currency. In other words, the rate at which the document's currency can be exchanged for the organization reporting currency. The default is inferred using the defined exchange rates on the system for the document date and currency.
        /// </summary>
        [JsonProperty("reportingExchangeRate")]
        public decimal? ReportingExchangeRate { get; set; }

        /// <summary>
        /// The original price of the document's currency expressed in the receipt's currency. In other words, the rate at which the document's original currency can be exchanged for the receipt's currency. Internally infered.
        /// </summary>
        [JsonProperty("originalExchangeRate")]
        public decimal? OriginalExchangeRate { get; set; }


        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The original document to be settled. The source documents is usually an invoice but other documents can be included on a receitp (ex: Credit or Debit Notes). Internally determined.
        /// </summary>
        [JsonProperty("sourceDoc")]
        public string SourceDoc { get; set; }

        /// <summary>
        /// The key of the money unit used on this receipt. Internaly determined.
        /// </summary>
        [JsonProperty("currencyKey")]
        public string CurrencyKey { get; set; }

        /// <summary>
        /// The identifier of the original document to be settled. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocId")]
        public Guid? SourceDocId { get; set; }

        /// <summary>
        /// The accounting posting of the original documents. Internally determined.
        /// </summary>
        [JsonProperty("accountPosting")]
        public string AccountPosting { get; set; }

        /// <summary>
        /// The receipt document financial area (Accounts Receivable or Accounts Payable). Internally determined.
        /// </summary>
        [JsonProperty("financialArea")]
        public FinancialArea FinancialArea { get; set; }

        /// <summary>
        /// Financial transfer method used by the entity responsible for paying a transaction. For example, cash, transfer or check payments. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The schema of the source document entity. Internally determined.
        /// </summary>
        [JsonProperty("sourceSchemaEntity")]
        public string SourceSchemaEntity { get; set; }

        /// <summary>
        /// The exchange rate creation date.
        /// </summary>
        [JsonProperty("exchangeRateDate")]
        public DateTime? ExchangeRateDate { get; set; }

        
        #endregion Optional Properties
    }
}
