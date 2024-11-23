using ChronoSync.Application.Interfaces;
using System.Net;
using System.Text;
using System.Text.Json;

namespace ChronoSync.Infrastructure.Services
{
    internal class NetworkService : INetworkService
    {
        private readonly HttpClient _httpClient;

        public NetworkService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetPublicIPAddressAsync()
        {
            const string url = "https://api.ipify.org?format=json";

            try
            {
                string response = await SendHttpRequestAsync(url, HttpMethod.Get);
                using var jsonDocument = JsonDocument.Parse(response);
                return jsonDocument.RootElement.TryGetProperty("ip", out var ipElement)
                                                ? ipElement.GetString() ?? "Unknown IP"
                                                : "IP property not found.";
            }
            catch (JsonException ex)
            {
                throw new Exception("Error parsing the response from the IP API: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching public IP: " + ex.Message);
            }
        }
        public string GetLocalIPAddress()
        {
            string ipAddress = string.Empty;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) // IPv4
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }
            return ipAddress;
        }

        /// <summary>
        /// Private utility method for making HTTP requests (internal use only).
        /// </summary>
        /// <param name="url">The API endpoint URL.</param>
        /// <param name="method">The HTTP method (GET, POST, etc.).</param>
        /// <param name="requestBody">Optional request body for POST requests.</param>
        /// <returns>The raw response as a string.</returns>
        private async Task<string> SendHttpRequestAsync(
            string url,
            HttpMethod method,
            object? requestBody = null)
        {
            try
            {
                HttpRequestMessage request = new(method, url);
                if (method == HttpMethod.Post && requestBody != null)
                {
                    string jsonBody = JsonSerializer.Serialize(requestBody);
                    request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                }

                HttpResponseMessage response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while making HTTP request to {url}: {ex.Message}");
            }
        }
    }
}
