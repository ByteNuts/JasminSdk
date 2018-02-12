using ByteNuts.PrimaveraBss.JasminSdk.Core;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using Owin;

namespace ByteNuts.PrimaveraBss.JasminSdk.Mvc
{
    public static class JasminSdkMvcExtensions
    {
        public static IAppBuilder UseJasminSdk(this IAppBuilder builder, JasminConfig config)
        {
            Constants.Config = config;

            return builder;
        }
    }
}
