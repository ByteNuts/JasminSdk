using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.SalesService;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public interface IJasminSales
    {
        ICustomerParty CustomerParty { get; }

        IInvoice Invoice { get; }

        ISalesItem SalesItem { get; }
    }
}
