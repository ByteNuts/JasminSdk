using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.SalesService;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminSalesClient : JasminServiceClient, IJasminSales
    {
        public JasminSalesClient()
        {
        }

        public JasminSalesClient(JasminConfig credentials) : base(credentials)
        {
            JasminClient = new HttpClient();
        }

        public ICustomerParty CustomerParty => new CustomerParty($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_Sales_CustomerParty}");

        public IInvoice Invoice => new Invoice($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_Sales_Invoice}");

        public ISalesItem SalesItem => new SalesItem($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_Sales_SalesItem}");
    }
}
