using System;
using System.Text;

namespace CVBuilder.Core.ExtensionMethods
{
    /// <summary>
    /// Helper and Extension methods.
    /// </summary>
    public static class ValidationResultExtensions
    {
        /// <summary>
        /// ToException extension method to type ValidationResult
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static Exception ToException(this FluentValidation.Results.ValidationResult result)
        {
            StringBuilder exceptionString = new StringBuilder();
            foreach (var item in result.Errors)
            {
                exceptionString.Append($"{item.ErrorCode} {item.ErrorMessage} \n");
            }

            return new Exception(exceptionString.ToString());
        }
    }
}
