using System;
using ByteNuts.PrimaveraBss.JasminSdk.Core;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Models;
using ByteNuts.PrimaveraBss.JasminSdk.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace ByteNuts.PrimaveraBss.JasminSdk.AspNetCore
{
    public static class JasminSdkSetup
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

            services.TryAddSingleton<IJasminAccountsReceivable, JasminAccountsReceivablesClient>();
            services.TryAddSingleton<IJasminMasterDataBusinessEntities, JasminMasterDataBusinessEntitiesClient>();
            services.TryAddSingleton<IJasminMaterialsCore, JasminMaterialsCoreClient>();
            services.TryAddSingleton<IJasminSales, JasminSalesClient>();

            return services;
        }
    }
}
