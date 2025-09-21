using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace hello_world_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                // Bind to all network interfaces (0.0.0.0) and listen on port 5000
                .UseUrls("http://0.0.0.0:5000")  
                .UseStartup<Startup>()  // Specify the Startup class
                .Build();
    }
}


