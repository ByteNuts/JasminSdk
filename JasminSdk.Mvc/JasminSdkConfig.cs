using ByteNuts.PrimaveraBss.JasminSdk.Core;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;

namespace ByteNuts.PrimaveraBss.JasminSdk.Mvc
{
    public static class JasminSdkConfig
    {
        public static void UseJasminSdk(JasminConfig config)
        {
            Constants.Config = config;
            ApplicationLogging.LoggerFactory = LoggerFactory.Factory();
        }
    }
}
