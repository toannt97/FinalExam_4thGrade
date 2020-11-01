using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ShopWebApp
{
    public class Program
    {
        public static int PAGE_SIZE = 9;

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
