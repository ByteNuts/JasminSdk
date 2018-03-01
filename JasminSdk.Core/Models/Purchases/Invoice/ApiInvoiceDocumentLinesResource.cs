using System;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Invoice
{
    public class ApiInvoiceDocumentLinesResource
    {
        #region Required Properties

        /// <summary>
        /// The purchase item representing the good or service included on the invoice.
        /// </summary>
        [JsonProperty("purchasesItem")]
        public string PurchasesItem { get; set; }

        /// <summary>
        /// The invoice line item tax schema. The tax schema identifies the group of taxes a item is liable for. The default tax schema is defined on the purchases item.
        /// </summary>
        [JsonProperty("itemTaxSchema")]
        public string ItemTaxSchema { get; set; }

        /// <summary>
        ///  The invoice line item purchases unit. The default purchases unit is defined on the purchases item.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The invoice line item description. The default is defined on the purchases item.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The invoice line item quantity. The default 1.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The invoice line item unit price. The default price is loaded from purchases item prices when there is a match on the combination of price list, currency, tax included and unit.
        /// </summary>
        [JsonProperty("unitPrice")]
        public MoneyResource UnitPrice { get; set; }

        /// <summary>
        /// The expected line item delivery date. The default is the document date.
        /// </summary>
        [JsonProperty("deliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// The document line status. The default is Open.
        /// See DocumentLineStatus.
        /// </summary>
        [JsonProperty("documentLineStatus")]
        public DocumentLineStatus? DocumentLineStatus { get; set; }

        /// <summary>
        /// The item current unit cost. Used only on inventory items, this value is infered from the material item depending on the warehouse used on this line.
        /// </summary>
        [JsonProperty("unitCost")]
        public decimal? UnitCost { get; set; }

        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The invoice line item withholding tax schema. The withholding tax schema identifies the group of withholding taxes a item is liable for. The default withholding tax schema is defined on the purchases item.
        /// </summary>
        [JsonProperty("itemWithholdingTaxSchema")]
        public string ItemWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The invoice line item base unit. The default unit is defined on the item.
        /// </summary>
        [JsonProperty("baseUnit")]
        public string BaseUnit { get; set; }

        /// <summary>
        /// The invoice line item warehouse. The default is defined on the materials item.
        /// </summary>
        [JsonProperty("warehouse")]
        public string Warehouse { get; set; }

        /// <summary>
        /// The memo line item discount 1 percetange. The default is 0.
        /// </summary>
        [JsonProperty("discount1")]
        public decimal? Discount1 { get; set; }

        /// <summary>
        /// The invoice line item discount 2 percentage. The default is 0. This discount is applied over the remaining value after discount 1 is applied.
        /// </summary>
        [JsonProperty("discount2")]
        public decimal? Discount2 { get; set; }

        /// <summary>
        /// The invoice line item discount 3 percentage. The default is 0. This discount is applied over the remaining value after discount 1 and 2 are applied.
        /// </summary>
        [JsonProperty("discount3")]
        public decimal? Discount3 { get; set; }

        /// <summary>
        /// The invoice line item complementary description. The default is defined on the sales item.
        /// </summary>
        [JsonProperty("complementaryDescription")]
        public string ComplementaryDescription { get; set; }

        /// <summary>
        /// The invoice line item transaction account. Inferred from the purchases item income account. Internally determined.
        /// </summary>
        [JsonProperty("transactionAccount")]
        public string TransactionAccount { get; set; }


        #endregion Optional Properties

    }
}
