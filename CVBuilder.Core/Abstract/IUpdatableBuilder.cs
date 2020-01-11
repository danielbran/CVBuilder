namespace CVBuilder.Core
{
    public interface IUpdatableBuilder<T>
        where T : class
    {
        void UpdateParrentBuilder(T model);
    }
}
