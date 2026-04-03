using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Mistral.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class MistralOpenApiClientTests : FixturedUnitTest
{
    public MistralOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
