using System;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.Receipt
{
    public class ReceiptReportingLineResource
    {

        #region Optional Properties

        /// <summary>
        /// The original document to be settled. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("sourceDoc")]
        public string SourceDoc { get; set; }

        /// <summary>
        /// The issue date original document to be settled. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("issueDate")]
        public DateTime? IssueDate { get; set; }

        /// <summary>
        /// The due date of the original document to be settled. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("dueDate")]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The key of the money unit used on this receipt. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("currencyKey")]
        public string CurrencyKey { get; set; }

        /// <summary>
        /// It indicates the total amount of the original document in the receipt currency. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// It indicates the current open amount of the original document in the receipt currency. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("openAmount")]
        public decimal? OpenAmount { get; set; }

        /// <summary>
        /// It indicates the amount (in the receipt curreny) that is settled by this receipt. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("settledAmount")]
        public decimal? SettledAmount { get; set; }

        /// <summary>
        /// It indicates the discount amount (in the receipt curreny) that is settled by this receipt. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("discount")]
        public decimal? Discount { get; set; }

        /// <summary>
        /// It indicates the withholding tax amount (in the receipt curreny) that is settled by this receipt. Internally determined from the receipt line.
        /// </summary>
        [JsonProperty("withholdingTaxAmount")]
        public decimal? WithholdingTaxAmount { get; set; }

        /// <summary>
        /// The receipt line amount of revenue subject to tax. This taxable amount is calculated by subtracting the corresponding discounts and allowance charges to the gross value. Internally determined.
        /// </summary>
        [JsonProperty("taxableAmount")]
        public decimal? TaxableAmount { get; set; }

        /// <summary>
        /// The receipt line tax rate. Internally determined.
        /// </summary>
        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// The receipt line tax amount. Internally determined.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// The receipt line tax type code. Internally determined.
        /// </summary>
        [JsonProperty("taxTypeCode")]
        public string TaxTypeCode { get; set; }


        #endregion Optional Properties

    }
}
