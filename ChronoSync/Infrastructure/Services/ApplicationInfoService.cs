using ChronoSync.Core.Interfaces;
using System.Reflection;

namespace ChronoSync.Infrastructure.Services
{
    internal class ApplicationInfoService : IApplicationInfoService
    {
        public string GetApplicationVersion()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            return version != null ? version.ToString() : "Unknown Version";
        }
    }
}
