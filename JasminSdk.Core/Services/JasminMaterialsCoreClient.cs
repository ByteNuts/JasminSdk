using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MaterialsCoreService;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminMaterialsCoreClient : JasminServiceClient, IJasminMaterialsCoreClient
    {
        public JasminMaterialsCoreClient(ILoggerFactory loggerFactory = null) : base(loggerFactory)
        {
        }

        public JasminMaterialsCoreClient(JasminConfig credentials, ILoggerFactory loggerFactory = null) : base(credentials, loggerFactory)
        {
            JasminClient = new HttpClient();
        }

        public IMaterialsItem MaterialsItem => new MaterialsItem($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_AccountsReceivable_CreateReceipt}", LoggerFactory.CreateLogger<MaterialsItem>());

    }
}
