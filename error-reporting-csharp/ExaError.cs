namespace Exasol.ErrorReporting
{

    /**
     * Facade for building Exasol error messages.
     */
    public class ExaError
    {

        private ExaError()
        {
            // empty on purpose
        }

        /**
         * Get a builder for error messages.
         * 
         * @param errorCode Exasol error code
         * @return built error message
         */
        public static ErrorMessageBuilder MessageBuilder(in string errorCode)
        {
            return new ErrorMessageBuilder(errorCode);
        }
    }
}
