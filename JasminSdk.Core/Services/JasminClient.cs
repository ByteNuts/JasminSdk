using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminClient : JasminServiceClient, IJasminClient
    {
        public JasminClient()
        {
        }

        public JasminClient(JasminConfig credentials) : base(credentials)
        {
            JasminClient = new HttpClient();
        }


        public IJasminAccountsReceivable AccountsReceivable => new JasminAccountsReceivablesClient();

        public IJasminMasterDataBusinessEntities MasterDataBusinessEntities => new JasminMasterDataBusinessEntitiesClient();

        public IJasminSales Sales => new JasminSalesClient();

    }
}
