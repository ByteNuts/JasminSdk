using System;
using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.PurchaseItem
{
    public class PurchasesItemResource
    {

        #region Required Properties

        /// <summary>
        /// The unit for the purchases item.
        /// (fk) Allowed value: the natural key of a record of type Unit. These records are accessibly through the Units service.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The last price for the item.
        /// </summary>
        [JsonProperty("lastPrice")]
        public decimal? LastPrice { get; set; }

        /// <summary>
        /// The money unit used by the system, such as Euros (EUR) or United States Dollars (USD). This value is important for currency exchanges or to set the number of decimal places used to represent values.
        /// (fk) Allowed value: the natural key of a record of type Currency. These records are accessibly through the Currencies service.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The purchases item tax schema. The tax schema identifies the group of taxes a item is liable for.
        /// (fk) Allowed value: the natural key of a record of type ItemTaxSchema. These records are accessibly through the ItemTaxSchemas service.
        /// </summary>
        [JsonProperty("itemTaxSchema")]
        public string ItemTaxSchema { get; set; }

        /// <summary>
        /// The expense account for the item.
        /// (fk) Allowed value: the natural key of a record of type Account.
        /// </summary>
        [JsonProperty("expenseAccount")]
        public string ExpenseAccount { get; set; }

        /// <summary>
        /// The key for the item. Uniquely identifies the item within the organization.
        /// </summary>
        [JsonProperty("itemKey")]
        public string ItemKey { get; set; }


        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The last supplier for the item.
        /// (fk) Allowed value: the natural key of a record of type Party. These records are accessibly through the Parties service.
        /// </summary>
        [JsonProperty("lastSupplierParty")]
        public string LastSupplierParty { get; set; }

        /// <summary>
        /// The last document for the item.
        /// </summary>
        [JsonProperty("lastSourceDoc")]
        public string LastSourceDoc { get; set; }

        /// <summary>
        /// The last document date for the item.
        /// </summary>
        [JsonProperty("lastSourceDocDate")]
        public DateTime? LastSourceDocDate { get; set; }

        /// <summary>
        /// The last unit for the item.
        /// (fk) Allowed value: the natural key of a record of type Unit. These records are accessibly through the Units service.
        /// </summary>
        [JsonProperty("lastUnit")]
        public string LastUnit { get; set; }

        /// <summary>
        /// The item withholding tax schema. The withholding tax schema identifies the group of withholding taxes a item is liable for.
        /// (fk) Allowed value: the natural key of a record of type ItemWithholdingTaxSchema. These records are accessibly through the ItemWithholdingTaxSchemas service.
        /// </summary>
        [JsonProperty("itemWithholdingTaxSchema")]
        public string ItemWithholdingTaxSchema { get; set; }



        #endregion Optional Properties

    }
}
