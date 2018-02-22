using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.MaterialsManagementService;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public interface IJasminMaterialsCoreClient
    {
        IMaterialsItem MaterialsItem { get; }
    }
}
