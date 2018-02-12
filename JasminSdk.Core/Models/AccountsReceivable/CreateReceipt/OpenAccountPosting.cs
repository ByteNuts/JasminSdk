using System;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.CreateReceipt
{
    public class OpenAccountPosting
    {
        #region Required Properties

        /// <summary>
        /// The company code is the central organizational unit within the system.
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// The customer designated in the account posting as the party to whom should be sent the receipt. It may or may not be the party to whom the goods or services were delivered.
        /// </summary>
        [JsonProperty("party")]
        public string Party { get; set; }

        /// <summary>
        /// The date when the document is issued.
        /// </summary>
        [JsonProperty("documentDate")]
        public DateTime DocumentDate { get; set; }

        /// <summary>
        /// The price of the document's currency expressed in the company's base currency. In other words, the rate at which the document's currency can be exchanged for the company's base currency. The default is inferred using the defined exchange rates on the system for the document date and currency.
        /// </summary>
        [JsonProperty("documentExchangeRate")]
        public string DocumentExchangeRate { get; set; }

        /// <summary>
        /// Money unit used by the system, such as Euros (EUR) or United States Dollars (USD). This value is important for currency exchanges or to set the number of decimal places used to represent values. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Number of lines selected. Internally calculated.
        /// </summary>
        [JsonProperty("selectedCount")]
        public string SelectedCount { get; set; }

        /// <summary>
        /// Defines the receipt's purpose. Distinguishes the business transactions to be posted. The default receipt type is defined in the sales setup configuration setting.
        /// </summary>
        [JsonProperty("documentType")]
        public string DocumentType { get; set; }


        #endregion Required Properties



        #region Optional Properties


        /// <summary>
        /// The accounting posting starting due date. Ignored if not set, is used to filter the due date. Only account postings with due date greater than or equal to this value will be displayed.
        /// </summary>
        [JsonProperty("dueDateFrom")]
        public DateTime? DueDateFrom { get; set; }

        /// <summary>
        /// The accounting posting end due date. Ignored if not set, is used to filter the due date. Only account postings with due date less than or equal to this value will be displayed.
        /// </summary>
        [JsonProperty("dueDateUntil")]
        public DateTime? DueDateUntil { get; set; }

        /// <summary>
        /// Financial transfer method used by the entity responsible for paying a transaction. For example, cash, transfer or check payments. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Document total. Internally calculated.
        /// </summary>
        [JsonProperty("total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// The original document to be settled. The source documents is usually an invoice but other documents can be included on a receitp (ex: Credit or Debit Notes). Internally determined.
        /// </summary>
        [JsonProperty("sourceDoc")]
        public string SourceDoc { get; set; }


        #endregion Optional Properties
    }
}
