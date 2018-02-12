using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.Invoice
{
    public class InvoiceTaxResource
    {

        #region Required Properties

        /// <summary>
        /// The amount of revenue subject to tax. This taxable amount is calculated by subtracting the corresponding discounts and allowance charges to the gross value. Internally determined.
        /// </summary>
        [JsonProperty("taxableAmount")]
        public decimal? TaxableAmount { get; set; }

        /// <summary>
        /// Invoice tax amount. Internally determined.
        /// </summary>
        [JsonProperty("taxAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Indicates whether the invoice tax schema is exempt. Internally determined.
        /// </summary>
        [JsonProperty("isExempt")]
        public bool? IsExempt { get; set; }

        /// <summary>
        /// Invoice tax type code. Internally determined.
        /// </summary>
        [JsonProperty("taxTypeCode")]
        public string TaxTypeCode { get; set; }

        /// <summary>
        /// Money unit. Inferred from the invoice currency. Internally determined.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }


        #endregion Required Properties



        #region Optional Properties


        /// <summary>
        /// Invoice tax rate percentage. Internally determined.
        /// </summary>
        [JsonProperty("taxPercentage")]
        public decimal? TaxPercentage { get; set; }

        /// <summary>
        /// Indicates the invoice tax schema exemption reason. Applicable only if the tax schema is exempt. Internally determined.
        /// </summary>
        [JsonProperty("exemptionReasonCode")]
        public string ExemptionReasonCode { get; set; }

        /// <summary>
        /// Indicates the invoice tax schema custom exemption reason. Applicable only if the tax schema is exempt. Internally determined.
        /// </summary>
        [JsonProperty("customExemptionReasonCode")]
        public string CustomExemptionReasonCode { get; set; }


        #endregion Optional Properties

    }
}
