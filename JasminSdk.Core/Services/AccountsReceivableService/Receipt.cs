using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.AccountsReceivableService
{
    public class Receipt : IReceipt
    {
        protected readonly string EndPoint;
        protected readonly ILogger Logger;

        internal Receipt(string endpoint, ILogger logger)
        {
            EndPoint = endpoint;
            Logger = logger;
        }


        #region GET



        public async Task<ApiResponse<byte[]>> GetPrintReceipt(string id)
        {
            var url = $"{EndPoint}/{id}/print";

            var apiCall = new ApiCall<byte[]>(Logger);
            return await apiCall.Get(url);
        }


        #endregion GET


        #region POST



        #endregion POST

    }
}
