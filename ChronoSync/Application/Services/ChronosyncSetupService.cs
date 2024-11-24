using ChronoSync.Core.Interfaces;

namespace ChronoSync.Application.Services
{
    public class ChronosyncSetupService(INetworkService networkService, IApplicationInfoService applicationInfoService)
    {
        private readonly INetworkService _networkService = networkService;
        private readonly IApplicationInfoService _applicationInfoService = applicationInfoService;

        public string GetCurrentVersion()
        {
            return _applicationInfoService.GetApplicationVersion();
        }
        public async Task<string> GetNetworkIpAddressAsync()
        {
            return await _networkService.GetPublicIPAddressAsync();
        }
        public string GetSystemIpAddress()
        {
            return _networkService.GetLocalIPAddress();
        }
    }
}
