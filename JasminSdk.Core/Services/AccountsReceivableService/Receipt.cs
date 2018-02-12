using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.AccountsReceivableService
{
    public class Receipt : IReceipt
    {
        protected readonly string EndPoint;
        internal Receipt(string endpoint) { EndPoint = endpoint; }


        #region GET



        public async Task<ApiResponse<byte[]>> GetPrintReceipt(string id)
        {
            var url = $"{EndPoint}/{id}/print";

            return await ApiCall<byte[]>.Get(url);
        }


        #endregion GET


        #region POST



        #endregion POST

    }
}
