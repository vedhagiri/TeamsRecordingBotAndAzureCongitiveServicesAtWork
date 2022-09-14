// ***********************************************************************
// Assembly         : RecordingBot.Services
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="ServicesExtension.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecordingBot.Services.Contract;
using System;

namespace RecordingBot.Services.ServiceSetup
{
    /// <summary>
    /// Class ServicesExtension.
    /// </summary>
    public static class ServicesExtension
    {
        /// <summary>
        /// Adds the core services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            new ServiceHost().Configure(services, configuration);
        }

        /// <summary>
        /// Configures the configuration object.
        /// </summary>
        /// <typeparam name="TConfig">The type of the t configuration.</typeparam>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>TConfig.</returns>
        /// <exception cref="ArgumentNullException">services</exception>
        /// <exception cref="ArgumentNullException">configuration</exception>
        public static TConfig ConfigureConfigObject<TConfig>(this IServiceCollection services, IConfiguration configuration) where TConfig : class, new()
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            var config = new TConfig();
            configuration.Bind(config);

            if (config is IInitializable init)
            {
                init.Initialize();
            }

            services.AddSingleton(config);
            return config;
        }


        /// <summary>
        /// Configures the configuration object.
        /// </summary>
        /// <typeparam name="TConfig">The type of the t configuration.</typeparam>
        /// <param name="services">The services.</param>
        /// <returns>TConfig.</returns>
        /// <exception cref="ArgumentNullException">services</exception>
        public static TConfig ConfigureConfigObject<TConfig>(this IServiceCollection services) where TConfig : class, new()
        {

            if (services == null) throw new ArgumentNullException(nameof(services));

            var config = new TConfig();

            if (config is IInitializable init)
            {
                init.Initialize();
            }

            services.AddSingleton(config);            

            return config;
        }

    }
}
