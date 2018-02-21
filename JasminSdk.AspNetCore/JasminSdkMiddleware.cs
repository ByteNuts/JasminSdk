using System;
using ByteNuts.PrimaveraBss.JasminSdk.Core;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace ByteNuts.PrimaveraBss.JasminSdk.AspNetCore
{
    public static class JasminSdkMiddleware
    {
        public static IServiceCollection AddJasminSdk(this IServiceCollection services, IOptions<JasminConfig> configureOptions)
        {
            if (configureOptions?.Value == null)
                throw new Exception("Missing Jasmin configuration!");

            Constants.Config = configureOptions.Value;

            return SetupJasminSdkServices(services);
        }

        public static IServiceCollection AddJasminSdk(this IServiceCollection services, JasminConfig configureOptions)
        {
            Constants.Config = configureOptions;

            return SetupJasminSdkServices(services);
        }

        private static IServiceCollection SetupJasminSdkServices(IServiceCollection services)
        {
            services.TryAddSingleton<IJasminClient, JasminClient>();

            services.TryAddSingleton<IJasminAccountsReceivableClient, JasminAccountsReceivableClient>();
            services.TryAddSingleton<IJasminMasterDataBusinessEntitiesClient, JasminMasterDataBusinessEntitiesClient>();
            services.TryAddSingleton<IJasminMaterialsCoreClient, JasminMaterialsCoreClient>();
            services.TryAddSingleton<IJasminSalesClient, JasminSalesClient>();

            return services;
        }
    }
}
