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

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService
{
    public class Entity
    {
        #region GET

        public async Task<ApiResponse<List<PartyResource>>> GetParties()
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey);

            return await ApiCall<List<PartyResource>>.Get(endpoint);
        }

        public async Task<ApiResponse<List<PartyResource>>> GetParties(int page, int pageSize)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties?page={3}&pageSize={4}", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, page, pageSize);

            return await ApiCall<List<PartyResource>>.Get(endpoint);
        }

        public async Task<ApiResponse<PartyResource>> GetPartyByKey(string partyKey)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            return await ApiCall<PartyResource>.Get(endpoint);
        }


        public async Task<ApiResponse<PartyDataResource>> GetPartyByCompanyTaxId(string companyTaxId)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/getPartyByCompanyTaxId?companyTaxId={3}", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, companyTaxId);

            return await ApiCall<PartyDataResource>.Get(endpoint);
        }

        #endregion GET




        #region POST

        public async Task<ApiResponse<string>> PostParties(ApiPartyResource party)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(party, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PostPartyAddress(string partyKey, ApiPartyPartyAddressesResource value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/partyAddresses", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Post(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PostPartyContact(string partyKey, ApiPartyPartyContactsResource value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/partyContacts", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Post(endpoint, content);
        }


        #endregion POST




        #region PUT

        public async Task<ApiResponse<bool>> PutSetPartyAddress(string partyKey, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/address", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }


        public async Task<ApiResponse<bool>> PutSetPartyBuildingNumber(string partyKey, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/buildingNumber", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyAddressBuildingNumber(string partyKey, string lineId, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/partyAddresses/{4}/buildingNumber", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey, lineId);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyCityName(string partyKey, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/cityName", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyAddressCityName(string partyKey, string lineId, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/partyAddresses/{4}/cityName", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey, lineId);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyCompanyTaxId(string partyKey, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/companyTaxID", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyContact(string partyKey, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/contact", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyContactName(string partyKey, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/contactName", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyAddressContactName(string partyKey, string lineId, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/partyAddresses/{4}/contactName", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey, lineId);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyContactContactName(string partyKey, string lineId, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/partyContacts/{4}/contactName", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey, lineId);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        public async Task<ApiResponse<bool>> PutSetPartyContactTitle(string partyKey, string value)
        {
            var endpoint = string.Format(CultureInfo.CurrentCulture, "{0}/api/{1}/{2}/businessCore/parties/{3}/contactTitle", Constants.JasminBaseAppUrl, Constants.Config.AccountKey, Constants.Config.SubscriptionKey, partyKey);

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(value, settings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<bool>.Put(endpoint, content);
        }

        #endregion PUT
    }
}
