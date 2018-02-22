using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Item;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService
{
    public class Item : IItem
    {
        protected readonly string EndPoint;
        protected readonly ILogger Logger;

        internal Item(string endpoint, ILogger logger)
        {
            EndPoint = endpoint;
            Logger = logger;
        }



        #region GET

        public async Task<ApiResponse<List<ItemResource>>> GetItems()
        {
            var url = $"{EndPoint}";

            var apiCall = new ApiCall<List<ItemResource>>(Logger);
            return await apiCall.Get(url);
        }

        public async Task<ApiResponse<List<ItemResource>>> GetItems(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<List<ItemResource>>(Logger);
            return await apiCall.Get(url);
        }

        public async Task<ApiResponse<ItemResource>> GetItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<ItemResource>(Logger);
            return await apiCall.Get(url, true);
        }

        public async Task<ApiResponse<ItemResource>> GetItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            var apiCall = new ApiCall<ItemResource>(Logger);
            return await apiCall.Get(url, true);
        }

        public async Task<ApiResponse<byte[]>> GetPrintItemByIdentifier(string id, string template = null)
        {
            var url = $"{EndPoint}/{id}/print{(!string.IsNullOrEmpty(template) ? $"?template={template}" : "")}";

            var apiCall = new ApiCall<byte[]>(Logger);
            return await apiCall.Get(url, true);
        }

        public async Task<ApiResponse<byte[]>> GetPrintItemByKey(string itemKey, string template = null)
        {
            var url = $"{EndPoint}/{itemKey}/print{(!string.IsNullOrEmpty(template) ? $"?template={template}" : "")}";

            var apiCall = new ApiCall<byte[]>(Logger);
            return await apiCall.Get(url, true);
        }

        public async Task<ApiResponse<byte[]>> GetItemImage(string id)
        {
            var url = $"{EndPoint}/{id}/image";

            var apiCall = new ApiCall<byte[]>(Logger);
            return await apiCall.Get(url, true);
        }


        #endregion GET



        #region POST

        public async Task<ApiResponse<string>> PostItems(ApiItemResource itemResource)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(itemResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        #endregion POST




        #region PUT

        public async Task<ApiResponse<string>> PutSetAssortmentItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/assortment";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetBarcodeItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/barcode";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetBaseUnitItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/baseUnit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetBrandItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/brand";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetBrandModelItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/brandModel";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetComplementaryDescriptionItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/complementaryDescription";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDescriptionItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/description";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetImageItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/image";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsActiveItem(string itemKey, bool value)
        {
            var url = $"{EndPoint}/{itemKey}/isActive";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetItemKeyItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/itemKey";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetItemTypeItem(string itemKey, ItemTypeEnum value)
        {
            var url = $"{EndPoint}/{itemKey}/itemType";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetRemarksItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/remarks";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        #endregion PUT


        #region DELETE

        public async Task<ApiResponse<string>> DeleteItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeleteItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        #endregion DELETE
    }
}
