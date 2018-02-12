using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.AccountsReceivable.CreateReceipt;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.AccountsReceivableService
{
    public interface ICreateReceipt
    {

        #region GET


        /// <summary>
        /// Returns the list of resources that can be processed by the 'Receipts' service.
        /// Response: When successful, the response body contains the list of resources available for processing. See OpenAccountPostingLine.
        /// Response status codes:
        /// 200	OK. The operation was completed successfully.
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="pageIndex">The index of the page of the list that should be returned.</param>
        /// <param name="pageSize">The number of page elements that should be returned (max. is 1000).</param>
        /// <param name="company">The company code is the central organizational unit within the system. This is a query string parameter.</param>
        /// <param name="party">The customer designated in the account posting as the party to whom should be sent the receipt. It may or may not be the party to whom the goods or services were delivered. This is a query string parameter.</param>
        /// <param name="documentDate">The date when the document is issued. This is a query string parameter.</param>
        /// <param name="documentExchangeRate">The price of the document's currency expressed in the company's base currency. In other words, the rate at which the document's currency can be exchanged for the company's base currency. The default is inferred using the defined exchange rates on the system for the document date and currency. This is a query string parameter.</param>
        /// <param name="currency">Money unit used by the system, such as Euros (EUR) or United States Dollars (USD). This value is important for currency exchanges or to set the number of decimal places used to represent values. The default is defined on the customer party. This is a query string parameter.</param>
        /// <param name="documentType">Defines the receipt's purpose. Distinguishes the business transactions to be posted. The default receipt type is defined in the sales setup configuration setting. This is a query string parameter.</param>
        /// <param name="dueDateFrom">The accounting posting starting due date. Ignored if not set, is used to filter the due date. Only account postings with due date greater than or equal to this value will be displayed. This is a query string parameter.</param>
        /// <param name="dueDateUntil">The accounting posting end due date. Ignored if not set, is used to filter the due date. Only account postings with due date less than or equal to this value will be displayed. This is a query string parameter.</param>
        /// <param name="paymentMethod">Financial transfer method used by the entity responsible for paying a transaction. For example, cash, transfer or check payments. The default is defined on the customer party. This is a query string parameter.</param>
        /// <param name="total">Document total. Internally calculated. This is a query string parameter.</param>
        /// <param name="sourceDoc">The original document to be settled. The source documents is usually an invoice but other documents can be included on a receitp (ex: Credit or Debit Notes). Internally determined. This is a query string parameter.</param>
        /// <returns>ApiResponse&lt;List&lt;OpenAccountPostingLine&gt;&gt;</returns>
        Task<ApiResponse<List<OpenAccountPostingLine>>> GetCreateReceipt(int pageIndex, int pageSize, string company, string party, DateTime documentDate, decimal documentExchangeRate,
            string currency, string documentType, DateTime? dueDateFrom = null, DateTime? dueDateUntil = null, string paymentMethod = null, decimal? total = null, string sourceDoc = null);


        #endregion GET


        #region POST


        /// <summary>
        /// Instructs the 'Receipts' service to process the specified resources.
        /// Response: When successful, the response body is empty. The URL of the processed items is returned in the response location header.
        /// Response status codes:
        /// 201	Created. The operation was completed successfully.
        /// 400	BadRequest. The request parameters are invalid.
        /// </summary>
        /// <param name="list">List of resources that should be processed. See OpenAccountPostingLine.</param>
        /// <param name="companyKey">The company key.</param>
        /// <returns>ApiResponse&lt;string&gt;</returns>
        Task<ApiResponse<string>> PostCreateReceipt(List<OpenAccountPostingLine> list, string companyKey);


        #endregion POST
    }
}
