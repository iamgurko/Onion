using Microsoft.Extensions.DependencyInjection;
using Onion.Application.Interfaces;
using Onion.Application.Services;
using Onion.Domain.Interfaces;
using Onion.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();
            //Infrastructure Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
