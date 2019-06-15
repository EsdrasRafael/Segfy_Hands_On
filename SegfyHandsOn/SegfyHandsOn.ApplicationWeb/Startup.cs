using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SegfyHandsOn.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using SegfyHandsOn.Domain.Interfaces;
using SegfyHandsOn.Infra.Data.Repository;
using SegfyHandsOn.Domain.Entities;

namespace SegfyHandsOn.ApplicationWeb
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
            /* ... */

            services.AddDbContext<MySqlContext>(o => o.UseMySql("DefaultConnection"));
            services.AddTransient<ISeguroAutoRepository, SeguroAutoRepository>();
            services.AddMvc();
            /* ... */
        }

        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<MySqlContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

        //    services.Configure<CookiePolicyOptions>(options => 
        //    {
        //        options.CheckConsentNeeded = context => true;
        //        options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
        //    });
        //}
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
