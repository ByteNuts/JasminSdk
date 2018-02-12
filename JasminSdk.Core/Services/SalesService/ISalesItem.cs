using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models.Sales.SalesItem;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.SalesService
{
    public interface ISalesItem
    {
        #region GET

        Task<ApiResponse<BaseSalesItemResource>> GetSalesItem(string itemKey);

        #endregion GET



        #region POST

        Task<ApiResponse<string>> PostSalesItem(ApiBaseSalesItemResource salesItem);

        Task<ApiResponse<string>> PostSalesItemPriceListLine(string itemKey, ApiBaseSalesItemPriceListLinesResource priceListLine);


        #endregion POST



        #region PUT

        Task<ApiResponse<string>> PutSetPriceAmountPriceListLine(string itemKey, string lineId, decimal value);

        Task<ApiResponse<string>> PutSetPriceListPriceListLine(string itemKey, string lineId, string value);

        Task<ApiResponse<string>> PutSetItemTaxSchema(string itemKey, string value);

        #endregion PUT

    }
}
