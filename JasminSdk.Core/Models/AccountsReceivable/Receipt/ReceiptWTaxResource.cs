using System;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.Receipt
{
    public class ReceiptWTaxResource
    {
        #region Required Properties

        /// <summary>
        /// The receipt withholding tax taxable amount. Internally determined.
        /// </summary>
        [JsonProperty("taxableAmount")]
        public decimal? TaxableAmount { get; set; }

        /// <summary>
        /// The receipt total amount for a withhold tax. Internally calculated.
        /// </summary>
        [JsonProperty("withholdingTaxAmount")]
        public decimal? WithholdingTaxAmount { get; set; }

        /// <summary>
        /// If receipt's value is 0. Withholding tax should be ignored.
        /// </summary>
        [JsonProperty("ignore")]
        public bool? Ignore { get; set; }

        /// <summary>
        /// The original document to be settled. Internally determined.
        /// </summary>
        [JsonProperty("sourceDoc")]
        public string SourceDoc { get; set; }

        /// <summary>
        /// The receipt withholding tax code rate percentage. Internally determined.
        /// </summary>
        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// The receipt open amount for a withhold tax. Internally calculated.
        /// </summary>
        [JsonProperty("openWithholdingTaxAmount")]
        public decimal? OpenWithholdingTaxAmount { get; set; }

        /// <summary>
        /// The identifier of the original document to be settled. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocId")]
        public Guid? SourceDocId { get; set; }

        /// <summary>
        /// The receipt withholding open tax taxable amount. Internally determined.
        /// </summary>
        [JsonProperty("openTaxableAmount")]
        public decimal? OpenTaxableAmount { get; set; }

        /// <summary>
        /// The receipt withholding tax summary. Internally determined.
        /// </summary>
        [JsonProperty("wTaxSummary")]
        public string WTaxSummary { get; set; }

        /// <summary>
        /// The receipt withholding tax code. Internally determined.
        /// </summary>
        [JsonProperty("withholdingTaxCode")]
        public string WithholdingTaxCode { get; set; }

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
        /// The receipt withholding posting. Internally determined.
        /// </summary>
        [JsonProperty("withholdingPosting")]
        public string WithholdingPosting { get; set; }

        /// <summary>
        /// The receipt beneficiary party. Internally determined.
        /// </summary>
        [JsonProperty("beneficiaryParty")]
        public string BeneficiaryParty { get; set; }

        /// <summary>
        /// The receipt withholding tax posting. Internally determined.
        /// </summary>
        [JsonProperty("wTaxPosting")]
        public string WTaxPosting { get; set; }

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
