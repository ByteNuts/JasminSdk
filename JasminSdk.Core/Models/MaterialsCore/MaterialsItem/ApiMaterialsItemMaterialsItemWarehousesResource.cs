using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MaterialsCore.MaterialsItem
{
    public class ApiMaterialsItemMaterialsItemWarehousesResource
    {

        #region Required Properties

        [JsonProperty("warehouse")]
        public string Warehouse { get; set; }

        [JsonProperty("stockBalance")]
        public decimal StockBalance { get; set; }

        [JsonProperty("calculatedUnitCost")]
        public decimal CalculatedUnitCost { get; set; }

        [JsonProperty("inventoryBalance")]
        public decimal InventoryBalance { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("committedQuantity")]
        public decimal CommittedQuantity { get; set; }

        [JsonProperty("orderedQuantity")]
        public decimal OrderedQuantity { get; set; }

        [JsonProperty("lastUnitCost")]
        public decimal LastUnitCost { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }


        #endregion Required Properties

    }
}
