using System;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.Invoice
{
    public class ApiInvoiceDocumentLinesResource
    {
        #region Required Properties

        /// <summary>
        /// The sales item representing the good or service to be invoiced.
        /// </summary>
        [JsonProperty("salesItem")]
        public string SalesItem { get; set; }

        /// <summary>
        /// The invoice's line item description. The default is defined on the sales item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The invoice's line item quantity. The default 1.
        /// </summary>
        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// The invoice's line item unit price. The default price is loaded from sales item prices when there is a match on the combination of price list, currency, tax included and unit.
        /// </summary>
        [JsonProperty("unitPrice")]
        public MoneyResource UnitPrice { get; set; }

        /// <summary>
        /// The invoice's line item sales unit. The default sales unit is defined on the sales item.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The invoice's line item tax schema. The tax schema identifies the group of taxes a item is liable for. The default tax schema is defined on the sales item.
        /// </summary>
        [JsonProperty("itemTaxSchema")]
        public string ItemTaxSchema { get; set; }

        /// <summary>
        /// The expected line's item delivery date. The default is the document date.
        /// </summary>
        [JsonProperty("deliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The invoice's line item warehouse. The default is defined on the materials item.
        /// </summary>
        [JsonProperty("warehouse")]
        public string Warehouse { get; set; }

        /// <summary>
        /// The invoice's line item withholding tax schema. The withholding tax schema identifies the group of withholding taxes a item is liable for. The default withholding tax schema is defined on the sales item.
        /// </summary>
        [JsonProperty("itemWithholdingTaxSchema")]
        public string ItemWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The line's item discount 1 percentage. The default is 0.
        /// </summary>
        [JsonProperty("discount1")]
        public decimal? Discount1 { get; set; }

        /// <summary>
        /// The line's item discount 2 percentage. The default is 0.
        /// </summary>
        [JsonProperty("discount2")]
        public decimal? Discount2 { get; set; }

        /// <summary>
        /// The line's item discount 3 percentage. The default is 0.
        /// </summary>
        [JsonProperty("discount3")]
        public decimal? Discount3 { get; set; }

        /// <summary>
        /// The invoice's line item complementary description. The default is defined on the sales item.
        /// </summary>
        [JsonProperty("complementaryDescription")]
        public string ComplementaryDescription { get; set; }

        /// <summary>
        /// The invoice's line status. The default is Open.
        /// See DocumentLineStatus.
        /// </summary>
        [JsonProperty("documentLineStatus")]
        public DocumentLineStatus? DocumentLineStatus { get; set; }

        /// <summary>
        ///  The invoice's line item transaction account. Inferred from the sales item income account. Internally determined.
        /// </summary>
        [JsonProperty("transactionAccount")]
        public string TransactionAccount { get; set; }


        #endregion Optional Properties

    }
}
