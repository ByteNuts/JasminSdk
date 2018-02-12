using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.CreateReceipt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.AccountsReceivableService
{
    public class CreateReceipt : ICreateReceipt
    {
        protected readonly string EndPoint;
        internal CreateReceipt(string endpoint) { EndPoint = endpoint; }


        #region GET

        public async Task<ApiResponse<List<OpenAccountPostingLine>>> GetCreateReceipt(int pageIndex, int pageSize, string company, string party, DateTime documentDate, decimal documentExchangeRate, string currency, string documentType, DateTime? dueDateFrom = null, DateTime? dueDateUntil = null, string paymentMethod = null, decimal? total = null, string sourceDoc = null)
        {
            var url = $"{EndPoint}/{pageIndex}/{pageSize}?company={company}&party={party}&documentDate={documentDate:yyyy-MM-dd}&documentExchangeRate={documentExchangeRate}&currency={currency}&documentType={documentType}";
            if (dueDateFrom.HasValue) url = $"{url}&{dueDateFrom:yyyy-MM-dd}";
            if (dueDateUntil.HasValue) url = $"{url}&{dueDateUntil:yyyy-MM-dd}";
            if (!string.IsNullOrEmpty(paymentMethod)) url = $"{url}&{paymentMethod}";
            if (total.HasValue) url = $"{url}&{total}";
            if (!string.IsNullOrEmpty(sourceDoc)) url = $"{url}&{sourceDoc}";

            return await ApiCall<List<OpenAccountPostingLine>>.Get(url);
        }


        #endregion GET


        #region POST

        public async Task<ApiResponse<string>> PostCreateReceipt(List<OpenAccountPostingLine> list, string companyKey)
        {
            var url = $"{EndPoint}/{companyKey}";

            var json = JsonConvert.SerializeObject(list, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }

        #endregion POST

    }
}
