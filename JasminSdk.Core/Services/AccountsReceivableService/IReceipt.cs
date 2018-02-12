using System.Threading.Tasks;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services.AccountsReceivableService
{
    public interface IReceipt
    {

        #region GET

        Task<ApiResponse<byte[]>> GetPrintReceipt(string id);

        #endregion GET

    }
}
