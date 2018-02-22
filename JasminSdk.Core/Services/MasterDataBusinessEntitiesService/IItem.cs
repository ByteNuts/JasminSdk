using System.Collections.Generic;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.MasterDataBusinessEntities.Item;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService
{
    public interface IItem
    {
        #region GET


        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the list of resources available. See ItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <returns>ApiCall&lt;List&lt;ItemResource&gt;&gt;</returns>
        Task<ApiResponse<List<ItemResource>>> GetItems();

        /// <summary>
        /// Returns all the resources available. (paged)<para/>
        /// Response: When successful, the response body contains the list of resources available. See ItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="page">The index of the page of the list that should be returned. This is a query string parameter.</param>
        /// <param name="pageSize">The number of page elements that should be returned (max. is 1000). This is a query string parameter.</param>
        /// <returns>ApiCall&lt;List&lt;ItemResource&gt;&gt;</returns>
        Task<ApiResponse<List<ItemResource>>> GetItems(int page, int pageSize);

        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See ItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns>ApiResponse&lt;ItemResource&gt;</returns>
        Task<ApiResponse<ItemResource>> GetItemByIdentifier(string id);

        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See ItemResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <returns>ApiResponse&lt;ItemResource&gt;</returns>
        Task<ApiResponse<ItemResource>> GetItemByKey(string itemKey);

        /// <summary>
        /// Prints the specified resource.<para/>
        /// Response: When successful, the response body contains a stream with the printed file.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The identifier of the resource that should be printed.</param>
        /// <param name="template">(Optional) The report template that should be used. This is a query string parameter.</param>
        /// <returns>ApiResponse&lt;byte[]&gt;</returns>
        Task<ApiResponse<byte[]>> GetPrintItemByIdentifier(string id, string template = null);

        /// <summary>
        /// Prints the specified resource.<para/>
        /// Response: When successful, the response body contains a stream with the printed file.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="template">(Optional) The report template that should be used. This is a query string parameter.</param>
        /// <returns>ApiResponse&lt;byte[]&gt;</returns>
        Task<ApiResponse<byte[]>> GetPrintItemByKey(string itemKey, string template = null);

        /// <summary>
        /// Returns the value of attribute 'Image' of the specified resource.<para/>
        /// Response: When successful, the response is a stream with the image file.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns>ApiResponse&lt;byte[]&gt;</returns>
        Task<ApiResponse<byte[]>> GetItemImage(string id);


        #endregion GET


        #region POST


        /// <summary>
        /// Creates a new resource.<para/>
        /// Response: When successful, the response body contains the new resource identifier. The resource header location property contains the URL for the new resource. See ApiItemResource.<para/>
        /// Response status codes:<para/>
        /// 201	Created.The operation was completed successfully.<para/>
        /// 400	BadRequest.The request parameters are invalid.
        /// </summary>
        /// <param name="itemResource">The request body should contain the resource that should be created. See ApiItemResource.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PostItems(ApiItemResource itemResource);


        #endregion POST


        #region PUT


        /// <summary>
        /// Updates the attribute 'Assortment' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetAssortmentItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'Barcode' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetBarcodeItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'BaseUnit' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetBaseUnitItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'Brand' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetBrandItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'BrandModel' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetBrandModelItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'ComplementaryDescription' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetComplementaryDescriptionItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'Description' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetDescriptionItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'Image' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetImageItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'IsActive' in the specified resource.
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetIsActiveItem(string itemKey, bool value);

        /// <summary>
        /// Updates the attribute 'ItemKey' in the specified resource.
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetItemKeyItem(string itemKey, string value);

        /// <summary>
        /// Updates the attribute 'ItemType' in the specified resource.
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetItemTypeItem(string itemKey, ItemTypeEnum value);

        /// <summary>
        /// Updates the attribute 'Remarks' in the specified resource.
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetRemarksItem(string itemKey, string value);


        #endregion PUT


        #region DELETE


        /// <summary>
        /// Deletes the specified resource.
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 204	Deleted. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> DeleteItemByIdentifier(string id);

        /// <summary>
        /// Deletes the specified resource.
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 204	Deleted. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="itemKey">The key for the item. Uniquely identifies the item within the organization.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> DeleteItemByKey(string itemKey);


        #endregion DELETE
    }
}
