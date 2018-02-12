using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.AccountsReceivableService;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminAccountsReceivablesClient : JasminServiceClient, IJasminAccountsReceivable
    {
        public JasminAccountsReceivablesClient()
        {
        }

        public JasminAccountsReceivablesClient(JasminConfig credentials) : base(credentials)
        {
            JasminClient = new HttpClient();
        }

        public ICreateReceipt CreateReceipt => new CreateReceipt($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_AccountsReceivable_CreateReceipt}");

        public IReceipt Receipt => new Receipt($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_AccountsReceivable_Receipt}");

    }
}
