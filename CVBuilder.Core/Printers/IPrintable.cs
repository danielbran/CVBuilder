namespace CVBuilder.Core.Printers
{
    public interface IPrintable 
    {
        void Write(string value);
        void WriteLine(string value);
    }
}
