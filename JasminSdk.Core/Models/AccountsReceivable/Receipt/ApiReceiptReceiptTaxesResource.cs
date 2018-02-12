using System;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.Receipt
{
    public class ApiReceiptReceiptTaxesResource
    {
        #region Required Properties

        /// <summary>
        /// The amount of revenue subject to tax. This taxable amount is calculated by subtracting the corresponding discounts and allowance charges to the gross value. Internally determined.
        /// </summary>
        [JsonProperty("taxableAmount")]
        public decimal? TaxableAmount { get; set; }

        /// <summary>
        /// The receipt tax amount. Internally determined.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// The original document to be settled. Internally determined.
        /// </summary>
        [JsonProperty("sourceDoc")]
        public string SourceDoc { get; set; }

        /// <summary>
        /// The receipt tax rate. Internally determined.
        /// </summary>
        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// The receipt opened tax amount. Internally determined.
        /// </summary>
        [JsonProperty("openTaxAmount")]
        public decimal? OpenTaxAmount { get; set; }

        /// <summary>
        /// The identifier of the original document to be settled. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocId")]
        public Guid? SourceDocId { get; set; }

        /// <summary>
        /// The receipt opened taxable amount. Internally determined.
        /// </summary>
        [JsonProperty("openTaxableAmount")]
        public decimal? OpenTaxableAmount { get; set; }

        /// <summary>
        /// The unique identifier of the schema entity from the originating document, possible values: Orders, Deliveries, GoodsReturns. Internally determined.
        /// </summary>
        [JsonProperty("sourceSchemaEntityId")]
        public Guid? SourceSchemaEntityId { get; set; }

        /// <summary>
        /// The receipt tax summary. Internally determined.
        /// </summary>
        [JsonProperty("taxSummary")]
        public string TaxSummary { get; set; }

        /// <summary>
        /// The receipt tax type code. Internally determined.
        /// </summary>
        [JsonProperty("taxTypeCode")]
        public string TaxTypeCode { get; set; }

        /// <summary>
        /// Money unit. Inferred from the receipt currency. Internally determined.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The price of the document's currency expressed in the company's base currency. In other words, the rate at which the document's currency can be exchanged for the company's currency. The default is inferred using the defined exchange rates on the system for the document date and currency.
        /// </summary>
        [JsonProperty("exchangeRate")]
        public decimal? ExchangeRate { get; set; }


        #endregion Required Properties



        #region Optional Properties


        /// <summary>
        /// Indicates the receipt tax schema is exempt. Internally determined.
        /// </summary>
        [JsonProperty("isExempt")]
        public bool? IsExempt { get; set; }

        /// <summary>
        /// The receipt tax posting. Internally determined.
        /// </summary>
        [JsonProperty("taxPosting")]
        public string TaxPosting { get; set; }

        /// <summary>
        /// Indicates the receipt tax schema exemption reason. Applicable only if the tax schema is exempt. Internally determined.
        /// </summary>
        [JsonProperty("exemptionReasonCode")]
        public string ExemptionReasonCode { get; set; }

        /// <summary>
        /// The exchange rate creation date.
        /// </summary>
        [JsonProperty("exchangeRateDate")]
        public DateTime? ExchangeRateDate { get; set; }


        #endregion Optional Properties
    }
}
