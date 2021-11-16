using idCardApi.Controllers;
using idCardApi.Services;
using idCardApp.API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using idCardApi.Repositories;
using idCardApp.API.Repositories;

namespace idCardApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostEnvironment env, IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddDbContext<idCardContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("idCardConnection"));
            });
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IPEDateRepository, PEDateRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ILectorRepository, LectorRepository>();
            services.AddScoped<IStudentCourseRepository, StudentCourseRepository>();
            services.AddScoped<IStudentPERepository, StudentPERepository>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IPEDateService, PEDateService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ILectorService, LectorService>();
            services.AddScoped<IStudentCourseService, StudentCourseService>();
            services.AddScoped<IStudentPEService, StudentPEService>();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseRouting();
            app.UseMvc();

        }


        //api rest calls 
        // /api/courses
        /// api/courses
        /// api/courses/1
        /// api/pedates
        /// api/pedates/1
        /// api/studentpe/1 (PUT)
    }
}
