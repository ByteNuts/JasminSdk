using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Item;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService
{
    public interface IItem
    {
        #region GET

        Task<ApiResponse<ItemResource>> GetItemByKey(string itemKey);

        #endregion GET


        #region POST

        Task<ApiResponse<string>> PostItems(ApiItemResource item);

        #endregion POST

        #region PUT

        Task<ApiResponse<string>> PutSetItemDescription(string itemKey, string value);

        Task<ApiResponse<string>> PutSetItemComplementaryDescription(string itemKey, string value);

        #endregion PUT

    }
}
