using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using SalesSystemJupiterSoft.Services;
using SalesSystemJupiterSoft.DatabaseInitializer;

namespace SalesSystemJupiterSoft
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IArticleService,ArticleService>();
            services.AddTransient<ISalesService, SalesService>();
            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            DatabaseInitializer.DatabaseInitializer.CreateInitialDatabase();
            Application.Run(new MenuForm());
        }
    }
}
