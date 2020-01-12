namespace CVBuilder.Core.Printers
{
    /// <summary>
    /// Printer Base used as base class for printers
    /// </summary>
    /// <typeparam name="T">Type of the message will be printed.</typeparam>
    public abstract class PrinterBase<T>
        where T : class
    {
        /// <summary>
        /// Create the Printer output.
        /// </summary>
        /// <param name="message">The message to print</param>
        /// <returns>The output message after the layout is created</returns>
        public abstract string Create(T message);

        /// <summary>
        /// Get the Printer, returns the printer
        /// </summary>
        /// <returns>Returns the IPrintable printer</returns>
        public abstract IPrintable GetPrinter();

        /// <summary>
        /// Print the message
        /// </summary>
        /// <param name="message">the message to print</param>
        public virtual void Print(T message) 
        {
            string msg = Create(message);
            IPrintable printer = GetPrinter();
            printer.WriteLine(msg);
        }
    }
}
