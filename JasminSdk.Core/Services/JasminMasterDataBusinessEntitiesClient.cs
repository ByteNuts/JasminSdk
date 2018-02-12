using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminMasterDataBusinessEntitiesClient : JasminServiceClient, IJasminMasterDataBusinessEntities
    {
        public JasminMasterDataBusinessEntitiesClient()
        {
        }

        public JasminMasterDataBusinessEntitiesClient(JasminConfig credentials) : base(credentials)
        {
            JasminClient = new HttpClient();
        }

        public IItem Item => new Item($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_MasterDataBusinessEntities_Item}");
    }
}
