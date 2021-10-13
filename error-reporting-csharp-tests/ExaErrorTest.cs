using Xunit;

namespace Exasol.ErrorReporting.Tests
{
    public class ExaErrorTest
    {
        [Fact]
        void TestCreateErrorCodeMessage()
        {
            Assert.True(ExaError.MessageBuilder("E-ERJ-TEST-1").ToString() == "E-ERJ-TEST-1");
        }
    }
}