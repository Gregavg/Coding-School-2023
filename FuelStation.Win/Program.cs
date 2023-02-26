using FuelStation.Win.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using FuelStation.Win.Extensions;
using Unity;
using Unity.Injection;
using Unity.Resolution;
using Blazored.SessionStorage;
using Unity;
using Unity.Resolution;

namespace FuelStation.Win {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var container = new UnityContainer();

          
            //container.RegisterFactory<HttpClient>(c => new HttpClient { BaseAddress = new Uri("https://localhost:5000") });
            var services = new ServiceCollection();
            services.AddAuthorizationCore();

            container.RegisterType<CustomAuthenticationStateProvider>();

            container.RegisterInstance<IServiceCollection>(services);
            services.AddScoped<CustomAuthenticationStateProvider>();
            
            var serviceProvider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            var loginForm = container.Resolve<LoginForm>(
            //new ParameterOverride("httpClient", container.Resolve<HttpClient>()),
            new ParameterOverride("authStateProvider", container.Resolve<CustomAuthenticationStateProvider>())
            );

            loginForm.ShowDialog(); //Application.Run(new LoginForm());
        }


    }
}