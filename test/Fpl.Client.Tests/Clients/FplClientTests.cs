using System.Net.Http;
using System.Threading.Tasks;
using Fpl.Client.Clients;
using Xunit;

namespace Fpl.Client.Tests.Clients
{
    public class FplClientTests
    {
        private readonly IFplClient _client;

        public FplClientTests()
        {
            _client = new FplClient(new HttpClient());
        }

        [Fact]
        public async Task GetDataAsync_ReturnsOk()
        {
            var result = await _client.GetAsync();

            Assert.NotNull(result);
        }
    }
}