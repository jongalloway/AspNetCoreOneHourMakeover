using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Web.Tests
{
    public class TestingMvcFunctionalTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        public TestingMvcFunctionalTests(WebApplicationFactory<Startup> fixture)
        {
            Client = fixture.CreateClient();
        }

        public HttpClient Client { get; }

        [Fact]
        public async Task GetHomePage()
        {
            // Arrange & Act
            var response = await Client.GetAsync("/");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}