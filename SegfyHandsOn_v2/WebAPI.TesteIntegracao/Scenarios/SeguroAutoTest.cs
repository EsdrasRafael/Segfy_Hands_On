using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using WebAPI.TesteIntegracao.Fixtures;
using Xunit;

namespace WebAPI.TesteIntegracao.Scenarios
{
        public class SeguroAutoTest
        {
            private readonly TestContext _testContext;
            public SeguroAutoTest()
            {
                _testContext = new TestContext();
            }

            [Fact]
            public async Task Values_Get_ReturnsOkResponse()
            {
                var response = await _testContext.Client.GetAsync("/api/values");
                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }

            [Fact]
            public async Task Values_GetById_ValuesReturnsOkResponse()
            {
                var response = await _testContext.Client.GetAsync("/api/values/5");
                response.EnsureSuccessStatusCode();
                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }

            [Fact]
            public async Task Values_GetById_ReturnsBadRequestResponse()
            {
                var response = await _testContext.Client.GetAsync("/api/values/XXX");
                response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            }

            [Fact]
            public async Task Values_GetById_CorrectContentType()
            {
                var response = await _testContext.Client.GetAsync("/api/values/5");
                response.EnsureSuccessStatusCode();
                response.Content.Headers.ContentType.ToString().Should().Be("text/plain; charset=utf-8");
            }
        }
    }

