namespace CVBuilder.Core.Validators
{
    public abstract class BuilderValidator<T>
        where T : class
    {
        public abstract bool Validate(T model);
    }
}
