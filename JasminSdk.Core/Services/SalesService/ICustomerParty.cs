using System.Collections.Generic;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.CustomerParty;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.SalesService
{
    public interface ICustomerParty
    {
        #region GET


        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the list of resources available. See CustomerPartyResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <returns>Task&lt;ApiResponse&lt;List&lt;CustomerPartyResource&gt;&gt;&gt;</returns>
        Task<ApiResponse<List<CustomerPartyResource>>> GetCustomerParties();


        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the list of resources available. See CustomerPartyResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="page">The index of the page of the list that should be returned. This is a query string parameter.</param>
        /// <param name="pageSize">The number of page elements that should be returned (max. is 1000). This is a query string parameter.</param>
        /// <returns>Task&lt;ApiResponse&lt;CustomerPartyResource&gt;&gt;</returns>
        Task<ApiResponse<CustomerPartyResource>> GetCustomerParties(int page, int pageSize);


        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See CustomerPartyResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns>Task&lt;ApiResponse&lt;CustomerPartyResource&gt;&gt;</returns>
        Task<ApiResponse<CustomerPartyResource>> GetCustomerPartyByIdentifier(string id);


        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See CustomerPartyResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <returns>Task&lt;ApiResponse&lt;CustomerPartyResource&gt;&gt;</returns>
        Task<ApiResponse<CustomerPartyResource>> GetCustomerPartyByKey(string partyKey);


        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the resources. See BaseCustomerPartyResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <returns>Task&lt;ApiResponse&lt;List&lt;BaseCustomerPartyResource&gt;&gt;&gt;</returns>
        Task<ApiResponse<List<BaseCustomerPartyResource>>> GetCustomerPartiesWithParty();


        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the resources. See BaseCustomerPartyResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="page">The index of the page of the list that should be returned. This is a query string parameter.</param>
        /// <param name="pageSize">The number of page elements that should be returned (max. is 1000). This is a query string parameter.</param>
        /// <returns>Task&lt;ApiResponse&lt;List&lt;BaseCustomerPartyResource&gt;&gt;&gt;</returns>
        Task<ApiResponse<List<BaseCustomerPartyResource>>> GetCustomerPartiesWithParty(int page, int pageSize);


        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See BaseCustomerPartyResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The identifier of the resource that should be returned.</param>
        /// <returns>Task&lt;ApiResponse&lt;BaseCustomerPartyResource&gt;&gt;</returns>
        Task<ApiResponse<BaseCustomerPartyResource>> GetCustomerPartyWithPartyByIdentifier(string id);


        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See BaseCustomerPartyResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <returns>Task&lt;ApiResponse&lt;BaseCustomerPartyResource&gt;&gt;</returns>
        Task<ApiResponse<BaseCustomerPartyResource>> GetCustomerPartyWithPartyByKey(string partyKey);


        /// <summary>
        /// Custom operation 'GetCustomerByCompanyTaxId'.<para/>
        /// Response: When successful, the response body contains a resource of type 'CustomerDataResource'. See CustomerDataResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyTaxId">CompanyTaxId This is a query string parameter.</param>
        /// <returns>Task&lt;ApiResponse&lt;CustomerDataResource&gt;&gt;</returns>
        Task<ApiResponse<CustomerDataResource>> GetCustomerByCompanyTaxId(string companyTaxId);


        #endregion GET


        #region POST


        /// <summary>
        /// Creates a new resource.<para />
        /// Response: When successful, the response body contains the new resource identifier. The resource header location property contains the URL for the new resource. See ApiCustomerPartyResource.<para />
        /// Response status codes:<para />
        /// 201	Created. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="customerPartyResource">The request body should contain the resource that should be created. See ApiCustomerPartyResource.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PostCustomerParties(ApiBaseCustomerPartyResource customerPartyResource);


        /// <summary>
        /// Creates a new resource.<para />
        /// Response: When successful, the response body contains the new resource identifier. The resource header location property contains the URL for the new resource. See ApiBaseCustomerPartyResource.<para />
        /// Response status codes:<para />
        /// 201	Created. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="customerPartyResource">The request body should contain the resource that should be created. See ApiCustomerPartyResource.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PostCustomerPartiesWithApiBaseCustomerParty(ApiBaseCustomerPartyResource customerPartyResource);


        #endregion POST


        #region PUT


        /// <summary>
        /// Updates the attribute 'AccountingParty' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetAccountingPartyCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'AccountingSchema' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetAccountingSchemaCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'CustomerGroup' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetCustomerGroupCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'DeliveryTerm' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetDeliveryTermCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'EndCustomer' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetEndCustomerCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'IsActive' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.<para />
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetIsActiveCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'Locked' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetLockedCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'OneTimeCustomer' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetOneTimeCustomerCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'PartyTaxSchema' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetPartyTaxSchemaCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'PartyWithholdingTaxSchema' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetPartyWithholdingTaxSchemaCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'PaymentMethod' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetPaymentMethodCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'PaymentTerm' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetPaymentTermCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'PriceList' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetPriceListCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'Salesperson' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> PutSetSalespersonCustomerParty(string partyKey, string value);


        /// <summary>
        /// Updates the attribute 'SettlementDiscountPercent' in the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 200	OK. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetSettlementDiscountPercentCustomerParty(string partyKey, string value);


        #endregion PUT


        #region DELETE


        /// <summary>
        /// Deletes the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 204	Deleted. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.<para />
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> DeleteCustomerPartyByIdentifier(string id);


        /// <summary>
        /// Deletes the specified resource.<para />
        /// Response: When successful, the response body is empty.<para />
        /// Response status codes:<para />
        /// 204	Deleted. The operation was completed successfully.<para />
        /// 400	BadRequest. The request parameters are invalid.<para />
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="partyKey">The key for the party. Uniquely identifies the entity/party within the organization.</param>
        /// <returns>Task&lt;ApiResponse&lt;string&gt;&gt;</returns>
        Task<ApiResponse<string>> DeleteCustomerPartyByKey(string partyKey);


        #endregion DELETE
    }
}
