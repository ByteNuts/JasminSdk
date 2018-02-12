using System;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.CreateReceipt
{
    public class OpenAccountPostingLine
    {
        [JsonProperty("id")]
        public string Id { get; set; }


        #region Required Properties


        /// <summary>
        /// Indicates if the line has been selected to be included on the receipt.
        /// </summary>
        [JsonProperty("selected")]
        public bool Selected { get; set; }


        #endregion Required Properties



        #region Optional Properties


        /// <summary>
        /// The original document to be settled. The source documents is usually an invoice but other documents can be included on a receitp (ex: Credit or Debit Notes). Internally determined.
        /// </summary>
        [JsonProperty("sourceDoc")]
        public string SourceDoc { get; set; }

        /// <summary>
        /// The due date of the original document to be settled. Internally determined.
        /// </summary>
        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Financial transfer method used by the entity responsible for paying a transaction. For example, cash, transfer or check payments. The default is defined on the customer party.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// It indicates the total amount of the original document in the receipt currency. Internally determined.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// It indicates the current open amount of the original document in the receipt currency. One original document document can be partially settled over multiple receipts. Internally determined.
        /// </summary>
        [JsonProperty("open")]
        public decimal? Open { get; set; }

        /// <summary>
        /// It indicates the amount (in the receipt curreny) that is settled by this receipt. This amount is deducted to the original open amount. One original document document can be partially settled over multiple receipts.
        /// </summary>
        [JsonProperty("settled")]
        public decimal? Settled { get; set; }

        /// <summary>
        /// It indicates the discount amount (in the receipt curreny) that is settled by this receipt. This discount amount is deducted to the setteled amount. One original document document can be partially settled over multiple receipts.
        /// </summary>
        [JsonProperty("discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// It indicates the withholding tax amount (in the receipt curreny) that is settled by this receipt. In some countries, define the tax amount deducted at the beginning of the payment flow and paid to the tax authorities on behalf of the person / company subject to that tax. This amount is deducted to the original open amount.
        /// </summary>
        [JsonProperty("withholded")]
        public decimal? Withholded { get; set; }

        /// <summary>
        /// The unique identifier of then account posting for the line. Internally determined.
        /// </summary>
        [JsonProperty("accountPostingId")]
        public Guid? AccountPostingId { get; set; }

        /// <summary>
        /// The price of the document's currency expressed in the company's base currency. In other words, the rate at which the document's currency can be exchanged for the company's currency. The default is inferred using the defined exchange rates on the system for the document date and currency.
        /// </summary>
        [JsonProperty("exchangeRate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// The unique identifier of the original document nature (Debit or Credit). Internally determined.
        /// </summary>
        [JsonProperty("natureId")]
        public Guid? NatureId { get; set; }

        /// <summary>
        /// The unique identifier of the original document to be settled. The source documents is usually an invoice but other documents can be included on a receitp (ex: Credit or Debit Notes). Internally determined.
        /// </summary>
        [JsonProperty("sourceDocId")]
        public Guid? SourceDocId { get; set; }


        #endregion Optional Properties
    }
}
