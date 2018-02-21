using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MaterialsCore.MaterialsItem;
using System.Threading.Tasks;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MaterialsCoreService
{
    public interface IMaterialsItem
    {
        #region GET



        #endregion GET




        #region POST

        Task<ApiResponse<string>> PostMaterialsItems(ApiMaterialsItemResource materialsItem);


        Task<ApiResponse<string>> PostMaterialsItem(ApiMaterialsItemMaterialsItemWarehousesResource materialsItemWharehouse, string itemKey);


        #endregion POST




        #region PUT

        Task<ApiResponse<string>> PutSetDefaultWarehouse(string itemKey, string value);

        #endregion PUT
    }
}
