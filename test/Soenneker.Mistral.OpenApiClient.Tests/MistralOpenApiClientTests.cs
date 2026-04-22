using Soenneker.Tests.HostedUnit;

namespace Soenneker.Mistral.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MistralOpenApiClientTests : HostedUnitTest
{
    public MistralOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
