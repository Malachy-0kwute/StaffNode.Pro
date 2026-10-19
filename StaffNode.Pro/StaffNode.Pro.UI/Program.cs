using Microsoft.Extensions.DependencyInjection;
using StaffNode.Pro.UI.Helpers;

namespace StaffNode.Pro.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddHttpClient(HttpClientHelpers.CLIENTNAME, client =>
            {
                client.BaseAddress = new Uri("https://localhost:7210");
            });

            var provider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow(provider));           
        }
    }
}