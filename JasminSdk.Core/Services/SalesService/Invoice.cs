using System.Collections.Generic;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.Invoice;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.SalesService
{
    public class Invoice : IInvoice
    {
        protected readonly string EndPoint;
        internal Invoice(string endpoint) { EndPoint = endpoint; }

        #region GET

        public async Task<ApiResponse<List<InvoiceResource>>> GetInvoices()
        {
            var url = $"{EndPoint}";

            return await ApiCall<List<InvoiceResource>>.Get(url);
        }


        public async Task<ApiResponse<List<InvoiceResource>>> GetInvoices(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            return await ApiCall<List<InvoiceResource>>.Get(url);
        }


        public async Task<ApiResponse<InvoiceResource>> GetInvoiceByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            return await ApiCall<InvoiceResource>.Get(url, true);
        }


        public async Task<ApiResponse<InvoiceResource>> GetInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}";

            return await ApiCall<InvoiceResource>.Get(url, true);
        }


        public async Task<ApiResponse<byte[]>> GetPrintInvoiceByIdentifier(string id, string template = null)
        {
            var url = $"{EndPoint}/{id}/print";
            if (!string.IsNullOrEmpty(template)) url = $"{url}?template={template}";

            return await ApiCall<byte[]>.Get(url, true);
        }


        public async Task<ApiResponse<byte[]>> GetPrintInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber, string template = null)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/print";
            if (!string.IsNullOrEmpty(template)) url = $"{url}?template={template}";

            return await ApiCall<byte[]>.Get(url, true);
        }


        #endregion GET




        #region POST

        public async Task<ApiResponse<string>> PostInvoice(ApiInvoiceResource invoiceResource)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(invoiceResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Post(url, content);
        }

        #endregion POST




        #region PUT

        public async Task<ApiResponse<string>> PutSetAccountingSchemaInvoice(string companyKey, string documentType, string serie, int seriesNumber, AccountingSchema value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/accountingSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetEmailToInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/emailTo";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetFiscalDocumentTypeInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/fiscalDocumentType";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsActiveInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isActive";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content, true);
        }


        public async Task<ApiResponse<string>> PutSetIsExternalInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isExternal";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsManualInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isManual";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsManualSerieInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isManualSerie";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsOneTimeCustomerInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isOneTimeCustomer";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsSimpleInvoiceInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isSimpleInvoice";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetIsWsCommunicableInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isWsCommunicable";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetNoteInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/note";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetNoteToRecipientInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/noteToRecipient";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetNotificationInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/notification";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetPartyAccountingSchemaInvoice(string companyKey, string documentType, string serie, int seriesNumber, AccountingSchema value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/partyAccountingSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetRemarksInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/remarks";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetSalesChannelInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/salesChannel";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetTransactionAccountInvoiceLine(string companyKey, string documentType, string serie, int seriesNumber, string lineId, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/transactionAccount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            return await ApiCall<string>.Put(url, content);
        }



        #endregion PUT



        #region DELETE


        public async Task<ApiResponse<string>> DeleteInvoiceByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            return await ApiCall<string>.Delete(url, true);
        }


        public async Task<ApiResponse<string>> DeleteInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}";

            return await ApiCall<string>.Delete(url, true);
        }


        #endregion DELETE
    }
}
