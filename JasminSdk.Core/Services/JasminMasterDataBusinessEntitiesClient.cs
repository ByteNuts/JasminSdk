using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminMasterDataBusinessEntitiesClient : JasminServiceClient, IJasminMasterDataBusinessEntitiesClient
    {
        public JasminMasterDataBusinessEntitiesClient(ILoggerFactory loggerFactory = null) : base(loggerFactory)
        {
        }

        public JasminMasterDataBusinessEntitiesClient(JasminConfig credentials, ILoggerFactory loggerFactory = null) : base(credentials, loggerFactory)
        {
            JasminClient = new HttpClient();
        }

        public IItem Item => new Item($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_MasterDataBusinessEntities_Item}", LoggerFactory.CreateLogger<Item>());
    }
}
