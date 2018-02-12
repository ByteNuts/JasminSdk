using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.Invoice
{
    public class ApiInvoiceDocumentTaxesResource
    {

        #region Optional Properties

        /// <summary>
        /// Indicates the invoice tax schema custom exemption reason. Applicable only if the tax schema is exempt. Internally determined.
        /// </summary>
        [JsonProperty("customExemptionReasonCode")]
        public string CustomExemptionReasonCode { get; set; }


        #endregion Optional Properties

    }
}
