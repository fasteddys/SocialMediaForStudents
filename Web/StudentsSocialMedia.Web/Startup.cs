namespace StudentsSocialMedia.Web
{
    using System.Reflection;

    using StudentsSocialMedia.Data;
    using StudentsSocialMedia.Data.Common;
    using StudentsSocialMedia.Data.Common.Repositories;
    using StudentsSocialMedia.Data.Models;
    using StudentsSocialMedia.Data.Repositories;
    using StudentsSocialMedia.Data.Seeding;
    using StudentsSocialMedia.Services.Data;
    using StudentsSocialMedia.Services.Mapping;
    using StudentsSocialMedia.Services.Messaging;
    using StudentsSocialMedia.Web.ViewModels;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using StudentsSocialMedia.Web.Infrastucture.Extensions;
    using StudentsSocialMedia.Web.Infrastucture.Filters;
    using Microsoft.AspNetCore.SpaServices.AngularCli;
    using StudentsSocialMedia.Web.Infrastucture.Configurations;

    public class Startup
    {
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "Client/dist";
            });

            services
                .AddDatabase(this.Configuration)
                .AddIdentity()
                .AddJwtAuthentication(services.GetAppSettings(this.Configuration), this.Configuration)
                .AddApplicationServices()
                .AddCors(options => options.AddPolicy("AllowWebApp", builder => builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithOrigins("http://localhost:4200", "http://localhost:5000", "https://localhost:4200", "https://localhost:5000")))
                .AddSwagger()
                .AddControllers();

            services.AddMvc(options =>
            {
                options.Filters.Add<ValidateModelStateActionFilter>();
                options.Filters.Add<ExceptionFilter>();
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

            // Uncomment the line below if you want to seed data in your database
            //app.SeedData();
            app.UseDeveloperExceptionPage();
            if (env.IsDevelopment())
            {
                app.UseDatabaseErrorPage();
            }

            app
                .UseSwagger()
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "StudentsSocialMedia API V1");
                })
                .UseRouting()
                .UseCors("AllowWebApp")
                .UseCors(options => options
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithOrigins("http://localhost:4200"))
                .UseAuthentication()
                .UseAuthorization()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                })
                .ApplyMigrations();



            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "Client";



                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}