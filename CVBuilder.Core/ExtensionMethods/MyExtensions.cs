using System;
using System.Text;

namespace CVBuilder.Core.ExtensionMethods
{
    /// <summary>
    /// Helper and Extension methods.
    /// </summary>
    public static class MyExtensions
    {
        /// <summary>
        /// CreateValidationException extension method to type Exception
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static Exception CreateValidationException(this Exception ex, FluentValidation.Results.ValidationResult result)
        {
            return CreateValidationException(result);
        }

        /// <summary>
        /// CreateValidationException helper method.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static Exception CreateValidationException(FluentValidation.Results.ValidationResult result)
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
