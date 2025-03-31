using Soenneker.Blazor.Snackbar.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Blazor.Snackbar.Tests;

[Collection("Collection")]
public class SnackbarUtilTests : FixturedUnitTest
{
    private readonly ISnackbarUtil _blazorlibrary;

    public SnackbarUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _blazorlibrary = Resolve<ISnackbarUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
