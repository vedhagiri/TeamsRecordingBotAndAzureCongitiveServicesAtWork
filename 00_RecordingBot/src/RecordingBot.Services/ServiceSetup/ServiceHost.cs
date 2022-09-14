// ***********************************************************************
// Assembly         : RecordingBot.Services
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 09-03-2022
// ***********************************************************************
// <copyright file="ServiceHost.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.ApplicationInsights.WorkerService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Graph.Communications.Common.Telemetry;
using RecordingBot.Services.Bot;
using RecordingBot.Services.Contract;
using RecordingBot.Services.Util;
using System;

namespace RecordingBot.Services.ServiceSetup
{
    /// <summary>
    /// Class ServiceHost.
    /// Implements the <see cref="RecordingBot.Services.Contract.IServiceHost" />
    /// </summary>
    /// <seealso cref="RecordingBot.Services.Contract.IServiceHost" />
    public class ServiceHost : IServiceHost
    {
        /// <summary>
        /// Gets the services.
        /// </summary>
        /// <value>The services.</value>
        public IServiceCollection Services { get; private set; }
        /// <summary>
        /// Gets the service provider.
        /// </summary>
        /// <value>The service provider.</value>
        public IServiceProvider ServiceProvider { get; private set; }


        /// <summary>
        /// Configures the specified services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>ServiceHost.</returns>
        public ServiceHost Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IGraphLogger, GraphLogger>(_ => new GraphLogger("RecordingBot", redirectToTrace: true));
            services.Configure<AzureSettings>(configuration.GetSection(nameof(AzureSettings)));
            services.AddSingleton<IAzureSettings>(_ => _.GetRequiredService<IOptions<AzureSettings>>().Value);
			services.AddSingleton<IEventPublisher, EventGridPublisher>(_ => new EventGridPublisher(_.GetRequiredService<IOptions<AzureSettings>>().Value));
            services.AddSingleton<IBotService, BotService>();

            // Add Application Insights
            // https://docs.microsoft.com/en-us/azure/azure-monitor/app/worker-service
            string lAppInsightsKey = Environment.GetEnvironmentVariable("AzureSettings__AppInsightsKey");
            if (string.IsNullOrEmpty(lAppInsightsKey))
            {
                lAppInsightsKey = Environment.GetEnvironmentVariable("AzureSettings:AppInsightsKey");
            }

            if (string.IsNullOrEmpty(lAppInsightsKey))
            {
                throw new Exception("App insights key is null");
            }

            ApplicationInsightsServiceOptions lOptions = new ApplicationInsightsServiceOptions()
            {
                EnableDependencyTrackingTelemetryModule = true,
                EnableQuickPulseMetricStream = true,
                EnableHeartbeat = true,
                InstrumentationKey = lAppInsightsKey
            };

            services.AddApplicationInsightsTelemetryWorkerService(lOptions);

            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>IServiceProvider.</returns>
        public IServiceProvider Build()
        {
            ServiceProvider = Services.BuildServiceProvider();
            return ServiceProvider;
        }
    }
}
