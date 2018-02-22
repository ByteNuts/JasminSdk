using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Invoice;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Purchases
{
    public interface IInvoice
    {

        #region GET

        Task<ApiResponse<List<InvoiceResource>>> GetInvoices();

        Task<ApiResponse<List<InvoiceResource>>> GetInvoices(int page, int pageSize);

        Task<ApiResponse<InvoiceResource>> GetInvoiceByIdentifier(string id);

        Task<ApiResponse<InvoiceResource>> GetInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber);

        Task<ApiResponse<byte[]>> GetPrintInvoiceByIdentifier(string id, string template = null);

        Task<ApiResponse<byte[]>> GetPrintInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber, string template = null);


        #endregion GET



        #region POST

        Task<ApiResponse<string>> PostInvoice(ApiInvoiceResource invoiceResource);

        Task<ApiResponse<string>> PostInvoiceLine(string documentType, string serie, int seriesNumber, string companyKey, ApiInvoiceDocumentLinesResource value);

        Task<ApiResponse<string>> PostInvoiceTax(string documentType, string serie, int seriesNumber, string companyKey, ApiInvoiceDocumentTaxesResource value);

        Task<ApiResponse<string>> PostInvoiceWTax(string documentType, string serie, int seriesNumber, string companyKey, ApiInvoiceDocumentWTaxesResource value);


        #endregion POST



        #region PUT

        Task<ApiResponse<string>> PutSetAccountingAltAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetAccountingPartyInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetAccountingPartyAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetAccountingPartyNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetAccountingPartyTaxIdInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetAccountingSchemaInvoice(string documentType, string serie, int seriesNumber, string companyKey, AccountingSchema value);

        Task<ApiResponse<string>> PutSetAltAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetBaseUnitInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);

        Task<ApiResponse<string>> PutSetCheckInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetCompanyInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetComplementaryDescriptionInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);

        Task<ApiResponse<string>> PutSetCurrencyInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetDeliveryDateInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);

        Task<ApiResponse<string>> PutSetDeliveryTermInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetDescriptionInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);

        Task<ApiResponse<string>> PutSetDiscountInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetDiscount1InvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetDiscount2InvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetDiscount3InvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetDocumentDateInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTime value);

        Task<ApiResponse<string>> PutSetDocumentLineStatusInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, DocumentLineStatus value);

        Task<ApiResponse<string>> PutSetDueDateInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTime value);

        Task<ApiResponse<string>> PutSetEmailToInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetExchangeRateInvoice(string documentType, string serie, int seriesNumber, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetExchangeRateDateInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTime value);

        Task<ApiResponse<string>> PutSetIsActiveInvoice(string documentType, string serie, int seriesNumber, string companyKey, bool value);

        Task<ApiResponse<string>> PutSetIsPaymentMethodCheckInvoice(string documentType, string serie, int seriesNumber, string companyKey, bool value);

        Task<ApiResponse<string>> PutSetItemTaxSchemaInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);

        Task<ApiResponse<string>> PutSetItemWithholdingTaxSchemaInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);

        Task<ApiResponse<string>> PutSetLoadingBuildingNumberInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetLoadingCityNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetLoadingCountryInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetLoadingDateTimeInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTimeOffset value);

        Task<ApiResponse<string>> PutSetLoadingPointInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetLoadingPointAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetLoadingPostalZoneInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetLoadingStreetNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetNoteInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetNoteToRecipientInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetNotificationInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetPartyAccountingSchemaInvoice(string documentType, string serie, int seriesNumber, string companyKey, AccountingSchema value);

        Task<ApiResponse<string>> PutSetPaymentAccountPostingIdInvoice(string documentType, string serie, int seriesNumber, string companyKey, Guid value);

        Task<ApiResponse<string>> PutSetPaymentMethodInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetPaymentTermInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetPostingDateInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTime value);

        Task<ApiResponse<string>> PutSetQuantityInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetRemarksInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetRoundingTaxableAmountInvoiceTax(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetRoundingTaxAmountInvoiceTax(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetSellerSupplierPartyAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetSellerSupplierPartyNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetSellerSupplierPartyTaxIdInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetTransactionAccountInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);

        Task<ApiResponse<string>> PutSetUnitInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);

        Task<ApiResponse<string>> PutSetUnitCostInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetUnitPriceInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, decimal value);

        Task<ApiResponse<string>> PutSetUnloadingBuildingNumberInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetUnloadingCityNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetUnloadingCountryInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetUnloadingDateTimeInvoice(string documentType, string serie, int seriesNumber, string companyKey, DateTimeOffset value);

        Task<ApiResponse<string>> PutSetUnloadingPointInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetUnloadingPointAddressInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetUnloadingPostalZoneInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetUnloadingStreetNameInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetVehiclePlateNumberInvoice(string documentType, string serie, int seriesNumber, string companyKey, string value);

        Task<ApiResponse<string>> PutSetWarehouseInvoiceLine(string documentType, string serie, int seriesNumber, string lineId, string companyKey, string value);


        #endregion PUT



        #region DELETE

        Task<ApiResponse<string>> DeleteInvoiceLineByIdentifier(string documentType, string serie, int seriesNumber, string companyKey, string lineId);

        Task<ApiResponse<string>> DeleteInvoiceTaxByIdentifier(string documentType, string serie, int seriesNumber, string companyKey, string lineId);

        Task<ApiResponse<string>> DeleteInvoiceWTaxByIdentifier(string documentType, string serie, int seriesNumber, string companyKey, string lineId);

        Task<ApiResponse<string>> DeleteInvoiceByIdentifier(string id);

        Task<ApiResponse<string>> DeleteInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber);

        #endregion DELETE
    }
}
