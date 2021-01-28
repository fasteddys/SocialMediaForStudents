namespace StudentsSocialMedia.Web.Infrastucture.Configurations
{
    using System.Globalization;

    using StudentsSocialMedia.Common;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Localization;
    using Microsoft.Extensions.DependencyInjection;

    public static class LocalizationConfiguration
    {
        private const string ResourcesFolderName = "Resources";

        public static IServiceCollection ConfigureLocalization(this IServiceCollection services)
        {
            services.AddLocalization(options => options.ResourcesPath = ResourcesFolderName);
            return services;
        }
    }
}
