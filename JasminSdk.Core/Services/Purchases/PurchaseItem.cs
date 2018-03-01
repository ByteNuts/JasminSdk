using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.PurchaseItem;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Purchases
{
    public class PurchaseItem : IPurchaseItem
    {
        protected readonly string EndPoint;
        protected readonly ILogger Logger;
        internal PurchaseItem(string endpoint, ILogger logger)
        {
            EndPoint = endpoint;
            Logger = logger;
        }


        #region GET

        public async Task<ApiResponse<List<PurchasesItemResource>>> GetPurchasesItems()
        {
            var url = $"{EndPoint}/extension";

            var apiCall = new ApiCall<List<PurchasesItemResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<List<PurchasesItemResource>>> GetPurchasesItems(int page, int pageSize)
        {
            var url = $"{EndPoint}/extension?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<List<PurchasesItemResource>>(Logger);
            return await apiCall.Get(url);
        }

        public async Task<ApiResponse<PurchasesItemResource>> GetPurchasesItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}/extension";

            var apiCall = new ApiCall<PurchasesItemResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<PurchasesItemResource>> GetPurchasesItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}/extension";

            var apiCall = new ApiCall<PurchasesItemResource>(Logger);
            return await apiCall.Get(url, true);
        }

        public async Task<ApiResponse<List<BasePurchasesItemResource>>> GetPurchasesItemWithItem()
        {
            var url = $"{EndPoint}";

            var apiCall = new ApiCall<List<BasePurchasesItemResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<List<BasePurchasesItemResource>>> GetPurchasesItemWithItem(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<List<BasePurchasesItemResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<BasePurchasesItemResource>> GetPurchasesItemWithItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<BasePurchasesItemResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<BasePurchasesItemResource>> GetPurchasesItemWithItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            var apiCall = new ApiCall<BasePurchasesItemResource>(Logger);
            return await apiCall.Get(url, true);
        }


        #endregion GET


        #region POST

        public async Task<ApiResponse<string>> PostPurchasesItem(ApiPurchasesItemResource purchasesItemResource)
        {
            var url = $"{EndPoint}/extension";

            var json = JsonConvert.SerializeObject(purchasesItemResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostPurchasesItemWithApiBaseSalesItem(ApiBasePurchasesItemResource purchasesItemResource)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(purchasesItemResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }



        #endregion POST



        #region PUT

        public async Task<ApiResponse<string>> PutSetCurrencyPurchasesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/currency";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetExpenseAccountPurchasesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/expenseAccount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetIsActivePurchasesItem(string itemKey, bool value)
        {
            var url = $"{EndPoint}/{itemKey}/isActive";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }

        public async Task<ApiResponse<string>> PutSetItemTaxSchemaPurchasesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/itemTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetItemWithholdingTaxSchemaPurchasesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/itemWithholdingTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLastPricePurchasesItem(string itemKey, decimal value)
        {
            var url = $"{EndPoint}/{itemKey}/lastPrice";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetLastSourceDocPurchasesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/lastSourceDoc";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLastSourceDocDatePurchasesItem(string itemKey, DateTime value)
        {
            var url = $"{EndPoint}/{itemKey}/lastSourceDocDate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLastSupplierPartyPurchasesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/lastSupplierParty";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLastUnitPurchasesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/lastUnit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnitPurchasesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/unit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        #endregion PUT



        #region DELETE

        public async Task<ApiResponse<string>> DeletePurchasesItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeletePurchasesItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        #endregion DELETE

    }
}
