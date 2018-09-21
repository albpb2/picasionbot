using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace PicasionBot.IntegrationTests.Controllers
{
    public class ProbeControllerShould : ControllerTestsBase
    {
        private const string ControllerBaseUri = "/probe";

        public ProbeControllerShould(WebApplicationFactory<Startup> factory)
            : base(factory)
        {
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