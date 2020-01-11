namespace CVBuilder.Core.Printers
{
    public  abstract class PrinterBase<T>
        where T : class
    {
        public abstract string Create(T message);
        public abstract IPrintable GetPrinter();

        public virtual void Print(T message) 
        {
            string msg = Create(message);
            var printer = GetPrinter();

            printer.WriteLine(msg);
        }
    }
}
