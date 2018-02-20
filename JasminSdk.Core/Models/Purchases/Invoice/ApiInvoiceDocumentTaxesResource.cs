using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Invoice
{
    public class ApiInvoiceDocumentTaxesResource
    {

        #region Required Properties

        /// <summary>
        /// The rounding value of the invoice amount of revenue subject to tax.
        /// </summary>
        [JsonProperty("roundingTaxableAmount")]
        public decimal? RoundingTaxableAmount { get; set; }

        /// <summary>
        /// The rounding value of the invoice tax amount. Internally determined.
        /// </summary>
        [JsonProperty("roundingTaxAmount")]
        public decimal? RoundingTaxAmount { get; set; }


        #endregion Required Properties

    }
}
