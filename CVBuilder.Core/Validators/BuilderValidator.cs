namespace CVBuilder.Core.Validators
{
    public abstract class BuilderValidator<T>
        where T : class
    {
        public abstract void Validate(T model);
    }
}
