using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FluentAssertions;
using PicasionBot.Application.Dtos;
using PicasionBot.Application.Dtos.Actions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace PicasionBot.IntegrationTests.Controllers
{
    public class TurnControllerShould : ControllerTestsBase
    {
        public TurnControllerShould(WebApplicationFactory<Startup> factory)
            : base(factory)
        {
        }

        [Fact]
        public async Task ReturnAnAction_WhenItReceivesAState()
        {
            const string ControllerBaseUri = "/turn";
            var serializedState = JsonConvert.SerializeObject(new State());
            var buffer = System.Text.Encoding.UTF8.GetBytes(serializedState);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await client.PostAsync(ControllerBaseUri, byteContent);

            result.EnsureSuccessStatusCode();
            Action conversion = () => result.Content.ReadAsAsync<BaseAction>();
            conversion.Should().NotThrow<Exception>();
        }
    }
}
