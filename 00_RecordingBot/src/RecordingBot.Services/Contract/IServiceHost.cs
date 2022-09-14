// ***********************************************************************
// Assembly         : RecordingBot.Services
// Author           : Vedhagiri Prakasam
// Created          : 09-07-2022
//
// Last Modified By : Vedhagiri
// Last Modified On : 08-17-2022
// ***********************************************************************
// <copyright file="IServiceHost.cs" company="Recosenselabs.com">
//     Copyright �  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RecordingBot.Services.ServiceSetup;
using System;

namespace RecordingBot.Services.Contract
{
    /// <summary>
    /// Interface IServiceHost
    /// </summary>
    public interface IServiceHost
    {
        /// <summary>
        /// Gets the services.
        /// </summary>
        /// <value>The services.</value>
        IServiceCollection Services { get; }
        /// <summary>
        /// Gets the service provider.
        /// </summary>
        /// <value>The service provider.</value>
        IServiceProvider ServiceProvider { get; }
        /// <summary>
        /// Configures the specified services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>ServiceHost.</returns>
        ServiceHost Configure(IServiceCollection services, IConfiguration configuration);
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns>IServiceProvider.</returns>
        IServiceProvider Build();
    }
}
