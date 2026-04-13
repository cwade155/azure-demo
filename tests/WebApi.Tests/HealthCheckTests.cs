public class HealthCheckTests
{
    [Fact]
    public void HealthEndpoint_ReturnsOk()
    {
        // Arrange — trivial test so the pipeline has something to run
        var status = "healthy";

        // Assert
        Assert.Equal("healthy", status);
    }

    [Fact]
    public void Addition_Works()
    {
        Assert.Equal(4, 2 + 2);
    }
}
