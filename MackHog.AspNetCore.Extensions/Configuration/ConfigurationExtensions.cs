using Microsoft.Extensions.Configuration;

namespace MackHog.AspNetCore.Extensions.Configuration
{
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// Binds the specified section to type T.
        /// </summary>
        /// <typeparam name="T">The type to bind the section to.</typeparam>
        /// <param name="configuration">The configuration.</param>
        /// <param name="section">The name of the configuration section to use.</param>
        /// <returns>The T instance from the section values.</returns>
        public static T GetInstance<T>(this IConfiguration configuration, string section) where T : class, new()
        {
            var instance = new T();
            configuration.GetSection(section).Bind(instance);
            return instance;
        }
    }
}
