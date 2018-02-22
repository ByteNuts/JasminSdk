using System.Collections.Generic;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Sales
{
    public interface ISalesItem
    {
        #region GET

        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the list of resources available. See SalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <returns>ApiResponse&lt;List&lt;SalesItemResource&gt;&gt;</returns>
        Task<ApiResponse<List<SalesItemResource>>> GetSalesItems();

        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the list of resources available. See SalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="page">The index of the page of the list that should be returned. This is a query string parameter.</param>
        /// <param name="pageSize">The number of page elements that should be returned (max. is 1000). This is a query string parameter.</param>
        /// <returns>ApiResponse&lt;List&lt;SalesItemResource&gt;&gt;</returns>
        Task<ApiResponse<List<SalesItemResource>>> GetSalesItems(int page, int pageSize);

        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See SalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns>ApiResponse&lt;SalesItemResource&gt;</returns>
        Task<ApiResponse<SalesItemResource>> GetSalesItemByIdentifier(string id);

        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See SalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <returns>&lt;ApiResponse&lt;SalesItemResource&gt;</returns>
        Task<ApiResponse<SalesItemResource>> GetSalesItemByKey(string itemKey);

        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the resources. See BaseSalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <returns>ApiResponse&lt;List&lt;BaseSalesItemResource&gt;&gt;</returns>
        Task<ApiResponse<List<BaseSalesItemResource>>> GetSalesItemWithItem();

        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the resources. See BaseSalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="page">The index of the page of the list that should be returned. This is a query string parameter.</param>
        /// <param name="pageSize">The number of page elements that should be returned (max. is 1000). This is a query string parameter.</param>
        /// <returns>ApiResponse&lt;List&lt;BaseSalesItemResource&gt;&gt;</returns>
        Task<ApiResponse<List<BaseSalesItemResource>>> GetSalesItemWithItem(int page, int pageSize);

        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See BaseSalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The identifier of the resource that should be returned.</param>
        /// <returns>ApiResponse&lt;BaseSalesItemResource&gt;</returns>
        Task<ApiResponse<BaseSalesItemResource>> GetSalesItemWithItemByIdentifier(string id);

        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See BaseSalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <returns>ApiResponse&lt;BaseSalesItemResource&gt;</returns>
        Task<ApiResponse<BaseSalesItemResource>> GetSalesItemWithItemByKey(string itemKey);

        #endregion GET



        #region POST

        /// <summary>
        /// Creates a new resource.<para/>
        /// Response: When successful, the response body contains the new resource identifier. The resource header location property contains the URL for the new resource. See ApiSalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 201	Created. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="salesItemResource">The request body should contain the resource that should be created. See ApiSalesItemResource.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PostSalesItem(ApiSalesItemResource salesItemResource);

        /// <summary>
        /// Creates a new resource.<para/>
        /// Response: When successful, the response body contains the new resource identifier. The resource header location property contains the URL for the new resource. See ApiBaseSalesItemResource.<para/>
        /// Response status codes:<para/>
        /// 201	Created. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="salesItemResource">The request body should contain the resource that should be created. See ApiSalesItemResource.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PostSalesItemWithApiBaseSalesItem(ApiBaseSalesItemResource salesItemResource);

        /// <summary>
        /// Inserts a new 'Price List Line' in the 'Sales Item'.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 204	NoContent. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The ApiSalesItemPriceListLinesResource instance. See ApiSalesItemPriceListLinesResource.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PostSalesItemPriceListLine(string itemKey, ApiBaseSalesItemPriceListLinesResource value);


        #endregion POST



        #region PUT

        /// <summary>
        /// Updates the attribute 'Currency' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="lineId">The detail identifier.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetCurrencyPriceListLine(string itemKey, string lineId, string value);

        /// <summary>
        /// Updates the attribute 'IncomeAccount' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetIncomeAccountSalesItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'IsActive' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetIsActiveSalesItem(string itemKey, bool value);

        /// <summary>
        /// Updates the attribute 'ItemTaxSchema' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetItemTaxSchemaSalesItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'ItemWithholdingTaxSchema' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetItemWithholdingTaxSchemaSalesItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'PriceAmount' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="lineId">The detail identifier.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetPriceAmountPriceListLine(string itemKey, string lineId, decimal value);

        /// <summary>
        /// Updates the attribute 'PriceList' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="lineId">The detail identifier.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetPriceListPriceListLine(string itemKey, string lineId, string value);

        /// <summary>
        /// Updates the attribute 'Unit' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="lineId">The detail identifier.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetUnitPriceListLine(string itemKey, string lineId, string value);

        /// <summary>
        /// Updates the attribute 'Unit' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> PutSetUnitSalesItem(string itemKey, string value);



        #endregion PUT


        #region DELETE

        /// <summary>
        /// Deletes the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 204	NoContent. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="lineId">The line identifier.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> DeletePriceListLineByIdentifier(string itemKey, string lineId);

        /// <summary>
        /// Deletes the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 204	Deleted. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> DeleteSalesItemByIdentifier(string id);

        /// <summary>
        /// Deletes the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 204	Deleted. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <returns></returns>
        Task<ApiResponse<string>> DeleteSalesItemByKey(string itemKey);

        #endregion DELETE
    }
}
