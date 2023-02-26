using FuelStation.Win.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace FuelStation.Win {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var services = new ServiceCollection();
            services.AddScoped<CustomAuthenticationStateProvider>();
            services.AddHttpClient<CustomAuthenticationStateProvider>(client => {
                client.BaseAddress = new Uri("https://localhost:5001/");
            });

            var serviceProvider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(serviceProvider.GetService<CustomAuthenticationStateProvider>()));
        }
    }
}