﻿using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.CustomerParty;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.SalesService
{
    public class CustomerParty : ICustomerParty
    {
        protected readonly string EndPoint;
        internal CustomerParty(string endpoint) { EndPoint = endpoint; }


        #region GET


        public async Task<ApiResponse<List<CustomerPartyResource>>> GetCustomerParties()
        {
            var url = $"{EndPoint}/extension";

            return await ApiCall<List<CustomerPartyResource>>.Get(url);
        }


        public async Task<ApiResponse<CustomerPartyResource>> GetCustomerParties(int page, int pageSize)
        {
            var url = $"{EndPoint}/extension?page={page}&pageSize={pageSize}";

            return await ApiCall<CustomerPartyResource>.Get(url);
        }


        public async Task<ApiResponse<CustomerPartyResource>> GetCustomerPartyByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}/extension";

            return await ApiCall<CustomerPartyResource>.Get(url, true);
        }


        public async Task<ApiResponse<CustomerPartyResource>> GetCustomerPartyByKey(string partyKey)
        {
            var url = $"{EndPoint}/{partyKey}/extension";

            return await ApiCall<CustomerPartyResource>.Get(url, true);
        }


        public async Task<ApiResponse<List<BaseCustomerPartyResource>>> GetCustomerPartiesWithParty()
        {
            var url = $"{EndPoint}";

            return await ApiCall<List<BaseCustomerPartyResource>>.Get(url);
        }


        public async Task<ApiResponse<List<BaseCustomerPartyResource>>> GetCustomerPartiesWithParty(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            return await ApiCall<List<BaseCustomerPartyResource>>.Get(url);
        }


        public async Task<ApiResponse<BaseCustomerPartyResource>> GetCustomerPartyWithPartyByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            return await ApiCall<BaseCustomerPartyResource>.Get(url, true);
        }


        public async Task<ApiResponse<BaseCustomerPartyResource>> GetCustomerPartyWithPartyByKey(string partyKey)
        {
            var url = $"{EndPoint}/{partyKey}";

            return await ApiCall<BaseCustomerPartyResource>.Get(url, true);
        }


        public async Task<ApiResponse<CustomerDataResource>> GetCustomerByCompanyTaxId(string companyTaxId)
        {
            var url = $"{EndPoint}/getCustomerByCompanyTaxId/{companyTaxId}?companyTaxId={companyTaxId}";

            return await ApiCall<CustomerDataResource>.Get(url, true);
        }


        #endregion GET



        #region POST


        public async Task<ApiResponse<string>> PostCustomerParties(ApiBaseCustomerPartyResource customerPartyResource)
        {
            var url = $"{EndPoint}/extension";

            var json = JsonConvert.SerializeObject(customerPartyResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostCustomerPartiesWithApiBaseCustomerParty(ApiBaseCustomerPartyResource customerPartyResource)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(customerPartyResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }


        #endregion POST



        #region PUT


        public async Task<ApiResponse<string>> PutSetAccountingPartyCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/accountingParty";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetAccountingSchemaCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/accountingSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetCustomerGroupCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/customerGroup";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetDeliveryTermCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/deliveryTerm";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetEndCustomerCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/endCustomer";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsActiveCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/isActive";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetLockedCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/locked";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetOneTimeCustomerCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/oneTimeCustomer";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPartyTaxSchemaCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/partyTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPartyWithholdingTaxSchemaCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/partyWithholdingTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPaymentMethodCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/paymentMethod";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPaymentTermCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/paymentTerm";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPriceListCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/priceList";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetSalespersonCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/salesperson";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetSettlementDiscountPercentCustomerParty(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/settlementDiscountPercent";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        #endregion PUT



        #region DELETE


        public async Task<ApiResponse<string>> DeleteCustomerPartyByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            return await ApiCall<string>.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeleteCustomerPartyByKey(string partyKey)
        {
            var url = $"{EndPoint}/{partyKey}";

            return await ApiCall<string>.Delete(url, true);
        }


        #endregion DELETE

    }
}
