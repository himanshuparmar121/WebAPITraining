using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITraining.IServices;
using WebAPITraining.Services;

namespace WebAPITraining.Configuration {
    public class IOC
    {
        public static void ConfigureService(IServiceCollection services, IConfiguration configuration) {
            services.AddScoped<IAreaServices, AreaServices>();
            services.AddScoped<IPerimeterServices, PerimeterServices>();
        }
    }
}