using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.Supplier;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Purchases
{
    public interface ISupplier
    {

        #region GET

        Task<ApiResponse<List<SupplierPartyResource>>> GetSupplierParties();

        Task<ApiResponse<SupplierPartyResource>> GetSupplierParties(int page, int pageSize);

        Task<ApiResponse<SupplierPartyResource>> GetSupplierPartyByIdentifier(string id);

        Task<ApiResponse<SupplierPartyResource>> GetSupplierPartyByKey(string partyKey);

        Task<ApiResponse<List<BaseSupplierPartyResource>>> GetSupplierPartiesWithParty();

        Task<ApiResponse<List<BaseSupplierPartyResource>>> GetSupplierPartiesWithParty(int page, int pageSize);

        Task<ApiResponse<BaseSupplierPartyResource>> GetSupplierPartyWithPartyByIdentifier(string id);

        Task<ApiResponse<BaseSupplierPartyResource>> GetSupplierPartyWithPartyByKey(string partyKey);

        Task<ApiResponse<SupplierDataResource>> GetSupplierByCompanyTaxId(string companyTaxId);


        #endregion GET



        #region POST

        Task<ApiResponse<string>> PostSupplierParties(ApiSupplierPartyResource supplierPartyResource);

        Task<ApiResponse<string>> PostSupplierPartiesWithApiBaseCustomerParty(ApiBaseSupplierPartyResource supplierPartyResource);

        Task<ApiResponse<string>> PostSupplierItemPrice(string partyKey, ApiSupplierPartySupplierItemPricesResource value);


        #endregion POST



        #region PUT

        Task<ApiResponse<string>> PutSetAccountingPartySupplierParty(string partyKey, string value);

        Task<ApiResponse<string>> PutSetCurrencySupplierItemPrice(string partyKey, string lineId, string value);

        Task<ApiResponse<string>> PutSetDeliveryTermSupplierParty(string partyKey, string value);

        Task<ApiResponse<string>> PutSetExchangeRateDateSupplierParty(string partyKey, DateTime value);

        Task<ApiResponse<string>> PutSetIsActiveSupplierParty(string partyKey, bool value);

        Task<ApiResponse<string>> PutSetItemSupplierItemPrice(string partyKey, string lineId, string value);

        Task<ApiResponse<string>> PutSetLastPriceSupplierItemPrice(string partyKey, string lineId, string value);

        Task<ApiResponse<string>> PutSetLastSourceDocSupplierItemPrice(string partyKey, string lineId, string value);

        Task<ApiResponse<string>> PutSetLastSourceDocDateSupplierItemPrice(string partyKey, string lineId, DateTime value);

        Task<ApiResponse<string>> PutSetLockedSupplierParty(string partyKey, bool value);

        Task<ApiResponse<string>> PutSetPartyTaxSchemaSupplierParty(string partyKey, string value);

        Task<ApiResponse<string>> PutSetPartyWithholdingTaxSchemaSupplierParty(string partyKey, string value);

        Task<ApiResponse<string>> PutSetPaymentMethodSupplierParty(string partyKey, string value);

        Task<ApiResponse<string>> PutSetPaymentTermSupplierParty(string partyKey, string value);

        Task<ApiResponse<string>> PutSetPriceSupplierItemPrice(string partyKey, string lineId, decimal value);

        Task<ApiResponse<string>> PutSetSettlementDiscountPercentSupplierParty(string partyKey, decimal value);

        Task<ApiResponse<string>> PutSetSupplierGroupSupplierParty(string partyKey, string value);

        Task<ApiResponse<string>> PutSetUnitSupplierItemPrice(string partyKey, string lineId, string value);


        #endregion PUT



        #region DELETE


        Task<ApiResponse<string>> DeleteSupplierItemPriceByIdentifier(string partyKey, string lineId);

        Task<ApiResponse<string>> DeleteSupplierPartyByIdentifier(string id);

        Task<ApiResponse<string>> DeleteSupplierPartyByKey(string partyKey);


        #endregion DELETE



    }
}
