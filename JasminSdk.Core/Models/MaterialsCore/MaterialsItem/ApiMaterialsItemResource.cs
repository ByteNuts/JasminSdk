using System.Collections.Generic;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MaterialsCore.MaterialsItem
{
    public class ApiMaterialsItemResource
    {

        #region Required Properties

        [JsonProperty("defaultWarehouse")]
        public string DefaultWarehouse { get; set; }

        [JsonProperty("itemKey")]
        public string ItemKey { get; set; }


        #endregion Required Properties



        #region Optional Properties

        [JsonProperty("maxStock")]
        public decimal? MaxStock { get; set; }

        [JsonProperty("minStock")]
        public decimal? MinStock { get; set; }

        [JsonProperty("materialsItemWarehouses")]
        public List<ApiMaterialsItemMaterialsItemWarehousesResource> MaterialsItemWarehouses { get; set; }

        [JsonProperty("itemSubtype")]
        public string ItemSubtype { get; set; }


        #endregion Optional Properties

    }
}
