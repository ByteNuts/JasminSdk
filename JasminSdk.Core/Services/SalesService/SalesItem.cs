﻿using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.SalesService
{
    public class SalesItem : ISalesItem
    {
        protected readonly string EndPoint;
        internal SalesItem(string endpoint) { EndPoint = endpoint; }

        #region GET


        public async Task<ApiResponse<List<SalesItemResource>>> GetSalesItems()
        {
            var url = $"{EndPoint}/extension";

            return await ApiCall<List<SalesItemResource>>.Get(url);
        }


        public async Task<ApiResponse<List<SalesItemResource>>> GetSalesItems(int page, int pageSize)
        {
            var url = $"{EndPoint}/extension?page={page}&pageSize={pageSize}";

            return await ApiCall<List<SalesItemResource>>.Get(url);
        }


        public async Task<ApiResponse<SalesItemResource>> GetSalesItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}/extension";

            return await ApiCall<SalesItemResource>.Get(url, true);
        }


        public async Task<ApiResponse<SalesItemResource>> GetSalesItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}/extension";

            return await ApiCall<SalesItemResource>.Get(url, true);
        }


        public async Task<ApiResponse<List<BaseSalesItemResource>>> GetSalesItemWithItem()
        {
            var url = $"{EndPoint}";

            return await ApiCall<List<BaseSalesItemResource>>.Get(url);
        }


        public async Task<ApiResponse<List<BaseSalesItemResource>>> GetSalesItemWithItem(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            return await ApiCall<List<BaseSalesItemResource>>.Get(url);
        }


        public async Task<ApiResponse<BaseSalesItemResource>> GetSalesItemWithItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            return await ApiCall<BaseSalesItemResource>.Get(url, true);
        }


        public async Task<ApiResponse<BaseSalesItemResource>> GetSalesItemWithItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            return await ApiCall<BaseSalesItemResource>.Get(url, true);
        }


        #endregion GET




        #region POST

        public async Task<ApiResponse<string>> PostSalesItem(ApiSalesItemResource salesItemResource)
        {
            var url = $"{EndPoint}/extension";

            var json = JsonConvert.SerializeObject(salesItemResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostSalesItemWithApiBaseSalesItem(ApiBaseSalesItemResource salesItemResource)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(salesItemResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostSalesItemPriceListLine(string itemKey, ApiBaseSalesItemPriceListLinesResource value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines";


            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }

        #endregion POST




        #region PUT

        public async Task<ApiResponse<string>> PutSetCurrencyPriceListLine(string itemKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}/currency";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIncomeAccountSalesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/incomeAccount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsActiveSalesItem(string itemKey, bool value)
        {
            var url = $"{EndPoint}/{itemKey}/isActive";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetItemTaxSchemaSalesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/itemTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetItemWithholdingTaxSchemaSalesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/itemWithholdingTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPriceAmountPriceListLine(string itemKey, string lineId, decimal value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}/priceAmount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPriceListPriceListLine(string itemKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}/priceList";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnitPriceListLine(string itemKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}/unit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetUnitSalesItem(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/unit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }



        #endregion PUT



        #region DELETE


        public async Task<ApiResponse<string>> DeletePriceListLineByIdentifier(string itemKey, string lineId)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines/{lineId}";

            return await ApiCall<string>.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeleteSalesItemByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            return await ApiCall<string>.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeleteSalesItemByKey(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            return await ApiCall<string>.Delete(url, true);
        }


        #endregion DELETE
    }
}
