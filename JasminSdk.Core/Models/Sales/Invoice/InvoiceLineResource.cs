using System;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.Invoice
{
    public class InvoiceLineResource
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
        /// The invoice's customer party tax schema. The tax schema identifies the group of taxes a party is liable for. The tax schema is defined in the customer party.
        /// </summary>
        [JsonProperty("partyTaxSchema")]
        public string PartyTaxSchema { get; set; }

        /// <summary>
        /// The expected line's item delivery date. The default is the document date.
        /// </summary>
        [JsonProperty("deliveryDate")]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// The total’s amount of taxes for this line. Internally calculated.
        /// </summary>
        [JsonProperty("taxTotal")]
        public decimal? TaxTotal { get; set; }

        /// <summary>
        /// The invoice’s line total discount. Internally calculated.
        /// </summary>
        [JsonProperty("allowanceChargeAmount")]
        public decimal? AllowanceChargeAmount { get; set; }

        /// <summary>
        /// The invoice's line net value. The line value after discounts, excluding taxes. Internally calculated.
        /// </summary>
        [JsonProperty("taxExclusiveAmount")]
        public decimal? TaxExclusiveAmount { get; set; }

        /// <summary>
        /// The invoice's line value before taxes or discounts. Internally calculated.
        /// </summary>
        [JsonProperty("grossValue")]
        public decimal? GrossValue { get; set; }

        /// <summary>
        /// The invoice's line payable amount. The line value including taxes and discounts. Internally calculated.
        /// </summary>
        [JsonProperty("lineExtensionAmount")]
        public decimal? LineExtensionAmount { get; set; }

        /// <summary>
        /// The money’s unit. Inferred from the invoice currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The invoice's line item type. Inferred from the sales item type. Internally determined.
        /// See ItemType.
        /// </summary>
        [JsonProperty("itemType")]
        public ItemTypeEnum ItemType { get; set; }



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
        /// The invoice's customer party withholding tax schema. The withholding tax schema identifies the group of withholding taxes a party is liable for. The withholding tax schema is defined in the customer party.
        /// </summary>
        [JsonProperty("partyWithholdingTaxSchema")]
        public string PartyWithholdingTaxSchema { get; set; }

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
        /// The schema’s entity from originating document, possible values: Orders, Deliveries, GoodsReturns.
        /// </summary>
        [JsonProperty("sourceSchemaEntity")]
        public string SourceSchemaEntity { get; set; }

        /// <summary>
        /// The source document using the format {..} when the invoice is transformed from another document. Internally determined.
        /// </summary>
        [JsonProperty("sourceDoc")]
        public string SourceDoc { get; set; }

        /// <summary>
        /// The source document identifier when the invoice is transformed from other source document. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocId")]
        public Guid? SourceDocId { get; set; }

        /// <summary>
        /// The source document's line number, when the invoice was transformed. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocLine")]
        public int? SourceDocLine { get; set; }

        /// <summary>
        /// The source document's line identifier, when the invoice was transformed. Internally determined.
        /// </summary>
        [JsonProperty("sourceDocLineId")]
        public Guid? SourceDocLineId { get; set; }

        /// <summary>
        /// The source delivery when the invoice is transformed from a transport document.
        /// </summary>
        [JsonProperty("delivery")]
        public string Delivery { get; set; }

        /// <summary>
        /// The source delivery's identifier when the invoice was transformed from delivery. Internally determined.
        /// </summary>
        [JsonProperty("deliveryId")]
        public Guid? DeliveryId { get; set; }

        /// <summary>
        /// The source delivery's line index when the invoice is transformed from a transport document.
        /// </summary>
        [JsonProperty("deliveryLine")]
        public int? DeliveryLine { get; set; }

        /// <summary>
        /// The source delivery's line identifier when the invoice is transformed from a transport document. Internally determined.
        /// </summary>
        [JsonProperty("deliveryLineId")]
        public Guid? DeliveryLineId { get; set; }

        /// <summary>
        /// The billing request's identifier that originated the invoice line, when the invoice is transformed. Internally determined.
        /// </summary>
        [JsonProperty("billingRequestId")]
        public Guid? BillingRequestId { get; set; }

        /// <summary>
        /// The billing request's line id that originated the invoice line, when the invoice is transformed. Internally determined.
        /// </summary>
        [JsonProperty("billingRequestLineId")]
        public Guid? BillingRequestLineId { get; set; }

        /// <summary>
        ///  The invoice's line item transaction account. Inferred from the sales item income account. Internally determined.
        /// </summary>
        [JsonProperty("transactionAccount")]
        public string TransactionAccount { get; set; }


        #endregion Optional Properties

    }
}
