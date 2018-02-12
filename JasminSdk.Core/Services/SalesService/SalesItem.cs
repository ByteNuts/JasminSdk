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

        public async Task<ApiResponse<BaseSalesItemResource>> GetSalesItem(string itemKey)
        {
            var url = $"{EndPoint}/{itemKey}";

            return await ApiCall<BaseSalesItemResource>.Get(url, true);
        }


        #endregion GET




        #region POST

        public async Task<ApiResponse<string>> PostSalesItem(ApiBaseSalesItemResource salesItem)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(salesItem, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }


        public async Task<ApiResponse<string>> PostSalesItemPriceListLine(string itemKey, ApiBaseSalesItemPriceListLinesResource priceListLine)
        {
            var url = $"{EndPoint}/{itemKey}/priceListLines";


            var json = JsonConvert.SerializeObject(priceListLine, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }

        #endregion POST




        #region PUT

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

        public async Task<ApiResponse<string>> PutSetItemTaxSchema(string itemKey, string value)
        {
            var url = $"{EndPoint}/{itemKey}/itemTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }

        #endregion PUT

    }
}
