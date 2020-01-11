namespace CVBuilder.Core
{
    public interface IFinishable<T>
        where T : class
    {
        T Finish();
    }
}


