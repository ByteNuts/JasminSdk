using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Entity;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService
{
    public class Entity
    {
        protected readonly string EndPoint;
        protected readonly ILogger Logger;

        internal Entity(string endpoint, ILogger logger)
        {
            EndPoint = endpoint;
            Logger = logger;
        }

        #region GET

        public async Task<ApiResponse<List<PartyResource>>> GetParties()
        {
            var url = $"{EndPoint}";

            var apiCall = new ApiCall<List<PartyResource>>(Logger);
            return await apiCall.Get(url);
        }

        public async Task<ApiResponse<List<PartyResource>>> GetParties(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<List<PartyResource>>(Logger);
            return await apiCall.Get(url);
        }

        public async Task<ApiResponse<PartyResource>> GetPartyByKey(string partyKey)
        {
            var url = $"{EndPoint}/{partyKey}";

            var apiCall = new ApiCall<PartyResource>(Logger);
            return await apiCall.Get(url);
        }


        public async Task<ApiResponse<PartyDataResource>> GetPartyByCompanyTaxId(string companyTaxId)
        {
            var url = $"{EndPoint}/getPartyByCompanyTaxId?companyTaxId={companyTaxId}";

            var apiCall = new ApiCall<PartyDataResource>(Logger);
            return await apiCall.Get(url);
        }

        #endregion GET




        #region POST

        public async Task<ApiResponse<string>> PostParties(ApiPartyResource party)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(party, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }

        public async Task<ApiResponse<string>> PostPartyAddress(string partyKey, ApiPartyPartyAddressesResource value)
        {
            var url = $"{EndPoint}/{partyKey}/partyAddresses";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }

        public async Task<ApiResponse<string>> PostPartyContact(string partyKey, ApiPartyPartyContactsResource value)
        {
            var url = $"{EndPoint}/{partyKey}/partyContacts";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        #endregion POST




        #region PUT

        public async Task<ApiResponse<string>> PutSetPartyAddress(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/address";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPartyBuildingNumber(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/buildingNumber";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyAddressBuildingNumber(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/partyAddresses/{lineId}/buildingNumber";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyCityName(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/cityName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyAddressCityName(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/partyAddresses/{lineId}/cityName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyCompanyTaxId(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/companyTaxID";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyContact(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/contact";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyContactName(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/contactName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyAddressContactName(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/partyAddresses/{lineId}/contactName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyContactContactName(string partyKey, string lineId, string value)
        {
            var url = $"{EndPoint}/{partyKey}/partyContacts/{lineId}/contactName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyContactTitle(string partyKey, string value)
        {
            var url = $"{EndPoint}/{partyKey}/contactTitle";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        #endregion PUT
    }
}
