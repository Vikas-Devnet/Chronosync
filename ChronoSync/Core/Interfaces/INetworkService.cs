namespace ChronoSync.Core.Interfaces
{
    public interface INetworkService
    {
        /// <summary>
        /// Fetches the public IP address from an external API.
        /// </summary>
        /// <returns>Public IP address as a string.</returns>
        Task<string> GetPublicIPAddressAsync();

        /// <summary>
        /// Fetches the local IP address from an external API.
        /// </summary>
        /// <returns>Local IP address as a string.</returns>
        string GetLocalIPAddress();
    }
}
