using System.Collections.Generic;
using System.Text;

namespace Exasol.ErrorReporting
{

    /// <summary>
    /// Builder for Exasol error messages
    /// </summary>
    public class ErrorMessageBuilder
    {
        private readonly string errorCode;
        private readonly StringBuilder messageBuilder = new StringBuilder();
        private readonly List<string> mitigations = new List<string>();

        /// <summary>
        /// ErrorMessageBuilder constructor.
        /// </summary>
        /// <param name="errorCode">errorCode of the error you're reporting</param>
        public ErrorMessageBuilder(in string errorCode)
        {
            this.errorCode = errorCode;
        }
        /// <summary>
        /// Add a message that clarifies the error.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public ErrorMessageBuilder Message(in string message)
        {
            messageBuilder.Append(message);
            return this;
        }
        /// <summary>
        /// Describe ways to mitigate the problem.
        /// </summary>
        /// <param name="mitigation"></param>
        /// <returns></returns>
        public ErrorMessageBuilder Mitigation(in string mitigation)
        {
            mitigations.Add(mitigation);
            return this;
        }
        /// <summary>
        /// In case of unforeseen errors, ask the user to report the issue.
        /// </summary>
        /// <returns></returns>
        public ErrorMessageBuilder TicketMitigation()
        {
            Mitigation("Internal error. Please report it by opening a GitHub issue.");
            return this;
        }

        /// <summary>
        /// Print out the error message + mitigation strategies in a user friendly way.
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(errorCode);

            if (messageBuilder.Length > 0)
            {
                result.Append(": ");
                result.Append(messageBuilder.ToString());
            }

            if (mitigations.Count == 1)
            {
                result.Append(" ");
                result.Append(mitigations[0]);
            }
            else if (mitigations.Count > 1)
            {
                result.Append(" Known mitigations:");
                foreach (var mitigation in mitigations)
                {
                    result.AppendLine(mitigation);
                };
            }

            return result.ToString();
        }

    }
}