using Xunit;

namespace Exasol.ErrorReporting.Tests
{
    public class ExaErrorTest
    {
        [Fact]
        void TestCreateErrorCodeMessage()
        {
            Assert.True(ExaError.MessageBuilder("E-ERC-TEST-1").ToString() == "E-ERC-TEST-1");
        }
    }
}