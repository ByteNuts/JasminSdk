using System.Collections.Generic;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Enum;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.Invoice;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Sales
{
    public interface IInvoice
    {

        #region GET


        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the list of resources available. See InvoiceResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <returns>ApiResponse&lt;List&lt;InvoiceResource&gt;&gt;</returns>
        Task<ApiResponse<List<InvoiceResource>>> GetInvoices();

        /// <summary>
        /// Returns all the resources available.<para/>
        /// Response: When successful, the response body contains the list of resources available. See InvoiceResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="page">The index of the page of the list that should be returned. This is a query string parameter.</param>
        /// <param name="pageSize">The number of page elements that should be returned (max. is 1000). This is a query string parameter.</param>
        /// <returns>ApiResponse&lt;List&lt;InvoiceResource&gt;&gt;</returns>
        Task<ApiResponse<List<InvoiceResource>>> GetInvoices(int page, int pageSize);

        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See InvoiceResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns>ApiResponse&lt;InvoiceResource&gt;</returns>
        Task<ApiResponse<InvoiceResource>> GetInvoiceByIdentifier(string id);


        /// <summary>
        /// Returns the specified resource.<para/>
        /// Response: When successful, the response body contains the resource. See InvoiceResource.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <returns>ApiResponse&lt;InvoiceResource&gt;</returns>
        Task<ApiResponse<InvoiceResource>> GetInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber);

        /// <summary>
        /// Prints the specified resource.<para/>
        /// Response: When successful, the response body contains a stream with the printed file.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The identifier of the resource that should be printed.</param>
        /// <param name="template">The report template that should be used. This is a query string parameter.</param>
        /// <returns>ApiResponse&lt;byte[]&gt;</returns>
        Task<ApiResponse<byte[]>> GetPrintInvoiceByIdentifier(string id, string template = null);

        /// <summary>
        /// Prints the specified resource.<para/>
        /// Response: When successful, the response body contains a stream with the printed file.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="template">The report template that should be used. This is a query string parameter.</param>
        /// <returns>ApiResponse&lt;byte[]&gt;</returns>
        Task<ApiResponse<byte[]>> GetPrintInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber, string template = null);



        #endregion GET


        #region POST


        /// <summary>
        /// Creates a new resource.<para/>
        /// Response: When successful, the response body contains the new resource identifier. The resource header location property contains the URL for the new resource. See ApiInvoiceResource.<para/>
        /// Response status codes:<para/>
        /// 201	Created. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="invoiceResource">The request body should contain the resource that should be created. See ApiInvoiceResource.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PostInvoice(ApiInvoiceResource invoiceResource);


        #endregion POST


        #region PUT


        /// <summary>
        /// Updates the attribute 'AccountingSchema' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute. See AccountingSchema.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetAccountingSchemaInvoice(string companyKey, string documentType, string serie, int seriesNumber, AccountingSchema value);

        /// <summary>
        /// Updates the attribute 'EmailTo' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetEmailToInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value);

        /// <summary>
        /// Updates the attribute 'FiscalDocumentType' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetFiscalDocumentTypeInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value);

        /// <summary>
        /// Updates the attribute 'IsActive' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetIsActiveInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value);

        /// <summary>
        /// Updates the attribute 'IsExternal' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetIsExternalInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value);

        /// <summary>
        /// Updates the attribute 'IsManual' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetIsManualInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value);

        /// <summary>
        /// Updates the attribute 'IsManualSerie' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetIsManualSerieInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value);

        /// <summary>
        /// Updates the attribute 'IsOneTimeCustomer' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetIsOneTimeCustomerInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value);

        /// <summary>
        /// Updates the attribute 'IsSimpleInvoice' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetIsSimpleInvoiceInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value);

        /// <summary>
        /// Updates the attribute 'IsWsCommunicable' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetIsWsCommunicableInvoice(string companyKey, string documentType, string serie, int seriesNumber, bool value);

        /// <summary>
        /// Updates the attribute 'Note' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetNoteInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value);

        /// <summary>
        /// Updates the attribute 'NoteToRecipient' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetNoteToRecipientInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value);

        /// <summary>
        /// Updates the attribute 'Notification' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetNotificationInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value);

        /// <summary>
        /// Updates the attribute 'PartyAccountingSchema' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetPartyAccountingSchemaInvoice(string companyKey, string documentType, string serie, int seriesNumber, AccountingSchema value);

        /// <summary>
        /// Updates the attribute 'Remarks' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetRemarksInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value);

        /// <summary>
        /// Updates the attribute 'SalesChannel' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetSalesChannelInvoice(string companyKey, string documentType, string serie, int seriesNumber, string value);

        /// <summary>
        /// Updates the attribute 'TransactionAccount' in the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <param name="lineId">The detail identifier.</param>
        /// <param name="value">The request body should contain the new value for the attribute.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PutSetTransactionAccountInvoiceLine(string companyKey, string documentType, string serie, int seriesNumber, string lineId, string value);



        #endregion PUT



        #region DELETE


        /// <summary>
        /// Deletes the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> DeleteInvoiceByIdentifier(string id);

        /// <summary>
        /// Deletes the specified resource.<para/>
        /// Response: When successful, the response body is empty.<para/>
        /// Response status codes:<para/>
        /// 200	OK. The operation was completed successfully.<para/>
        /// 400	BadRequest. The request parameters are invalid.<para/>
        /// 404	NotFound. The specified resource does not exist.
        /// </summary>
        /// <param name="companyKey">The company key.</param>
        /// <param name="documentType">Defines the invoice's purpose. Distinguishes the business transactions to be posted. Part of the document natural key. The default invoice type is defined in the sales setup configuration settings.</param>
        /// <param name="serie">Defines the sequence to generate the series number. Part of the document natural key. The default serie is defined on the invoice type.</param>
        /// <param name="seriesNumber">The sequential number internally determined that uniquely identifies the document within the invoice type and serie. Part of the document natural key.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> DeleteInvoiceByKey(string companyKey, string documentType, string serie, int seriesNumber);


        #endregion DELETE
    }
}
