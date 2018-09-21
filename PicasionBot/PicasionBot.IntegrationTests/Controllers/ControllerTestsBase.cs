using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace PicasionBot.IntegrationTests.Controllers
{
    public class ControllerTestsBase : IClassFixture<WebApplicationFactory<Startup>>
    {
        protected readonly HttpClient client;

        public ControllerTestsBase(WebApplicationFactory<Startup> factory)
        {
            this.client = factory.CreateClient();
        }
    }
}
