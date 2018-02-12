using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MaterialsCoreService;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminMaterialsCoreClient : JasminServiceClient, IJasminMaterialsCore
    {
        public JasminMaterialsCoreClient()
        {
        }

        public JasminMaterialsCoreClient(JasminConfig credentials) : base(credentials)
        {
            JasminClient = new HttpClient();
        }

        public IMaterialsItem MaterialsItem => new MaterialsItem($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_AccountsReceivable_CreateReceipt}");

    }
}
