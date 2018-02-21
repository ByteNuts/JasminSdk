using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminClient : JasminServiceClient, IJasminClient
    {
        public JasminClient(ILoggerFactory loggerFactory = null) : base(loggerFactory)
        {
        }

        public JasminClient(JasminConfig credentials, ILoggerFactory loggerFactory = null) : base(credentials, loggerFactory)
        {
            JasminClient = new HttpClient();
        }


        public IJasminAccountsReceivableClient AccountsReceivable => new JasminAccountsReceivableClient(LoggerFactory);

        public IJasminMasterDataBusinessEntitiesClient MasterDataBusinessEntities => new JasminMasterDataBusinessEntitiesClient(LoggerFactory);

        public IJasminSalesClient Sales => new JasminSalesClient(LoggerFactory);

    }
}
