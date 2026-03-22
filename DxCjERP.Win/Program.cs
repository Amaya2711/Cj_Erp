using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DxCjERP.Win
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Leer configuración (appsettings.json)
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();

            // 2. Inyección de dependencias
            var services = new ServiceCollection();

            services.AddDbContext<DxCjERPDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Puedes registrar otros servicios aquí si lo necesitas
            // services.AddTransient<IOtroServicio, OtroServicio>();

            // 3. Construir contenedor
            var serviceProvider = services.BuildServiceProvider();

            // 4. Ejecutar formulario principal usando DI
            Application.Run(new frmLogin());
            // Si frmLogin requiere servicios inyectados, usa:
            // Application.Run(serviceProvider.GetRequiredService<frmLogin>());
        }
    }
}