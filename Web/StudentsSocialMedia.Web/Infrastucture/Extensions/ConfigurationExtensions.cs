namespace StudentsSocialMedia.Web.Infrastucture.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using StudentsSocialMedia.Web.ApplicationSettings;

    public static class ConfigurationExtensions
    {
        public static string GetDefaultConnectionString(this IConfiguration configuration)
            => configuration.GetConnectionString("DefaultConnection");

        public static ApplicationSettings GetAppSettings(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var appSettingsSectionCongig = configuration.GetSection("ApplicationSettings");
            services.Configure<ApplicationSettings>(appSettingsSectionCongig);

            var appSetings = appSettingsSectionCongig.Get<ApplicationSettings>();
            return appSetings;
        }
    }
}
