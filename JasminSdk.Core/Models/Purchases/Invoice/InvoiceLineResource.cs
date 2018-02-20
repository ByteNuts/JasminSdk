using System;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Invoice
{
    public class InvoiceLineResource
    {
        #region Required Properties

        /// <summary>
        /// The purchase item representing the good or service included on the invoice.
        /// </summary>
        [JsonProperty("purchasesItem")]
        public string PurchasesItem { get; set; }

        /// <summary>
        /// The money unit. Inferred from the invoice currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The invoice line item tax schema. The tax schema identifies the group of taxes a item is liable for. The default tax schema is defined on the purchases item.
        /// </summary>
        [JsonProperty("itemTaxSchema")]
        public string ItemTaxSchema { get; set; }

        /// <summary>
        /// The invoice supplier party tax schema. The tax schema identifies the group of taxes a party is liable for. The tax schema is defined in the supplier party.
        /// </summary>
        [JsonProperty("partyTaxSchema")]
        public string PartyTaxSchema { get; set; }

        /// <summary>
        /// The invoice line item purchases unit. The default purchases unit is defined on the purchases item.
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
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Total amount of taxes for this line. Internally calculated.
        /// </summary>
        [JsonProperty("taxTotal")]
        public decimal? TaxTotal { get; set; }

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
        /// Total amount of taxes for this line. Internally calculated.
        /// </summary>
        [JsonProperty("allowanceChargeAmount")]
        public decimal? AllowanceChargeAmount { get; set; }

        /// <summary>
        /// The invoice line net value. The line value after discounts, excluding taxes. Internally calculated.
        /// </summary>
        [JsonProperty("taxExclusiveAmount")]
        public decimal? TaxExclusiveAmount { get; set; }

        /// <summary>
        /// The invoice line payable amount. The line value including taxes and discounts. Internally calculated.
        /// </summary>
        [JsonProperty("lineExtensionAmount")]
        public decimal? LineExtensionAmount { get; set; }

        /// <summary>
        /// The item current unit cost. Used only on inventory items, this value is infered from the material item depending on the warehouse used on this line.
        /// </summary>
        [JsonProperty("unitCost")]
        public decimal? UnitCost { get; set; }

        /// <summary>
        /// The invoice line value before taxes or discounts. Internally calculated.
        /// </summary>
        [JsonProperty("grossValue")]
        public decimal? GrossValue { get; set; }

        /// <summary>
        /// The conversion factor from the invoice line purchase unit to the purchase item base unit. In other words, the rate at which the item purchase's unit can be converter to the purchase item base unit.
        /// </summary>
        [JsonProperty("conversionFactor")]
        public decimal? ConversionFactor { get; set; }

        /// <summary>
        /// The invoice line item type. Inferred from the puchase item type. Internally determined.
        /// See ItemType.
        /// </summary>
        [JsonProperty("itemType")]
        public ItemTypeEnum ItemType { get; set; }



        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The invoice line item withholding tax schema. The withholding tax schema identifies the group of withholding taxes a item is liable for. The default withholding tax schema is defined on the purchases item.
        /// </summary>
        [JsonProperty("itemWithholdingTaxSchema")]
        public string ItemWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The invoice supplier party withholding tax schema. The withholding tax schema identifies the group of withholding taxes a party is liable for. The withholding tax schema is defined in the supplier party.
        /// </summary>
        [JsonProperty("partyWithholdingTaxSchema")]
        public string PartyWithholdingTaxSchema { get; set; }

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
        /// The value of stock represented by this line. Used only on inventory items, this value is internally calculated using the Unit Cost and quantity.
        /// </summary>
        [JsonProperty("inventoryAmount")]
        public decimal? InventoryAmount { get; set; }

        /// <summary>
        /// The invoice line item complementary description. The default is defined on the sales item.
        /// </summary>
        [JsonProperty("complementaryDescription")]
        public string ComplementaryDescription { get; set; }

        /// <summary>
        /// The schema's entity from originating document, possible values: Quotations, Orders, Deliveries, Invoices, GoodsReturns, Memos, DebitNotes.
        /// </summary>
        [JsonProperty("sourceSchemaEntity")]
        public string SourceSchemaEntity { get; set; }

        /// <summary>
        /// The source document using the format {..} when the invoice was transformed. The source document is usually the order. Internally determined.
        /// </summary>
        [JsonProperty("sourceDoc")]
        public string SourceDoc { get; set; }

        /// <summary>
        /// The unique identifier of the source document, when the invoice was transformed. The source document is usually the order. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocId")]
        public Guid? SourceDocId { get; set; }

        /// <summary>
        /// The source document line number, when the invoice was transformed. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocLine")]
        public int? SourceDocLine { get; set; }

        /// <summary>
        /// The source document line id, when the invoice was transformed. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocLineId")]
        public Guid? SourceDocLineId { get; set; }

        /// <summary>
        /// The goods receipt notification that originated the invoice line, when the invoice is transformed. Internally determined.
        /// </summary>
        [JsonProperty("goodsReceiptNote")]
        public string GoodsReceiptNote { get; set; }

        /// <summary>
        /// The goods receipt notification unique identifier that originated the invoice line, when the invoice is transformed. Internally determined.
        /// </summary>
        [JsonProperty("goodsReceiptNoteId")]
        public Guid? GoodsReceiptNoteId { get; set; }

        /// <summary>
        /// The goods receipt notification line number that originated the invoice line, when the invoice is transformed. Internally determined.
        /// </summary>
        [JsonProperty("goodsReceiptNoteLine")]
        public int? GoodsReceiptNoteLine { get; set; }

        /// <summary>
        /// The goods receipt notification line unique identifier that originated the invoice line, when the invoice is transformed. Internally determined.
        /// </summary>
        [JsonProperty("goodsReceiptNoteLineId")]
        public Guid? GoodsReceiptNoteLineId { get; set; }

        /// <summary>
        /// The invoice receipt notification unique identifier that originated the invoice line, when the invoice is transformed. Internally determined.
        /// </summary>
        [JsonProperty("invoiceReceiptNotificationId")]
        public Guid? InvoiceReceiptNotificationId { get; set; }

        /// <summary>
        /// The invoice receipt notification line id that originated the invoice line, when the invoice is transformed. Internally determined.
        /// </summary>
        [JsonProperty("invoiceReceiptNotificationLineId")]
        public Guid? InvoiceReceiptNotificationLineId { get; set; }

        /// <summary>
        /// The invoice line item transaction account. Inferred from the purchases item income account. Internally determined.
        /// </summary>
        [JsonProperty("transactionAccount")]
        public string TransactionAccount { get; set; }


        #endregion Optional Properties

    }
}
