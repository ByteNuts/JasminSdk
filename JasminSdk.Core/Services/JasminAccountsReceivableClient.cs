using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.AccountsReceivableService;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminAccountsReceivableClient : JasminServiceClient, IJasminAccountsReceivableClient
    {
        public JasminAccountsReceivableClient(ILoggerFactory loggerFactory = null) : base(loggerFactory)
        {
        }

        public JasminAccountsReceivableClient(JasminConfig credentials, ILoggerFactory loggerFactory = null) : base(credentials, loggerFactory)
        {
            JasminClient = new HttpClient();
        }

        public ICreateReceipt CreateReceipt => new CreateReceipt($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_AccountsReceivable_CreateReceipt}", LoggerFactory.CreateLogger<CreateReceipt>());

        public IReceipt Receipt => new Receipt($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_AccountsReceivable_Receipt}", LoggerFactory.CreateLogger<Receipt>());

    }
}
