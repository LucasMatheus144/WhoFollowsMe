using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WFM.Domain.Repositorio.Implementacao
{
    internal class ProxyImplemention
    {
        private readonly HttpClient _httpClient;

        public ProxyImplemention(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> Get<T>(string endpoint)
        {
            try
            {
                var response = await _httpClient.GetAsync(endpoint);

                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

                return JsonSerializer.Deserialize<T>(content);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro Fetch: {ex.Message}");

                return default;
            }

        }
    }
}
