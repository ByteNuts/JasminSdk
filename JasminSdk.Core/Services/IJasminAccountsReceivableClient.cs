using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.AccountsReceivableService;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public interface IJasminAccountsReceivableClient
    {
        ICreateReceipt CreateReceipt { get; }

        IReceipt Receipt { get; }
    }
}
