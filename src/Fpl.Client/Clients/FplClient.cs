using System.Net.Http;
using System.Threading;
using Fpl.Client.Models;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fpl.Client.Clients
{
    public class FplClient : IFplClient
    {
        private readonly HttpClient _client;

        public FplClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Data> GetAsync(CancellationToken cancellationToken = default)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var stream = await _client.GetStreamAsync("https://fantasy.premierleague.com/api/bootstrap-static/", cancellationToken);
            var options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };
            return await JsonSerializer.DeserializeAsync<Data>(stream, options, cancellationToken);
        }
    }
}