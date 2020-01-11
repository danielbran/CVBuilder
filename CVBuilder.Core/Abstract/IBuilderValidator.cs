using CVBuilder.Core.Models;

namespace CVBuilder.Core
{
    public interface IBuilderValidator
    {
        ICvOptionalValues Validate();
    }
}
