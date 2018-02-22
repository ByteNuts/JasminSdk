using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Purchases;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminPurchasesClient : JasminServiceClient, IJasminPurchasesClient
    {
        public JasminPurchasesClient(ILoggerFactory loggerFactory = null) : base(loggerFactory)
        {
        }

        public JasminPurchasesClient(JasminConfig credentials, ILoggerFactory loggerFactory = null) : base(credentials, loggerFactory)
        {
            JasminClient = new HttpClient();
        }

        public IInvoice Invoice => new Invoice($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_Purchases_Invoice}", LoggerFactory.CreateLogger<Invoice>());

    }
}
