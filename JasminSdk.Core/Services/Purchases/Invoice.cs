using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Invoice;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Purchases
{
    public class Invoice : IInvoice
    {
        protected readonly string EndPoint;
        protected readonly ILogger Logger;

        internal Invoice(string endpoint, ILogger logger)
        {
            EndPoint = endpoint;
            Logger = logger;
        }


        #region GET

        public async Task<ApiResponse<List<InvoiceResource>>> GetInvoices()
        {
            var url = $"{EndPoint}";

            var apiCall = new ApiCall<List<InvoiceResource>>(Logger);
            return await apiCall.Get(url);
        }

        public async Task<ApiResponse<List<InvoiceResource>>> GetInvoices(int page, int pageSize)
        {
            var url = $"{EndPoint}?page={page}&pageSize={pageSize}";

            var apiCall = new ApiCall<List<InvoiceResource>>(Logger);
            return await apiCall.Get(url);
        }

        public async Task<ApiResponse<InvoiceResource>> GetInvoiceByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<InvoiceResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<InvoiceResource>> GetInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}";

            var apiCall = new ApiCall<InvoiceResource>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<byte[]>> GetPrintInvoiceByIdentifier(string id, string template = null)
        {
            var url = $"{EndPoint}/{id}/print";
            if (!string.IsNullOrEmpty(template)) url = $"{url}?template={template}";

            var apiCall = new ApiCall<byte[]>(Logger);
            return await apiCall.Get(url, true);
        }


        public async Task<ApiResponse<byte[]>> GetPrintInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber, string template = null)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/print";
            if (!string.IsNullOrEmpty(template)) url = $"{url}?template={template}";

            var apiCall = new ApiCall<byte[]>(Logger);
            return await apiCall.Get(url, true);
        }


        #endregion GET



        #region POST

        public async Task<ApiResponse<string>> PostInvoice(ApiInvoiceResource invoiceResource)
        {
            var url = $"{EndPoint}";

            var json = JsonConvert.SerializeObject(invoiceResource, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }

        public async Task<ApiResponse<string>> PostInvoiceLine(string documentType, string serie, int seriesNumber, string companyKey, ApiInvoiceDocumentLinesResource value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }

        public async Task<ApiResponse<string>> PostInvoiceTax(string documentType, string serie, int seriesNumber, string companyKey, ApiInvoiceDocumentTaxesResource value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentTaxes";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }

        public async Task<ApiResponse<string>> PostInvoiceWTax(string documentType, string serie, int seriesNumber, string companyKey, ApiInvoiceDocumentWTaxesResource value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentWTaxes";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Post(url, content);
        }


        #endregion POST


        #region PUT

        public async Task<ApiResponse<string>> PutSetAccountingAltAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/accountingAltAddress";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetAccountingPartyInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/accountingParty";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetAccountingPartyAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/accountingPartyAddress";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetAccountingPartyNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/accountingPartyName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetAccountingPartyTaxIdInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/accountingPartyTaxId";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetAccountingSchemaInvoice(string documentType, string serie, int seriesNumber, string companyKey, AccountingSchema value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/accountingSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetAltAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/altAddress";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetBaseUnitInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/baseUnit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetCheckInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/check";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetCompanyInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/company";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetComplementaryDescriptionInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/complementaryDescription";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetCurrencyInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/currency";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetDeliveryDateInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/deliveryDate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetDeliveryTermInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/deliveryTerm";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDescriptionInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/description";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDiscountInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/discount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDiscount1InvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/discount1";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDiscount2InvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/discount2";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDiscount3InvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/discount3";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDocumentDateInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTime value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentDate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDocumentLineStatusInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, DocumentLineStatus value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/documentLineStatus";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetDueDateInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTime value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/dueDate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetEmailToInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/emailTo";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetExchangeRateInvoice(string documentType, string serie, int seriesNumber, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/exchangeRate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetExchangeRateDateInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTime value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/exchangeRateDate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetIsActiveInvoice(string documentType, string serie, int seriesNumber, string companyKey, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isActive";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetIsPaymentMethodCheckInvoice(string documentType, string serie, int seriesNumber, string companyKey, bool value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/isPaymentMethodCheck";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetItemTaxSchemaInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/itemTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetItemWithholdingTaxSchemaInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/itemWithholdingTaxSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLoadingBuildingNumberInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/loadingBuildingNumber";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLoadingCityNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/loadingCityName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetLoadingCountryInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/loadingCountry";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetLoadingDateTimeInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTimeOffset value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/loadingDateTime";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLoadingPointInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/loadingPoint";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLoadingPointAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/loadingPointAddress";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetLoadingPostalZoneInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/loadingPostalZone";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        public async Task<ApiResponse<string>> PutSetLoadingStreetNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/loadingStreetName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetNoteInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/note";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetNoteToRecipientInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/noteToRecipient";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetNotificationInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/notification";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPartyAccountingSchemaInvoice(string documentType, string serie, int seriesNumber, string companyKey, AccountingSchema value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/partyAccountingSchema";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPaymentAccountPostingIdInvoice(string documentType, string serie, int seriesNumber, string companyKey, Guid value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/paymentAccountPostingId";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPaymentMethodInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/paymentMethod";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPaymentTermInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/paymentTerm";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetPostingDateInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTime value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/postingDate";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetQuantityInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/quantity";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetRemarksInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/remarks";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetRoundingTaxableAmountInvoiceTax(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentTaxes/{lineId}/roundingTaxableAmount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetRoundingTaxAmountInvoiceTax(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentTaxes/{lineId}/roundingTaxAmount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetSellerSupplierPartyAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/sellerSupplierPartyAddress";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetSellerSupplierPartyNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/sellerSupplierPartyName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetSellerSupplierPartyTaxIdInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/sellerSupplierPartyTaxId";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetTransactionAccountInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/transactionAccount";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnitInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/unit";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnitCostInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/unitCost";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnitPriceInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/unitPrice";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnloadingBuildingNumberInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/unloadingBuildingNumber";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnloadingCityNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/unloadingCityName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnloadingCountryInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/unloadingCountry";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnloadingDateTimeInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTimeOffset value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/unloadingDateTime";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnloadingPointInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/unloadingPoint";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnloadingPointAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/unloadingPointAddress";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnloadingPostalZoneInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/unloadingPostalZone";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetUnloadingStreetNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/unloadingStreetName";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetVehiclePlateNumberInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/vehiclePlateNumber";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }

        public async Task<ApiResponse<string>> PutSetWarehouseInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}/warehouse";

            var json = JsonConvert.SerializeObject(value, RequestHelper.JsonSettings);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Put(url, content);
        }


        #endregion PUT



        #region DELETE

        public async Task<ApiResponse<string>> DeleteInvoiceLineByIdentifier(string documentType, string serie, int seriesNumber, string companyKey, string lineId)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentLines/{lineId}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }

        public async Task<ApiResponse<string>> DeleteInvoiceTaxByIdentifier(string documentType, string serie, int seriesNumber, string companyKey, string lineId)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentTaxes/{lineId}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }

        public async Task<ApiResponse<string>> DeleteInvoiceWTaxByIdentifier(string documentType, string serie, int seriesNumber, string companyKey, string lineId)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}/documentWTaxes/{lineId}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }

        public async Task<ApiResponse<string>> DeleteInvoiceByIdentifier(string id)
        {
            var url = $"{EndPoint}/{id}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }

        public async Task<ApiResponse<string>> DeleteInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber)
        {
            var url = $"{EndPoint}/{companyKey}/{documentType}/{serie}/{seriesNumber}";

            var apiCall = new ApiCall<string>(Logger);
            return await apiCall.Delete(url, true);
        }

        #endregion DELETE
    }
}
