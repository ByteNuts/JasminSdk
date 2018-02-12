namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public interface IJasminClient
    {
        IJasminSales Sales { get; }

        IJasminMasterDataBusinessEntities MasterDataBusinessEntities { get; }
    }
}
