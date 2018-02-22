using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MaterialsCore.MaterialsItem;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MaterialsManagementService
{
    public class MaterialsItem : IMaterialsItem
    {
        protected readonly string EndPoint;
        protected readonly ILogger Logger;

        internal MaterialsItem(string endpoint, ILogger logger)
        {
            EndPoint = endpoint;
            Logger = logger;
        }

        #region GET



        #endregion GET




        #region POST

        public async Task<ApiResponse<string>> PostMaterialsItems(ApiMaterialsItemResource materialsItem)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/materialsCore/materialsItems", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(materialsItem, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(endpoint, content);
        }


        public async Task<ApiResponse<string>> PostMaterialsItem(ApiMaterialsItemMaterialsItemWarehousesResource materialsItemWharehouse, string itemKey)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/materialsCore/materialsItems/{3}/materialsItemWarehouses", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, itemKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(materialsItemWharehouse, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(endpoint, content);
        }

        #endregion POST




        #region PUT

        public async Task<ApiResponse<string>> PutSetDefaultWarehouse(string itemKey, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/materialsCore/materialsItems/{3}/defaultWarehouse", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, itemKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(endpoint, content);
        }

        #endregion PUT
    }
}
