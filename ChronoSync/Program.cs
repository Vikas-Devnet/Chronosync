using ChronoSync.Application.Interfaces;
using ChronoSync.Infrastructure.Services;
using ChronoSync.Presentation.Forms;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace ChronoSync
{
    internal static class Program
    {
        private static IServiceProvider? _serviceProvider;

        [STAThread]
        static void Main()
        {
            ConfigureServices();
            if (_serviceProvider == null)
            {
                MessageBox.Show("Failed to initialize application services.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            ApplicationConfiguration.Initialize();
            var splashScreen = _serviceProvider.GetRequiredService<SplashScreen>();
            if (splashScreen.ShowDialog() == DialogResult.OK)
            {
                System.Windows.Forms.Application.Run(_serviceProvider.GetRequiredService<ActionPanel>());
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private static void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            // Register services
            serviceCollection.AddSingleton<INetworkService, NetworkService>();
            serviceCollection.AddSingleton<IApplicationInfoService, ApplicationInfoService>();

            // Register forms
            serviceCollection.AddTransient<SplashScreen>();
            serviceCollection.AddTransient<ActionPanel>();

            // Build the service provider
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}