using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ParentChildProject.Entities;
using ParentChildProject.Persistence;
using ParentChildProject.Persistence.Repositories;
using ParentChildProject.Services;
using ParentChildProject.Services.ParentServices;

namespace ParentChildProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IGenericRepository<Parent>, GeniricRepository<Parent>>();
            services.AddScoped<IGenericRepository<Child>, GeniricRepository<Child>>();

            services.AddScoped<IParentService, ParentService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
