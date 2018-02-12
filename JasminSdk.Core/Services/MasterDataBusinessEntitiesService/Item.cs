using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Item;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService
{
    public class Item : IItem
    {
        protected readonly string EndPoint;
        internal Item(string endpoint) { EndPoint = endpoint; }



        #region GET

        public async Task<ApiResponse<ItemResource>> GetItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            return await ApiCall<ItemResource>.Get(url);
        }

        #endregion GET



        #region POST

        public async Task<ApiResponse<string>> PostItems(ApiItemResource item)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(item, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }


        #endregion POST




        #region PUT

        public async Task<ApiResponse<string>> PutSetItemDescription(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/description";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetItemComplementaryDescription(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/complementaryDescription";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }

        #endregion PUT
    }
}
