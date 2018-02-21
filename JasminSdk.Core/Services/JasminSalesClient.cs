using System.Net.Http;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Helpers;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services.SalesService;
using Microsoft.Extensions.Logging;

namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Services
{
    public class JasminSalesClient : JasminServiceClient, IJasminSalesClient
    {
        public JasminSalesClient(ILoggerFactory loggerFactory = null) : base(loggerFactory)
        {
        }

        public JasminSalesClient(JasminConfig credentials, ILoggerFactory loggerFactory = null) : base(credentials, loggerFactory)
        {
            JasminClient = new HttpClient();
        }

        public ICustomerParty CustomerParty => new CustomerParty($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_Sales_CustomerParty}", LoggerFactory.CreateLogger<CustomerParty>());

        public IInvoice Invoice => new Invoice($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_Sales_Invoice}", LoggerFactory.CreateLogger<Invoice>());

        public ISalesItem SalesItem => new SalesItem($"{RequestHelper.AccountApiUrl}/{Constants.SubPath_Sales_SalesItem}", LoggerFactory.CreateLogger<SalesItem>());
    }
}
