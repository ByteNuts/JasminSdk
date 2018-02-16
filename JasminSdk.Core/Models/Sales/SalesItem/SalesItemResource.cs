using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem
{
    public class SalesItemResource
    {

        #region Required Properties

        /// <summary>
        /// The unit of measure for the sales item.
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// The sales item's tax schema. The tax schema identifies the group of taxes a item is liable for.
        /// </summary>
        [JsonProperty("itemTaxSchema")]
        public string ItemTaxSchema { get; set; }

        /// <summary>
        /// The defined income account.
        /// </summary>
        [JsonProperty("incomeAccount")]
        public string IncomeAccount { get; set; }

        /// <summary>
        /// The key for the item. Uniquely identifies the item within the organization.
        /// </summary>
        [JsonProperty("itemKey")]
        public string ItemKey { get; set; }


        #endregion Required Properties



        #region Optional Properties

        /// <summary>
        /// The sales item's withholding tax schema. The withholding tax schema identifies the group of withholding taxes a item is liable for.
        /// </summary>
        [JsonProperty("itemWithholdingTaxSchema")]
        public string ItemWithholdingTaxSchema { get; set; }

        /// <summary>
        /// The corresponding price list lines.
        /// </summary>
        [JsonProperty("priceListLines")]
        public List<PriceListLinesResource> PriceListLines { get; set; }


        #endregion Optional Properties

    }
}
