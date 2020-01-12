namespace CVBuilder.Core.Printers
{
    /// <summary>
    /// IPrintable interface
    /// </summary>
    public interface IPrintable
    {
        /// <summary>
        /// Write the message into the output printer
        /// </summary>
        /// <param name="value">The message to print</param>
        void Write(string value);

        /// <summary>
        /// Write a new line into printer output.
        /// </summary>
        /// <param name="value">The value to print</param>
        void WriteLine(string value);
    }
}
