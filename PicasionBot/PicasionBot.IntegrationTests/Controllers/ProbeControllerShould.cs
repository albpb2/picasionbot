using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace PicasionBot.IntegrationTests.Controllers
{
    public class ProbeControllerShould : IClassFixture<WebApplicationFactory<Startup>>
    {
        private const string ControllerBaseUri = "/probe";
        private readonly HttpClient client;

        public ProbeControllerShould(WebApplicationFactory<Startup> factory)
        {
            this.client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnOk_WhenReadyIsCalled()
        {
            var result = await this.client.GetAsync($"{ControllerBaseUri}/ready");

            result.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task ReturnOk_WhenAliveIsCalled()
        {
            var result = await this.client.GetAsync($"{ControllerBaseUri}/alive");

            result.EnsureSuccessStatusCode();
        }
    }
}