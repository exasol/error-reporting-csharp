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
        /// <summary>
        /// Get a builder for error messages.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public static ErrorMessageBuilder MessageBuilder(in string errorCode)
        {
            return new ErrorMessageBuilder(errorCode);
        }
    }
}
