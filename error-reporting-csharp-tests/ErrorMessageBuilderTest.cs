using Xunit;
using Xunit.Abstractions;
namespace Exasol.ErrorReporting.Tests
{
    public class ErrorMessageBuilderTest
    {

        private readonly ITestOutputHelper output;

        public ErrorMessageBuilderTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        void testMessage()
        {
            string message = new ErrorMessageBuilder("E-ERJ-TEST-1").Message("Test message.").ToString();
            Assert.True(message == "E-ERJ-TEST-1: Test message.");
        }

        [Fact]
        void testSingleMitigation()
        {
            string message = new ErrorMessageBuilder("E-ERJ-TEST-1").Message("Something went wrong.")
                    .Mitigation("Fix it.").ToString();
            Assert.True(message == "E-ERJ-TEST-1: Something went wrong. Fix it.");
        }
    }
}