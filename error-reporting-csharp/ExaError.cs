namespace Exasol.ErrorReporting
{

    /// <summary>
    /// Facade for building Exasol error messages.
    /// </summary>
    public class ExaError
    {

        private ExaError()
        {
            // empty on purpose
        }

        public static ErrorMessageBuilder MessageBuilder(in string errorCode)
        {
            return new ErrorMessageBuilder(errorCode);
        }
    }
}
