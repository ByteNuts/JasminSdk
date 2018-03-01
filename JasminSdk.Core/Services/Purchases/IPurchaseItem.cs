using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Purchases.PurchaseItem;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Purchases
{
    public interface IPurchaseItem
    {

        #region GET

        Task<ApiResponse<List<PurchasesItemResource>>> GetPurchasesItems();

        Task<ApiResponse<List<PurchasesItemResource>>> GetPurchasesItems(int page, int pageSize);

        Task<ApiResponse<PurchasesItemResource>> GetPurchasesItemByIdentifier(string id);

        Task<ApiResponse<PurchasesItemResource>> GetPurchasesItemByKey(string itemKey);

        Task<ApiResponse<List<BasePurchasesItemResource>>> GetPurchasesItemWithItem();

        Task<ApiResponse<List<BasePurchasesItemResource>>> GetPurchasesItemWithItem(int page, int pageSize);

        Task<ApiResponse<BasePurchasesItemResource>> GetPurchasesItemWithItemByIdentifier(string id);

        Task<ApiResponse<BasePurchasesItemResource>> GetPurchasesItemWithItemByKey(string itemKey);


        #endregion GET


        #region POST

        Task<ApiResponse<string>> PostPurchasesItem(ApiPurchasesItemResource purchasesItemResource);

        Task<ApiResponse<string>> PostPurchasesItemWithApiBaseSalesItem(ApiBasePurchasesItemResource purchasesItemResource);


        #endregion POST


        #region PUT

        Task<ApiResponse<string>> PutSetCurrencyPurchasesItem(string itemKey, string value);

        Task<ApiResponse<string>> PutSetExpenseAccountPurchasesItem(string itemKey, string value);

        Task<ApiResponse<string>> PutSetIsActivePurchasesItem(string itemKey, bool value);

        Task<ApiResponse<string>> PutSetItemTaxSchemaPurchasesItem(string itemKey, string value);

        Task<ApiResponse<string>> PutSetItemWithholdingTaxSchemaPurchasesItem(string itemKey, string value);

        Task<ApiResponse<string>> PutSetLastPricePurchasesItem(string itemKey, decimal value);

        Task<ApiResponse<string>> PutSetLastSourceDocPurchasesItem(string itemKey, string value);

        Task<ApiResponse<string>> PutSetLastSourceDocDatePurchasesItem(string itemKey, DateTime value);

        Task<ApiResponse<string>> PutSetLastSupplierPartyPurchasesItem(string itemKey, string value);

        Task<ApiResponse<string>> PutSetLastUnitPurchasesItem(string itemKey, string value);

        Task<ApiResponse<string>> PutSetUnitPurchasesItem(string itemKey, string value);

        #endregion PUT



        #region DELETE

        Task<ApiResponse<string>> DeletePurchasesItemByIdentifier(string id);

        Task<ApiResponse<string>> DeletePurchasesItemByKey(string itemKey);

        #endregion DELETE

    }
}
