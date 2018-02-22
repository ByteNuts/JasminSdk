using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Sales
{
    public class SalesItem : ISalesItem
    {
        protected readonly string EndPoint;
        protected readonly ILogger Logger;
        internal SalesItem(string endpoint, ILogger logger)
        {
            EndPoint = endpoint;
            Logger = logger;
        }

        #region GET


        public async Task<ApiResponse<List<SalesItemResource>>> GetSalesItems()
        {
            var url = $"{EndPoint}/extension";

            var apiCall = new ApiCall<List<SalesItemResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<List<SalesItemResource>>> GetSalesItems(int page, int pageSize)
        {
            var url = $"{EndPoint}/extension?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<List<SalesItemResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<SalesItemResource>> GetSalesItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}/extension";

            var apiCall = new ApiCall<SalesItemResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<SalesItemResource>> GetSalesItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}/extension";

            var apiCall = new ApiCall<SalesItemResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<List<BaseSalesItemResource>>> GetSalesItemWithItem()
        {
            var url = $"{EndPoint}";

            var apiCall = new ApiCall<List<BaseSalesItemResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<List<BaseSalesItemResource>>> GetSalesItemWithItem(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<List<BaseSalesItemResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<BaseSalesItemResource>> GetSalesItemWithItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<BaseSalesItemResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<BaseSalesItemResource>> GetSalesItemWithItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            var apiCall = new ApiCall<BaseSalesItemResource>(Logger);
            return await apiCall.Get(url, true);
        }


        #endregion GET




        #region POST

        public async Task<ApiResponse<string>> PostSalesItem(ApiSalesItemResource salesItemResource)
        {
            var url = $"{EndPoint}/extension";

            var json = JsonConvert.SerializeObject(salesItemResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostSalesItemWithApiBaseSalesItem(ApiBaseSalesItemResource salesItemResource)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(salesItemResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostSalesItemPriceListLine(string itemKey, ApiBaseSalesItemPriceListLinesResource value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines";


            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }

        #endregion POST




        #region PUT

        public async Task<ApiResponse<string>> PutSetCurrencyPriceListLine(string itemKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}/currency";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIncomeAccountSalesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/incomeAccount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsActiveSalesItem(string itemKey, bool value)
        {
            var url = $"{EndPoint}/{itemKey}/isActive";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetItemTaxSchemaSalesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/itemTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetItemWithholdingTaxSchemaSalesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/itemWithholdingTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPriceAmountPriceListLine(string itemKey, string lineId, decimal value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}/priceAmount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPriceListPriceListLine(string itemKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}/priceList";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnitPriceListLine(string itemKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}/unit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetUnitSalesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/unit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }



        #endregion PUT



        #region DELETE


        public async Task<ApiResponse<string>> DeletePriceListLineByIdentifier(string itemKey, string lineId)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeleteSalesItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeleteSalesItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        #endregion DELETE
    }
}
