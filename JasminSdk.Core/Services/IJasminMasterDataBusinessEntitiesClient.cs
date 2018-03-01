using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MasterDataBusinessEntitiesService;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public interface IJasminMasterDataBusinessEntitiesClient
    {
        Entity Entity { get; }

        IItem Item { get; }
    }
}
