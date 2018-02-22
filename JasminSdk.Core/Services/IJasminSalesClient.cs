using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.Sales;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public interface IJasminSalesClient
    {
        ICustomerParty CustomerParty { get; }

        IInvoice Invoice { get; }

        ISalesItem SalesItem { get; }
    }
}
