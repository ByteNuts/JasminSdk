namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public interface IJasminClient
    {
        IJasminSalesClient Sales { get; }

        IJasminMasterDataBusinessEntitiesClient MasterDataBusinessEntities { get; }
    }
}
