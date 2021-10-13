using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RedisTest.Services;


namespace RegisDataManagerForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var serviceProvider = new ServiceCollection()
            //    .AddTransient<ICacheStrigsStack, CacheStrigsStack>().BuildServiceProvider();

            //var bar = serviceProvider.GetService<CacheStrigsStack>();


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(null));
        }


    }
}
