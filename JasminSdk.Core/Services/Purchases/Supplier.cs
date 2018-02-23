using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Supplier;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Purchases
{
    public class Supplier : ISupplier
    {
        protected readonly string EndPoint;
        protected readonly ILogger Logger;

        internal Supplier(string endpoint, ILogger logger)
        {
            EndPoint = endpoint;
            Logger = logger;
        }


        #region GET

        public async Task<ApiResponse<List<SupplierPartyResource>>> GetSupplierParties()
        {
            var url = $"{EndPoint}/extension";

            var apiCall = new ApiCall<List<SupplierPartyResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<SupplierPartyResource>> GetSupplierParties(int page, int pageSize)
        {
            var url = $"{EndPoint}/extension?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<SupplierPartyResource>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<SupplierPartyResource>> GetSupplierPartyByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}/extension";

            var apiCall = new ApiCall<SupplierPartyResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<SupplierPartyResource>> GetSupplierPartyByKey(string partyKey)
        {
            var url = $"{EndPoint}/{partyKey}/extension";

            var apiCall = new ApiCall<SupplierPartyResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<List<BaseSupplierPartyResource>>> GetSupplierPartiesWithParty()
        {
            var url = $"{EndPoint}";

            var apiCall = new ApiCall<List<BaseSupplierPartyResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<List<BaseSupplierPartyResource>>> GetSupplierPartiesWithParty(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<List<BaseSupplierPartyResource>>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<BaseSupplierPartyResource>> GetSupplierPartyWithPartyByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<BaseSupplierPartyResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<BaseSupplierPartyResource>> GetSupplierPartyWithPartyByKey(string partyKey)
        {
            var url = $"{EndPoint}/{partyKey}";

            var apiCall = new ApiCall<BaseSupplierPartyResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<SupplierDataResource>> GetSupplierByCompanyTaxId(string companyTaxId)
        {
            var url = $"{EndPoint}/getSupplierByCompanyTaxId/{companyTaxId}?companyTaxId={companyTaxId}";

            var apiCall = new ApiCall<SupplierDataResource>(Logger);
            return await apiCall.Get(url, true);
        }


        #endregion GET



        #region POST

        public async Task<ApiResponse<string>> PostSupplierParties(ApiSupplierPartyResource supplierPartyResource)
        {
            var url = $"{EndPoint}/extension";

            var json = JsonConvert.SerializeObject(supplierPartyResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostSupplierPartiesWithApiBaseCustomerParty(ApiBaseSupplierPartyResource supplierPartyResource)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(supplierPartyResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostSupplierItemPrice(string partyKey, ApiSupplierPartySupplierItemPricesResource value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        #endregion POST




        #region PUT

        public async Task<ApiResponse<string>> PutSetAccountingPartySupplierParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/accountingParty";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetCurrencySupplierItemPrice(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices/{lineId}/currency";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDeliveryTermSupplierParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/deliveryTerm";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetExchangeRateDateSupplierParty(string partyKey, DateTime value)
        {
            var url = $"{EndPoint}/{partyKey}/exchangeRateDate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsActiveSupplierParty(string partyKey, bool value)
        {
            var url = $"{EndPoint}/{partyKey}/isActive";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }

        public async Task<ApiResponse<string>> PutSetItemSupplierItemPrice(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices/{lineId}/item";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetLastPriceSupplierItemPrice(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices/{lineId}/lastPrice";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetLastSourceDocSupplierItemPrice(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices/{lineId}/lastSourceDoc";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetLastSourceDocDateSupplierItemPrice(string partyKey, string lineId, DateTime value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices/{lineId}/lastSourceDocDate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetLockedSupplierParty(string partyKey, bool value)
        {
            var url = $"{EndPoint}/{partyKey}/locked";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetPartyTaxSchemaSupplierParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/partyTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetPartyWithholdingTaxSchemaSupplierParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/partyWithholdingTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetPaymentMethodSupplierParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/paymentMethod";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetPaymentTermSupplierParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/paymentTerm";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetPriceSupplierItemPrice(string partyKey, string lineId, decimal value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices/{lineId}/price";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetSettlementDiscountPercentSupplierParty(string partyKey, decimal value)
        {
            var url = $"{EndPoint}/{partyKey}/settlementDiscountPercent";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetSupplierGroupSupplierParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierGroup";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content, true);
        }

        public async Task<ApiResponse<string>> PutSetUnitSupplierItemPrice(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices/{lineId}/unit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        #endregion PUT




        #region DELETE

        public async Task<ApiResponse<string>> DeleteSupplierItemPriceByIdentifier(string partyKey, string lineId)
        {
            var url = $"{EndPoint}/{partyKey}/supplierItemPrices/{lineId}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }

        public async Task<ApiResponse<string>> DeleteSupplierPartyByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeleteSupplierPartyByKey(string partyKey)
        {
            var url = $"{EndPoint}/{partyKey}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }


        #endregion DELETE





    }
}
